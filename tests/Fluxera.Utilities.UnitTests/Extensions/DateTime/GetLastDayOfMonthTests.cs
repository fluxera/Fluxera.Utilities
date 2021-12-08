namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetLastDayOfMonthTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void GetLastDayOfMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfMonth();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Friday);
		}

		[Test]
		public void GetLastDayOfMonthWithDesiredDayOfWeek()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfMonth(DayOfWeek.Wednesday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Wednesday);
			result.Day.Should().Be(29);
		}
	}
}
