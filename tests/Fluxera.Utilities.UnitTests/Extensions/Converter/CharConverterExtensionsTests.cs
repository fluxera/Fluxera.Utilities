namespace Fluxera.Utilities.UnitTests.Extensions.Converter
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class CharConverterExtensionsTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldConvertToBool()
		{
			// Arrange
			char value = '1';

			// Act
			bool result = value.Convert().ToBool();

			// Assert
			result.Should().Be(true);
		}

		[Test]
		public void ShouldConvertToByte()
		{
			// Arrange
			char value = '5';

			// Act
			byte result = value.Convert().ToByte();

			// Assert
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToDecimal()
		{
			// Arrange
			char value = '5';

			// Act
			decimal result = value.Convert().ToDecimal();

			// Assert
			result.Should().Be(5m);
		}

		[Test]
		public void ShouldConvertToDouble()
		{
			// Arrange
			char value = '5';

			// Act
			double result = value.Convert().ToDouble();

			// Assert
			result.Should().Be(5d);
		}

		[Test]
		public void ShouldConvertToFloat()
		{
			// Arrange
			char value = '5';

			// Act
			float result = value.Convert().ToFloat();

			// Assert
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToInt()
		{
			// Arrange
			char value = '5';

			// Act
			int result = value.Convert().ToInt();

			// Assert
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToLong()
		{
			// Arrange
			char value = '5';

			// Act
			long result = value.Convert().ToLong();

			// Assert
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToNullableBoolFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			bool? result = value.Convert().ToNullableBool();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableBoolSuccess()
		{
			// Arrange
			char value = '1';

			// Act
			bool? result = value.Convert().ToNullableBool();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(true);
		}

		[Test]
		public void ShouldConvertToNullableByteFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			byte? result = value.Convert().ToNullableByte();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableByteSuccess()
		{
			// Arrange
			char value = '5';

			// Act
			byte? result = value.Convert().ToNullableByte();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToNullableDecimalFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			decimal? result = value.Convert().ToNullableDecimal();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableDecimalSuccess()
		{
			// Arrange
			char value = '5';

			// Act
			decimal? result = value.Convert().ToNullableDecimal();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5m);
		}

		[Test]
		public void ShouldConvertToNullableDoubleFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			double? result = value.Convert().ToNullableDouble();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableDoubleSuccess()
		{
			// Arrange
			char value = '5';

			// Act
			double? result = value.Convert().ToNullableDouble();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5d);
		}

		[Test]
		public void ShouldConvertToNullableFloatFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			float? result = value.Convert().ToNullableFloat();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableFloatSuccess()
		{
			// Arrange
			char value = '5';

			// Act
			float? result = value.Convert().ToNullableFloat();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5f);
		}

		[Test]
		public void ShouldConvertToNullableIntFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			int? result = value.Convert().ToNullableInt();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableIntSuccess()
		{
			// Arrange
			char value = '5';

			// Act
			int? result = value.Convert().ToNullableInt();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToNullableLongFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			long? result = value.Convert().ToNullableLong();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableLongSuccess()
		{
			// Arrange
			char value = '5';

			// Act
			long? result = value.Convert().ToNullableLong();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToNullableShortFailure()
		{
			// Arrange
			char value = 'e';

			// Act
			short? result = value.Convert().ToNullableShort();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableShortSuccess()
		{
			// Arrange
			char value = '5';

			// Act
			short? result = value.Convert().ToNullableShort();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToShort()
		{
			// Arrange
			char value = '5';

			// Act
			short result = value.Convert().ToShort();

			// Assert
			result.Should().Be(5);
		}
	}
}
