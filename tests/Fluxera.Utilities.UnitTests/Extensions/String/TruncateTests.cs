namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class TruncateTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldTruncate()
		{
			// Arrange
			string str = "This is a longer text about text.";

			// Act
			string result = str.Truncate(20);

			// Assert
			result.Should().Be("This is a longer...");
		}

		[Test]
		[TestCase(null)]
		[TestCase("")]
		public void TruncateReturnsEmptyStringGivenNullOrEmptyString(string input)
		{
			string result = input.Truncate(5);

			result.Should().Be(string.Empty);
		}
	}
}
