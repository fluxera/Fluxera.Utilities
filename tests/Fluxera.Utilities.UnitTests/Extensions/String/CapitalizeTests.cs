namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
	public class CapitalizeTests
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldCapitalize(string input, string expected)
		{
			string result = input.Capitalize();
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldCapitalize()
		{
			// Arrange
			string str = "united people of the world";

			// Act
			string result = str.Capitalize();

			// Assert
			result.Should().Be("United people of the world");
		}
		
		//Capitalizes the first char and lowers the rest of the string
		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"some title", "Some title"},
			new string[] {"some Title", "Some title"},
			new string[] {"SOMETITLE", "Sometitle"},
			new string[] {"someTitle", "Sometitle"},
			new string[] {"some title goes here", "Some title goes here"},
			new string[] {"some TITLE", "Some title"},
		};
	}
}
