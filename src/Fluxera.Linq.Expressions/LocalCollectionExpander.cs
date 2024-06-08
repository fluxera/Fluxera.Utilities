namespace Fluxera.Linq.Expressions
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Reflection;
	using JetBrains.Annotations;

	/// <summary>
	///     Expands local collection values.
	/// </summary>
	/// <remarks>
	///     See: http://petemontgomery.wordpress.com/2008/08/07/caching-the-results-of-linq-queries/
	/// </remarks>
	[PublicAPI]
	internal sealed class LocalCollectionExpander : ExpressionVisitor
	{
		/// <summary>
		///     Rewrites the given expression by expanding local collections.
		/// </summary>
		/// <param name="expression"></param>
		/// <returns></returns>
		public static Expression Rewrite(Expression expression)
		{
			return new LocalCollectionExpander().Visit(expression);
		}

		/// <inheritdoc />
		protected override Expression VisitMethodCall(MethodCallExpression node)
		{
			// Pair the method's parameter types with its arguments.
			var map = node.Method.GetParameters()
				.Zip(node.Arguments, (p, a) => new { Param = p.ParameterType, Arg = a })
				.ToLinkedList();

			// Deal with instance methods.
			Type instanceType = node.Object?.Type;
			map.AddFirst(new
			{
				Param = instanceType,
				Arg = node.Object
			});

			// ReSharper disable once ConditionIsAlwaysTrueOrFalse
			// For any local collection parameters in the method, make a
			// replacement argument which will print its elements.
			var replacements = (from x in map
								where x.Param != null && x.Param.GetTypeInfo().IsGenericType
								let g = x.Param.GetGenericTypeDefinition()
								where g == typeof(IEnumerable<>) || g == typeof(List<>)
								where x.Arg.NodeType == ExpressionType.Constant
								let elementType = x.Param.GetGenericArguments().Single()
								let printer = this.MakePrinter((ConstantExpression)x.Arg, elementType)
								select new { x.Arg, Replacement = printer }).ToList();

			if(replacements.Any())
			{
				List<Expression> args = map.Select(x => (from r in replacements
														 where r.Arg == x.Arg
														 select r.Replacement).SingleOrDefault() ?? x.Arg).ToList();

				node = node.Update(args.First(), args.Skip(1));
			}

			return base.VisitMethodCall(node);
		}

		private ConstantExpression MakePrinter(ConstantExpression enumerable, Type elementType)
		{
			IEnumerable value = (IEnumerable)enumerable.Value;
			Type printerType = typeof(Printer<>).MakeGenericType(elementType);
			object printer = Activator.CreateInstance(printerType, value);

			return Expression.Constant(printer);
		}

		/// <summary>
		///     Overrides ToString to print each element of a collection.
		/// </summary>
		/// <remarks>
		///     Inherits List in order to support List.Contains instance method as well
		///     as standard Enumerable.Contains/Any extension methods.
		/// </remarks>
		private sealed class Printer<T> : List<T>
		{
			public Printer(IEnumerable collection)
			{
				this.AddRange(collection.Cast<T>());
			}

			public override string ToString()
			{
				return "{" + this.ToConcatenatedString(t => t.ToString(), "|") + "}";
			}
		}
	}
}
