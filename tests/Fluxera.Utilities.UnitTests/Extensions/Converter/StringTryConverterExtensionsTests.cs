namespace Fluxera.Utilities.UnitTests.Extensions.Converter
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class StringTryConverterExtensionsTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldConvertToBoolFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToBool(out bool result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(false);
		}

		[Test]
		public void ShouldConvertToBoolSuccess()
		{
			// Arrange
			string value = "true";

			// Act
			bool success = value.TryConvert().ToBool(out bool result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(true);
		}

		[Test]
		public void ShouldConvertToByteFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToByte(out byte result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(0);
		}

		[Test]
		public void ShouldConvertToByteSuccess()
		{
			// Arrange
			string value = "5";

			// Act
			bool success = value.TryConvert().ToByte(out byte result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToDecimalFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToDecimal(out decimal result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(0m);
		}

		[Test]
		public void ShouldConvertToDecimalSuccess()
		{
			// Arrange
			string value = "5,555";

			// Act
			bool success = value.TryConvert().ToDecimal(out decimal result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5.555m);
		}

		[Test]
		public void ShouldConvertToDoubleFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToDouble(out double result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(0d);
		}

		[Test]
		public void ShouldConvertToDoubleSuccess()
		{
			// Arrange
			string value = "5,555";

			// Act
			bool success = value.TryConvert().ToDouble(out double result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5.555d);
		}

		[Test]
		public void ShouldConvertToFloatFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToFloat(out float result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(0f);
		}

		[Test]
		public void ShouldConvertToFloatSuccess()
		{
			// Arrange
			string value = "5,555";

			// Act
			bool success = value.TryConvert().ToFloat(out float result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5.555f);
		}

		[Test]
		public void ShouldConvertToGuidFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToGuid(out Guid result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(Guid.Empty);
		}

		[Test]
		public void ShouldConvertToGuidSuccess()
		{
			// Arrange
			string value = "aa58b42f-5df3-437a-9d60-f9125a6cd915";

			// Act
			bool success = value.TryConvert().ToGuid(out Guid result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(Guid.Parse("aa58b42f-5df3-437a-9d60-f9125a6cd915"));
		}

		[Test]
		public void ShouldConvertToIntFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToInt(out int result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(0);
		}

		[Test]
		public void ShouldConvertToIntSuccess()
		{
			// Arrange
			string value = "5";

			// Act
			bool success = value.TryConvert().ToInt(out int result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToLongFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToLong(out long result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(0);
		}

		[Test]
		public void ShouldConvertToLongSuccess()
		{
			// Arrange
			string value = "5";

			// Act
			bool success = value.TryConvert().ToLong(out long result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToShortFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool success = value.TryConvert().ToShort(out short result);

			// Assert
			success.Should().BeFalse();
			result.Should().Be(0);
		}

		[Test]
		public void ShouldConvertToShortSuccess()
		{
			// Arrange
			string value = "5";

			// Act
			bool success = value.TryConvert().ToShort(out short result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5);
		}
	}
}
