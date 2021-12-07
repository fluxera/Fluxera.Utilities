namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AddMonthsToEndOfMonthTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldAddMonthsToEndOfMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("31.05.2019 16:23:53");

			// Act
			DateTime result = dt.AddMonthsToEndOfMonth(4);

			// Assert
			result.Day.Should().Be(30);
			result.Month.Should().Be(9);
			result.Year.Should().Be(2019);
		}
	}
}
