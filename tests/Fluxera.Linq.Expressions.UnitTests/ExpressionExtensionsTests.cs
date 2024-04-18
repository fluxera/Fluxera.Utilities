namespace Fluxera.Linq.Expressions.UnitTests
{
	using System;
	using System.Linq.Expressions;
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
	}
}
