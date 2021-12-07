namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetLastDayOfWeekTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetLastDayOfWeekCurrentCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfWeek();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Sunday);
			result.Day.Should().Be(19);
		}

		[Test]
		public void ShouldGetLastDayOfWeekSaturdayLastDayCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfWeek(CultureInfo.GetCultureInfo("en-US"));

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Saturday);
			result.Day.Should().Be(18);
		}
	}
}