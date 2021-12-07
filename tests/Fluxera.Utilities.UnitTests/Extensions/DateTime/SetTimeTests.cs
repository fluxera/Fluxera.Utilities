namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class SetTimeTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldSetTimeHour()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(0);
			result.Second.Should().Be(0);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldSetTimeHourMinute()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18, 35);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(35);
			result.Second.Should().Be(0);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldSetTimeHourMinuteSecond()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18, 35, 12);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(35);
			result.Second.Should().Be(12);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldSetTimeHourMinuteSecondMillisecond()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18, 35, 12, 564);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(35);
			result.Second.Should().Be(12);
			result.Millisecond.Should().Be(564);
		}
	}
}