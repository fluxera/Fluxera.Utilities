namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetFirstDayOfMonthTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetFirstDayOfMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfMonth();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Wednesday);
		}

		[Test]
		public void ShouldGetFirstDayOfMonthWithDesiredDayOfWeek()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfMonth(DayOfWeek.Thursday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Thursday);
			result.Day.Should().Be(2);
		}
	}
}