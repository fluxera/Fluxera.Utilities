namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetPeriodOfDayTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetPeriodOfDayAfternoon()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000 14:00:00");

			// Act
			PeriodOfDay result = dt.GetPeriodOfDay();

			// Assert
			result.Should().Be(PeriodOfDay.Afternoon);
		}

		[Test]
		public void ShouldGetPeriodOfDayEvening()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000 23:00:00");

			// Act
			PeriodOfDay result = dt.GetPeriodOfDay();

			// Assert
			result.Should().Be(PeriodOfDay.Evening);
		}

		[Test]
		public void ShouldGetPeriodOfDayMorning()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000 10:00:00");

			// Act
			PeriodOfDay result = dt.GetPeriodOfDay();

			// Assert
			result.Should().Be(PeriodOfDay.Morning);
		}
	}
}