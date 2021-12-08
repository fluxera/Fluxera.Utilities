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
	public class TitleizeTests
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldTitleize(string input, string expected)
		{
			string result = input.Titleize();
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldTitleize()
		{
			// Arrange
			string str = "united-people_of the world";

			// Act
			string result = str.Titleize();

			// Assert
			result.Should().Be("United People Of The World");
		}

		//Uppercases individual words and removes some characters 
		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"some title", "Some Title"},
			new string[] {"some-title", "Some Title"},
			new string[] {"sometitle", "Sometitle"},
			new string[] {"some-title: The begining", "Some Title: The Begining"},
			new string[] {"some_title:_the_begining", "Some Title: The Begining"},
			new string[] {"some title: The_begining", "Some Title: The Begining"},
		};
	}
}