namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ReplaceWithEmptyTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		
		[Test]
		[TestCase("bbb", "a")]
		[TestCase("abc", "e")]
		public void ReturnsInputStringIfStringToRemoveDoesNotExist(string input, string stringToRemove)
		{
			string result = input.ReplaceWithEmpty(stringToRemove);

			result.Should().Be(input);
		}

		[Test]
		[TestCase("abc", "a", "bc")]
		[TestCase("steve smith", "s", "teve mith")]
		public void ReturnsInputStringWithoutSubstring(string input, string stringToRemove, string expectedResult)
		{
			string result = input.ReplaceWithEmpty(stringToRemove);

			result.Should().Be(expectedResult);
		}
	}
}
