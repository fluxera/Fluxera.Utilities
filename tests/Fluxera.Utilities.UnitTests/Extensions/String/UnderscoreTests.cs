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
	public class UnderscoreTests
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldUnderscore(string input, string expected)
		{
			string result = input.Underscore();
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldUnderscore()
		{
			// Arrange
			string str = "united-people of the-world";

			// Act
			string result = str.Underscore();

			// Assert
			result.Should().Be("united_people_of_the_world");
		}

		//Makes an underscored lowercase string
		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"SomeTitle", "some_title"},
			new string[] {"someTitle", "some_title"},
			new string[] {"some title", "some_title"},
			new string[] {"some title that will be underscored", "some_title_that_will_be_underscored"},
			new string[] {"SomeTitleThatWillBeUnderscored", "some_title_that_will_be_underscored"},
		};
	}
}