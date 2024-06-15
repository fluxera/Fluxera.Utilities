namespace Fluxera.Linq.Expressions
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Linq;
	using System.Linq.Expressions;
	using JetBrains.Annotations;

	/// <summary>
	///     Provides extension methods on the <see cref="Expression" /> type.
	/// </summary>
	[PublicAPI]
	public static class ExpressionExtensions
	{
		/// <summary>
		///     Converts the given <see cref="Expression" /> to a string representation.
		/// </summary>
		/// <remarks>
		///     See Pete Montgomery's post here:
		///     http://petemontgomery.wordpress.com/2008/08/07/caching-the-results-of-linq-queries/
		/// </remarks>
		/// <param name="expression"></param>
		/// <returns></returns>
		public static string ToExpressionString(this Expression expression)
		{
			if(expression is null)
			{
				return null;
			}

			Expression expr = expression;

			// Locally evaluate as much of the query as possible.
			expr = Evaluator.PartialEval(expr);

			// Support local collections.
			expr = LocalCollectionExpander.Rewrite(expr);

			// Use the string representation of the expression for the cache key.
			return expr.ToString();
		}

		/// <summary>
		///     Converts the given <see cref="Expression" /> to a string representation.
		/// </summary>
		/// <remarks>
		///     See Pete Montgomery's post here:
		///     http://petemontgomery.wordpress.com/2008/08/07/caching-the-results-of-linq-queries/
		/// </remarks>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="expression"></param>
		/// <returns></returns>
		public static string ToExpressionString<T, TResult>(this Expression<Func<T, TResult>> expression)
		{
			Expression expr = expression;
			
			return expr?.ToExpressionString();
		}

		/// <summary>
		///     Creates a <see cref="Expression" /> that represents a bitwise AND operation.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
		{
			return first.Compose(second, Expression.And);
		}

		/// <summary>
		///     Creates a <see cref="Expression" /> that represents a conditional AND operation that evaluates the second operand
		///     only if it has to.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static Expression<Func<T, bool>> AndAlso<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
		{
			return first.Compose(second, Expression.AndAlso);
		}

		/// <summary>
		///     Creates a <see cref="Expression" /> that represents a bitwise OR operation.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
		{
			return first.Compose(second, Expression.Or);
		}

		/// <summary>
		///     Creates a <see cref="Expression" /> that represents a conditional OR operation that evaluates the second operand
		///     only if it has to.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static Expression<Func<T, bool>> OrElse<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
		{
			return first.Compose(second, Expression.OrElse);
		}

		/// <summary>
		///     Creates a <see cref="BinaryExpression" /> that represents a negated bitwise AND operation.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static Expression<Func<T, bool>> AndNot<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
		{
			return first.Compose(Not(second), Expression.And);
		}

		/// <summary>
		///     Creates a <see cref="BinaryExpression" /> that represents a negated bitwise OR operation.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static Expression<Func<T, bool>> OrNot<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
		{
			return first.Compose(second.Not(), Expression.Or);
		}

		/// <summary>
		///     Creates a <see cref="UnaryExpression" /> that represents a bitwise complement operation.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="expression"></param>
		/// <returns></returns>
		public static Expression<Func<T, bool>> Not<T>(this Expression<Func<T, bool>> expression)
		{
			// Remember the parameters.
			ReadOnlyCollection<ParameterExpression> parameters = expression.Parameters;

			// Create the negated condition.
			UnaryExpression condition = Expression.Not(expression.Body);

			// Apply the new condition body to parameters of a lambda expression. 
			LambdaExpression lambda = Expression.Lambda(condition, parameters);
			return (Expression<Func<T, bool>>)lambda;
		}

		private static Expression<T> Compose<T>(this Expression<T> first, Expression<T> second, Func<Expression, Expression, Expression> merge)
		{
			// Build parameter map (from parameters of second to parameters of first).
			Dictionary<ParameterExpression, ParameterExpression> map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] }).ToDictionary(p => p.s, p => p.f);

			// Replace parameters in the second lambda expression with parameters from the first.
			Expression secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

			// Apply composition of lambda expression bodies to parameters from the first expression.
			return Expression.Lambda<T>(merge(first.Body, secondBody), first.Parameters);
		}
	}
}
