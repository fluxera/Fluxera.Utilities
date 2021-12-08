namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class FormatWithTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldFormatWithCurrentCulture()
		{
			// Arrange
			string str = "Hello {0:N2} World!";

			// Act
			string result = str.FormatWith(5000);

			// Assert
			result.Should().Be("Hello 5.000,00 World!");
		}

		[Test]
		public void ShouldFormatWithForeignCulture()
		{
			// Arrange
			string str = "Hello {0:N2} World!";

			// Act
			string result = str.FormatWith(CultureInfo.GetCultureInfo("en-US"), 5000);

			// Assert
			result.Should().Be("Hello 5,000.00 World!");
		}
	}
}
