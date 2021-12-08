namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetWeekOfYearTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetWeekOfYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019");

			// Act
			int result = dt.GetWeekOfYear();

			// Assert
			result.Should().Be(18);
		}
	}
}