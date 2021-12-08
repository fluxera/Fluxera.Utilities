namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsLeapYearTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldBeLeapYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("18.05.2000");

			// Act
			bool isLeapYear = dt.IsLeapYear();

			// Assert
			isLeapYear.Should().BeTrue();
		}
	}
}
