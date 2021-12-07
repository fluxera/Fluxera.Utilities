namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsDateEqualTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldDateBeEqual()
		{
			// Arrange
			DateTime dt1 = DateTime.Parse("06.05.2019 14:34:56");
			DateTime dt2 = DateTime.Parse("06.05.2019 16:34:56");

			// Act
			bool isDateEqual = dt1.IsDateEqual(dt2);

			// Assert
			isDateEqual.Should().BeTrue();
		}
	}
}