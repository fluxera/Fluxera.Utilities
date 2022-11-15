// ReSharper disable ExpressionIsAlwaysNull

// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace Fluxera.Utilities.UnitTests.Extensions.Nullable
{
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsNullTests
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
