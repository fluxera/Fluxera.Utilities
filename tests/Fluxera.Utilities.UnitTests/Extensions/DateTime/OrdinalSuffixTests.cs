namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class OrdinalSuffixTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldCreateOrdinalSuffixedString()
		{
			// Arrange
			DateTime dt = DateTime.Parse("06.05.2019 14:34:56");

			// Act
			string result = dt.OrdinalSuffix();

			// Assert
			result.Should().Be("6th");
		}
	}
}