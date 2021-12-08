namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class MidnightTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldSetTimeToMidnight()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.Midnight();

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(0);
			result.Minute.Should().Be(0);
			result.Second.Should().Be(0);
			result.Millisecond.Should().Be(0);
		}
	}
}