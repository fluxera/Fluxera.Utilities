// ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable ExpressionIsAlwaysNull

namespace Fluxera.Utilities.UnitTests.Extensions
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class NullableExtensionsTests
	{
		[Test]
		public void ShouldCheckIfNotNullWithNull()
		{
			// Arrange
			int? nullable = null;

			// Act
			bool isNull = nullable.IsNotNull();

			// Assert
			isNull.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIfNotNullWithValue()
		{
			// Arrange
			int? nullable = 5;

			// Act
			bool isNull = nullable.IsNotNull();

			// Assert
			isNull.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIfNullWithNull()
		{
			// Arrange
			int? nullable = null;

			// Act
			bool isNull = nullable.IsNull();

			// Assert
			isNull.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIfNullWithValue()
		{
			// Arrange
			int? nullable = 5;

			// Act
			bool isNull = nullable.IsNull();

			// Assert
			isNull.Should().BeFalse();
		}
	}
}
