namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetDaysOfMonthCountTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForLeapYearFebruary()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.02.2000");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(29);
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForLongMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.08.2000");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(31);
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForNormalYearFebruary()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.02.2001");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(28);
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForShortMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.04.2000");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(30);
		}
	}
}