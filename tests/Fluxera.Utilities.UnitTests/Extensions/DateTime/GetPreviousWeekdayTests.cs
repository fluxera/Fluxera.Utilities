namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetPreviousWeekdayTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetPreviousWeekday()
		{
			// Arrange
			DateTime dt = DateTime.Parse("06.05.2019");

			// Act
			DateTime result = dt.GetPreviousWeekday(DayOfWeek.Thursday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Thursday);
			result.Day.Should().Be(2);
		}
	}
}