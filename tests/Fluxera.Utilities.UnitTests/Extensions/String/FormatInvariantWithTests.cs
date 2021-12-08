namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class FormatInvariantWithTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldFormatWithInvariantCulture()
		{
			// Arrange
			string str = "Hello {0:N} World!";

			// Act
			string result = str.FormatInvariantWith(5000);

			// Assert
			result.Should().Be("Hello 5,000.00 World!");
		}
	}
}
