namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsTimeEqualTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldTimeBeEqual()
		{
			// Arrange
			DateTime dt1 = DateTime.Parse("06.05.2019 14:34:56");
			DateTime dt2 = DateTime.Parse("12.05.2019 14:34:56");

			// Act
			bool isTimeEqual = dt1.IsTimeEqual(dt2);

			// Assert
			isTimeEqual.Should().BeTrue();
		}
	}
}