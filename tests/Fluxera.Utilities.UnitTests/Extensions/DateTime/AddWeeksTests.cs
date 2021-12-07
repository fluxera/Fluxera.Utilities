namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AddWeeksTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldAddWeeks()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000");

			// Act
			DateTime result = dt.AddWeeks(2);

			// Assert
			result.Day.Should().Be(15);
		}
	}
}
