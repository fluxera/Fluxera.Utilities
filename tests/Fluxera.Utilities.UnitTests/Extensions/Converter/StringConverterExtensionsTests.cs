namespace Fluxera.Utilities.UnitTests.Extensions.Converter
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class StringConverterExtensionsTests
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
			string value = "true";

			// Act
			bool result = value.Convert().ToBool();

			// Assert
			result.Should().Be(true);
		}

		[Test]
		public void ShouldConvertToByte()
		{
			// Arrange
			string value = "5";

			// Act
			byte result = value.Convert().ToByte();

			// Assert
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToDecimal()
		{
			// Arrange
			string value = "5,555";

			// Act
			decimal result = value.Convert().ToDecimal();

			// Assert
			result.Should().Be(5.555m);
		}

		[Test]
		public void ShouldConvertToDouble()
		{
			// Arrange
			string value = "5,555";

			// Act
			double result = value.Convert().ToDouble();

			// Assert
			result.Should().Be(5.555d);
		}

		[Test]
		public void ShouldConvertToFloat()
		{
			// Arrange
			string value = "5,555";

			// Act
			float result = value.Convert().ToFloat();

			// Assert
			result.Should().Be(5.555f);
		}

		[Test]
		public void ShouldConvertToGuid()
		{
			// Arrange
			string value = "9ff14c24-0517-4c96-b75e-b3461f7f14a2";

			// Act
			Guid result = value.Convert().ToGuid();

			// Assert
			result.Should().Be(Guid.Parse("9ff14c24-0517-4c96-b75e-b3461f7f14a2"));
		}

		[Test]
		public void ShouldConvertToInt()
		{
			// Arrange
			string value = "5";

			// Act
			int result = value.Convert().ToInt();

			// Assert
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToLong()
		{
			// Arrange
			string value = "5";

			// Act
			long result = value.Convert().ToLong();

			// Assert
			result.Should().Be(5);
		}

		[Test]
		public void ShouldConvertToNullableBoolFailure()
		{
			// Arrange
			string value = "";

			// Act
			bool? result = value.Convert().ToNullableBool();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableBoolSuccess()
		{
			// Arrange
			string value = "true";

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
			string value = "";

			// Act
			byte? result = value.Convert().ToNullableByte();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableByteSuccess()
		{
			// Arrange
			string value = "5";

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
			string value = "";

			// Act
			decimal? result = value.Convert().ToNullableDecimal();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableDecimalSuccess()
		{
			// Arrange
			string value = "5,555";

			// Act
			decimal? result = value.Convert().ToNullableDecimal();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5.555m);
		}

		[Test]
		public void ShouldConvertToNullableDoubleFailure()
		{
			// Arrange
			string value = "";

			// Act
			double? result = value.Convert().ToNullableDouble();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableDoubleSuccess()
		{
			// Arrange
			string value = "5,555";

			// Act
			double? result = value.Convert().ToNullableDouble();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5.555d);
		}

		[Test]
		public void ShouldConvertToNullableFloatFailure()
		{
			// Arrange
			string value = "";

			// Act
			float? result = value.Convert().ToNullableFloat();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableFloatSuccess()
		{
			// Arrange
			string value = "5,555";

			// Act
			float? result = value.Convert().ToNullableFloat();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(5.555f);
		}

		[Test]
		public void ShouldConvertToNullableGuidFailure()
		{
			// Arrange
			string value = "";

			// Act
			Guid? result = value.Convert().ToNullableGuid();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableGuidSuccess()
		{
			// Arrange
			string value = "9ff14c24-0517-4c96-b75e-b3461f7f14a2";

			// Act
			Guid? result = value.Convert().ToNullableGuid();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(Guid.Parse("9ff14c24-0517-4c96-b75e-b3461f7f14a2"));
		}

		[Test]
		public void ShouldConvertToNullableIntFailure()
		{
			// Arrange
			string value = "";

			// Act
			int? result = value.Convert().ToNullableInt();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableIntSuccess()
		{
			// Arrange
			string value = "5";

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
			string value = "";

			// Act
			long? result = value.Convert().ToNullableLong();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableLongSuccess()
		{
			// Arrange
			string value = "5";

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
			string value = "";

			// Act
			short? result = value.Convert().ToNullableShort();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableShortSuccess()
		{
			// Arrange
			string value = "5";

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
			string value = "5";

			// Act
			short result = value.Convert().ToShort();

			// Assert
			result.Should().Be(5);
		}
	}
}
