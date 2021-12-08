namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
	public class HumanizeTests
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldHumanize(string input, string expected)
		{
			string result = input.Humanize();
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldHumanize()
		{
			// Arrange
			string str = "united_people_of_the_world";

			// Act
			string result = str.Humanize();

			// Assert
			result.Should().Be("United people of the world");
		}

		//Capitalizes the first word, lowercases the rest and turns underscores into spaces
		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"some_title", "Some title"},
			new string[] {"some-title", "Some-title"},
			new string[] {"Some_title", "Some title"},
			new string[] {"someTitle", "Sometitle"},
			new string[] {"someTitle_Another", "Sometitle another"},
		};
	}
}