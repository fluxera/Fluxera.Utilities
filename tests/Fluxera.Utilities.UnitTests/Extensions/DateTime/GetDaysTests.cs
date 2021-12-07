namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetDaysTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetDaysBetweenDates()
		{
			// Arrange
			DateTime dt1 = DateTime.Parse("01.05.2000");
			DateTime dt2 = DateTime.Parse("23.05.2000");

			// Act
			int result = dt1.GetDays(dt2);

			// Assert
			result.Should().Be(22);
		}
	}
}