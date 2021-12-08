namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetNextWeekdayTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetNextWeekday()
		{
			// Arrange
			DateTime dt = DateTime.Parse("06.05.2019");

			// Act
			DateTime result = dt.GetNextWeekday(DayOfWeek.Friday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Friday);
			result.Day.Should().Be(10);
		}
	}
}