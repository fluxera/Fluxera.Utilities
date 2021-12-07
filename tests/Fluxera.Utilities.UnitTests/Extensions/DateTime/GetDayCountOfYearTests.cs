namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetDayCountOfYearTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetDayCountOfYearForLeapYearYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000");

			// Act
			int result = dt.GetDayCountOfYear();

			// Assert
			result.Should().Be(366);
		}

		[Test]
		public void ShouldGetDayCountOfYearForNormalYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2001");

			// Act
			int result = dt.GetDayCountOfYear();

			// Assert
			result.Should().Be(365);
		}
	}
}