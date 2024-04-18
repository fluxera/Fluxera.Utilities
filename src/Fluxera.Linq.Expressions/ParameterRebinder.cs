namespace Fluxera.Linq.Expressions
{
	using System.Collections.Generic;
	using System.Linq.Expressions;
	using JetBrains.Annotations;

	/// <summary>
	///     Represents the parameter re-binder used for rebinding the parameters
	///     for the given expressions. This is part of the solution which solves
	///     the expression parameter problem when going to Entity Framework.
	///     For more information about this solution please refer to
	///     http://blogs.msdn.com/b/meek/archive/2008/05/02/linq-to-entities-combining-predicates.aspx.
	/// </summary>
	[PublicAPI]
	public sealed class ParameterRebinder : ExpressionVisitor
	{
		private readonly Dictionary<ParameterExpression, ParameterExpression> map;

		private ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
		{
			this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
		}

		internal static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp)
		{
			return new ParameterRebinder(map).Visit(exp);
		}

		/// <inheritdoc />
		protected override Expression VisitParameter(ParameterExpression p)
		{
			if(this.map.TryGetValue(p, out ParameterExpression replacement))
			{
				p = replacement;
			}

			return base.VisitParameter(p);
		}
	}
}
