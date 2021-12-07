namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetWeeksWeekdayTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetWeeksWeekdayCurrentCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("19.05.2019");

			// Act
			DateTime result = dt.GetWeeksWeekday(DayOfWeek.Tuesday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Tuesday);
			result.Day.Should().Be(14);
		}

		[Test]
		public void ShouldGetWeeksWeekdaySaturdayLastDayCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("19.05.2019");

			// Act
			DateTime result = dt.GetWeeksWeekday(DayOfWeek.Tuesday, CultureInfo.GetCultureInfo("en-US"));

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Tuesday);
			result.Day.Should().Be(21);
		}
	}
}