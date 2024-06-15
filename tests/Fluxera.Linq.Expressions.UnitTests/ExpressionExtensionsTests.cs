namespace Fluxera.Linq.Expressions.UnitTests
{
	using System;
	using System.Linq.Expressions;
	using System.Reflection;
	using DynamicAnonymousType;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class ExpressionExtensionsTests
	{
		[Test]
		public void ShouldCheckForEmpty()
		{
			// Arrange
			Expression<Func<Person, string>> expression = x => x.Name;

			// Act
			string result = expression.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
		}

		[Test]
		public void ShouldCreateExpressionStringForComplexPropertyExpression()
		{
			// Arrange
			Expression<Func<Person, bool>> expression = x => x.Name.StartsWith("O") && x.Name.EndsWith("l");

			// Act
			string result = expression.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => (x.Name.StartsWith(\"O\") AndAlso x.Name.EndsWith(\"l\"))");
		}

		[Test]
		public void ShouldCreateExpressionStringForSimplePropertyExpression()
		{
			// Arrange
			Expression<Func<Person, string>> expression = x => x.Name;

			// Act
			string result = expression.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => x.Name");
		}

		[Test]
		public void ShouldCreateExpressionStringForSelectionExpression()
		{
			// Arrange
			Expression<Func<Person, dynamic>> expression = x => new { x.Name };

			// Act
			string result = expression.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => new <>f__AnonymousType0`1(Name = x.Name)");
		}

		[Test]
		public void ShouldCreateExpressionStringForDynamicSelectionExpression()
		{
			// Arrange
			Type type = DynamicFactory.CreateType(("Name", typeof(string)));

			PropertyInfo property = typeof(Person).GetProperty("Name");
			PropertyInfo dynamicProperty = type.GetProperty("Name");

			ParameterExpression parameter = Expression.Parameter(typeof(Person), "x");
			MemberExpression propertyExpression = Expression.MakeMemberAccess(parameter, property);
			MemberAssignment binding = Expression.Bind(dynamicProperty, propertyExpression);

			NewExpression newExpression = Expression.New(type);
			MemberInitExpression memberInitExpression = Expression.MemberInit(newExpression, binding);

			Expression<Func<Person, dynamic>> expression = Expression.Lambda<Func<Person, dynamic>>(memberInitExpression, parameter);

			// Act
			string result = expression.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => new DynamicAnonymousType0`1() {Name = x.Name}");
		}

		[Test]
		public void ShouldCheckForEmpty_Untyped()
		{
			// Arrange
			Expression<Func<Person, string>> expression = x => x.Name;
			Expression expr = expression;

			// Act
			string result = expr.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
		}

		[Test]
		public void ShouldCreateExpressionStringForComplexPropertyExpression_Untyped()
		{
			// Arrange
			Expression<Func<Person, bool>> expression = x => x.Name.StartsWith("O") && x.Name.EndsWith("l");
			Expression expr = expression;

			// Act
			string result = expr.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => (x.Name.StartsWith(\"O\") AndAlso x.Name.EndsWith(\"l\"))");
		}

		[Test]
		public void ShouldCreateExpressionStringForSimplePropertyExpression_Untyped()
		{
			// Arrange
			Expression<Func<Person, string>> expression = x => x.Name;
			Expression expr = expression;

			// Act
			string result = expr.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => x.Name");
		}

		[Test]
		public void ShouldCreateExpressionStringForSelectionExpression_Untyped()
		{
			// Arrange
			Expression<Func<Person, dynamic>> expression = x => new { x.Name };
			Expression expr = expression;

			// Act
			string result = expr.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => new <>f__AnonymousType0`1(Name = x.Name)");
		}

		[Test]
		public void ShouldCreateExpressionStringForDynamicSelectionExpression_Untyped()
		{
			// Arrange
			Type type = DynamicFactory.CreateType(("Name", typeof(string)));

			PropertyInfo property = typeof(Person).GetProperty("Name");
			PropertyInfo dynamicProperty = type.GetProperty("Name");

			ParameterExpression parameter = Expression.Parameter(typeof(Person), "x");
			MemberExpression propertyExpression = Expression.MakeMemberAccess(parameter, property);
			MemberAssignment binding = Expression.Bind(dynamicProperty, propertyExpression);

			NewExpression newExpression = Expression.New(type);
			MemberInitExpression memberInitExpression = Expression.MemberInit(newExpression, binding);

			Expression<Func<Person, dynamic>> expression = Expression.Lambda<Func<Person, dynamic>>(memberInitExpression, parameter);
			Expression expr = expression;

			// Act
			string result = expr.ToExpressionString();

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("x => new DynamicAnonymousType0`1() {Name = x.Name}");
		}
	}
}
