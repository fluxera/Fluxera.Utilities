namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class CalculateAgeTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldCalculateAge()
		{
			// Arrange
			DateTime referenceDate = DateTime.Parse("05.01.2000");
			DateTime dt = DateTime.Parse("05.01.1980");

			// Act
			int age = dt.CalculateAge(referenceDate);

			// Assert
			age.Should().Be(20);
		}
	}
}