namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetFirstDayOfWeekTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetFirstDayOfWeekCurrentCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfWeek();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Monday);
			result.Day.Should().Be(13);
		}

		[Test]
		public void ShouldGetFirstDayOfWeekSundayFirstDayCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfWeek(CultureInfo.GetCultureInfo("en-US"));

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Sunday);
			result.Day.Should().Be(12);
		}
	}
}