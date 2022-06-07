namespace Fluxera.Utilities.UnitTests.Extensions.Object
{
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class GetDefaultValueTests
	{
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
