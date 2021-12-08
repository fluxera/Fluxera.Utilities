namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsWeekendTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldBeWeekend()
		{
			// Arrange
			DateTime dt = DateTime.Parse("18.05.2019");

			// Act
			bool isWeekend = dt.IsWeekend();

			// Assert
			isWeekend.Should().BeTrue();
		}
	}
}