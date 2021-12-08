namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ToUnixTimestampTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldConvertToUnixTimestampOneDay()
		{
			// Arrange
			DateTime dt = DateTime.Parse("02.01.1970 00:00:00");

			// Act
			int result = dt.ToUnixTimestamp();

			// Assert
			result.Should().Be(1 * 24 * 60 * 60);
		}

		[Test]
		public void ShouldConvertToUnixTimestampOneYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.01.1971 00:00:00");

			// Act
			int result = dt.ToUnixTimestamp();

			// Assert
			result.Should().Be(365 * 24 * 60 * 60);
		}

		[Test]
		public void ShouldConvertToUnixTimestampZero()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.01.1970 00:00:00");

			// Act
			int result = dt.ToUnixTimestamp();

			// Assert
			result.Should().Be(0);
		}
	}
}