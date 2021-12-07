namespace Fluxera.Utilities.UnitTests.Extensions.Converter
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class CharTryConverterExtensionsTests
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
			char value = 'e';

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
			char value = '1';

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
			char value = 'e';

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
			char value = '5';

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
			char value = 'e';

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
			char value = '5';

			// Act
			bool success = value.TryConvert().ToDecimal(out decimal result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5m);
		}

		[Test]
		public void ShouldConvertToDoubleFailure()
		{
			// Arrange
			char value = 'e';

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
			char value = '5';

			// Act
			bool success = value.TryConvert().ToDouble(out double result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5d);
		}

		[Test]
		public void ShouldConvertToFloatFailure()
		{
			// Arrange
			char value = 'e';

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
			char value = '5';

			// Act
			bool success = value.TryConvert().ToFloat(out float result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5f);
		}

		[Test]
		public void ShouldConvertToIntFailure()
		{
			// Arrange
			char value = 'e';

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
			char value = '5';

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
			char value = 'e';

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
			char value = '5';

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
			char value = 'e';

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
			char value = '5';

			// Act
			bool success = value.TryConvert().ToShort(out short result);

			// Assert
			success.Should().BeTrue();
			result.Should().Be(5);
		}
	}
}
