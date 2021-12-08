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
	public class DasherizeTests
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldDasherize(string input, string expected)
		{
			string result = input.Dasherize();
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldDasherize()
		{
			// Arrange
			string str = "united_people_of_the_world";

			// Act
			string result = str.Dasherize();

			// Assert
			result.Should().Be("united-people-of-the-world");
		}

		//Just replaces underscore with a dash
		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"some_title", "some-title"},
			new string[] {"some-title", "some-title"},
			new string[] {"some_title_goes_here", "some-title-goes-here"},
			new string[] {"some_title and_another", "some-title and-another"},
		};
	}
}