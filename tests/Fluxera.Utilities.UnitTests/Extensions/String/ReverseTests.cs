namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ReverseTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldReverse()
		{
			// Arrange
			string str = "1234567890";

			// Act
			string result = str.Reverse();

			// Assert
			result.Should().Be("0987654321");
		}

		[Test]
		[TestCase("a", "a")]
		[TestCase("abcde", "edcba")]
		public void ReturnsReversedString(string input, string expectedResult)
		{
			string result = input.Reverse();

			result.Should().Be(expectedResult);
		}

		[Test]
		[TestCase(null)]
		[TestCase("")]
		public void ReverseReturnsEmptyStringGivenNullOrEmptyString(string input)
		{
			string result = input.Reverse();

			result.Should().Be(string.Empty);
		}
	}
}
