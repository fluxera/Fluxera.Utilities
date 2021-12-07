namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsTodayTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldConfirmThatItIsToday()
		{
			// Arrange
			DateTime dt = DateTime.Now;

			// Act
			bool isToday = dt.IsToday();

			// Assert
			isToday.Should().BeTrue();
		}
	}
}