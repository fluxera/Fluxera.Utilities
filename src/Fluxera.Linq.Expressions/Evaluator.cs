﻿namespace Fluxera.Linq.Expressions
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;
	using JetBrains.Annotations;

	/// <summary>
	///     Enables the partial evaluation of queries.
	/// </summary>
	/// <remarks>
	///     From http://msdn.microsoft.com/en-us/library/bb546158.aspx
	///     Copyright notice http://msdn.microsoft.com/en-gb/cc300389.aspx#O
	/// </remarks>
	[PublicAPI]
	internal static class Evaluator
	{
		/// <summary>
		///     Performs evaluation and replacement of independent sub-trees.
		/// </summary>
		/// <param name="expression">The root of the expression tree.</param>
		/// <param name="fnCanBeEvaluated">
		///     A function that decides whether a given expression node can be part of the local
		///     function.
		/// </param>
		/// <returns>A new tree with sub-trees evaluated and replaced.</returns>
		public static Expression PartialEval(Expression expression, Func<Expression, bool> fnCanBeEvaluated)
		{
			return new SubtreeEvaluator(new Nominator(fnCanBeEvaluated).Nominate(expression)).Eval(expression);
		}

		/// <summary>
		///     Performs evaluation and replacement of independent sub-trees.
		/// </summary>
		/// <param name="expression">The root of the expression tree.</param>
		/// <returns>A new tree with sub-trees evaluated and replaced.</returns>
		public static Expression PartialEval(Expression expression)
		{
			return PartialEval(expression, CanBeEvaluatedLocally);
		}

		private static bool CanBeEvaluatedLocally(Expression expression)
		{
			return expression.NodeType != ExpressionType.Parameter;
		}

		/// <summary>
		///     Evaluates and replaces sub-trees when first candidate is reached (top-down).
		/// </summary>
		private class SubtreeEvaluator : ExpressionVisitor
		{
			private readonly HashSet<Expression> candidates;

			internal SubtreeEvaluator(HashSet<Expression> candidates)
			{
				this.candidates = candidates;
			}

			internal Expression Eval(Expression exp)
			{
				return this.Visit(exp);
			}

			public override Expression Visit(Expression exp)
			{
				if(exp == null)
				{
					return null;
				}

				if(this.candidates.Contains(exp))
				{
					return this.Evaluate(exp);
				}

				return base.Visit(exp);
			}

			/// <inheritdoc />
			protected override Expression VisitMemberInit(MemberInitExpression node)
			{
				return node;
			}

			private Expression Evaluate(Expression e)
			{
				if(e.NodeType == ExpressionType.Constant)
				{
					return e;
				}

				LambdaExpression lambda = Expression.Lambda(e);
				Delegate fn = lambda.Compile();
				return Expression.Constant(fn.DynamicInvoke(null), e.Type);
			}
		}

		/// <summary>
		///     Performs bottom-up analysis to determine which nodes can possibly
		///     be part of an evaluated sub-tree.
		/// </summary>
		private class Nominator : ExpressionVisitor
		{
			private readonly Func<Expression, bool> fnCanBeEvaluated;
			private HashSet<Expression> candidates;
			private bool cannotBeEvaluated;

			internal Nominator(Func<Expression, bool> fnCanBeEvaluated)
			{
				this.fnCanBeEvaluated = fnCanBeEvaluated;
			}

			internal HashSet<Expression> Nominate(Expression expression)
			{
				this.candidates = new HashSet<Expression>();
				this.Visit(expression);
				return this.candidates;
			}

			public override Expression Visit(Expression expression)
			{
				if(expression != null)
				{
					bool saveCannotBeEvaluated = this.cannotBeEvaluated;
					this.cannotBeEvaluated = false;
					base.Visit(expression);
					if(!this.cannotBeEvaluated)
					{
						if(this.fnCanBeEvaluated(expression))
						{
							this.candidates.Add(expression);
						}
						else
						{
							this.cannotBeEvaluated = true;
						}
					}

					this.cannotBeEvaluated |= saveCannotBeEvaluated;
				}

				return expression;
			}
		}
	}
}
