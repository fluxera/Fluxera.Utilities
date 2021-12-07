// ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable ExpressionIsAlwaysNull

namespace Fluxera.Utilities.UnitTests.Extensions
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ObjectExtensionsTests
	{
		private class MyClass { }

		private enum MyEnum
		{
			One,
			Two,
		}

		private struct MyStruct { }

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

		[Test]
		public void ShouldGetDefaultValueEnum()
		{
			// Arrange
			MyEnum obj = MyEnum.Two;

			// Act
			MyEnum result = obj.GetDefaultValue();

			// Assert
			result.Should().Be(MyEnum.One);
		}

		[Test]
		public void ShouldGetDefaultValueObject()
		{
			// Arrange
			object obj = new object();

			// Act
			object result = obj.GetDefaultValue();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldGetDefaultValueStruct()
		{
			// Arrange
			MyStruct obj = new MyStruct();

			// Act
			MyStruct result = obj.GetDefaultValue();

			// Assert
			result.Should().Be(default(MyStruct));
		}

		[Test]
		public void ShouldGetDefaultValueValueType()
		{
			// Arrange
			int obj = 6;

			// Act
			int result = obj.GetDefaultValue();

			// Assert
			result.Should().Be(0);
		}
	}
}
