namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ToEnumTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldConvertToEnum()
		{
			// Arrange
			string str = "Two";

			// Act
			TestEnum result = str.ToEnum<TestEnum>();

			// Assert
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToEnumIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			TestEnum result = str.ToEnum<TestEnum>(true);

			// Assert
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToEnumNotExists()
		{
			// Arrange
			string str = "Four";

			// Act
			Action action = () => str.ToEnum<TestEnum>();

			// Assert
			action.Should().Throw<ArgumentException>();
		}

		[Test]
		public void ShouldConvertToEnumNotIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			Action action = () => str.ToEnum<TestEnum>(false);

			// Assert
			action.Should().Throw<ArgumentException>();
		}

		[Test]
		public void ShouldConvertToNullableEnum()
		{
			// Arrange
			string str = "Two";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToNullableEnumIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>(true);

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToNullableEnumNotExists()
		{
			// Arrange
			string str = "Four";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableEnumNotIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>(false);

			// Assert
			result.Should().BeNull();
		}
	}
}
