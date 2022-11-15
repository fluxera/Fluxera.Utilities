// ReSharper disable ConditionIsAlwaysTrueOrFalse

// ReSharper disable ExpressionIsAlwaysNull

namespace Fluxera.Utilities.UnitTests.Extensions.Object
{
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsNullTests
	{
		[Test]
		public void ShouldCheckForNotNullWithNotNullClass()
		{
			// Arrange
			MyClass obj = new MyClass();

			// Act
			bool isNull = obj.IsNotNull();

			// Assert
			isNull.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckForNotNullWithNotNullObject()
		{
			// Arrange
			object obj = new object();

			// Act
			bool isNull = obj.IsNotNull();

			// Assert
			isNull.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckForNotNullWithNullClass()
		{
			// Arrange
			MyClass obj = null;

			// Act
			bool isNull = obj.IsNotNull();

			// Assert
			isNull.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckForNotNullWithNullObject()
		{
			// Arrange
			object obj = null;

			// Act
			bool isNull = obj.IsNotNull();

			// Assert
			isNull.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckForNullWithNotNullClass()
		{
			// Arrange
			MyClass obj = new MyClass();

			// Act
			bool isNull = obj.IsNull();

			// Assert
			isNull.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckForNullWithNotNullObject()
		{
			// Arrange
			object obj = new object();

			// Act
			bool isNull = obj.IsNull();

			// Assert
			isNull.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckForNullWithNullClass()
		{
			// Arrange
			MyClass obj = null;

			// Act
			bool isNull = obj.IsNull();

			// Assert
			isNull.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckForNullWithNullObject()
		{
			// Arrange
			object obj = null;

			// Act
			bool isNull = obj.IsNull();

			// Assert
			isNull.Should().BeTrue();
		}
	}
}
