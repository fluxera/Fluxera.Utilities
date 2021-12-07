namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class NextMonthTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetNextMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.NextMonth();

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(6);
			result.Year.Should().Be(2019);
		}

		[Test]
		public void ShouldGetNextMonthLargeToSmallMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("31.05.2019 16:23:53");

			// Act
			DateTime result = dt.NextMonth();

			// Assert
			result.Day.Should().Be(30);
			result.Month.Should().Be(6);
			result.Year.Should().Be(2019);
		}
	}
}