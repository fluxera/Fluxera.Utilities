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
	public class UncapitalizeTests
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldUncapitalize(string input, string expected)
		{
			string result = input.Uncapitalize();
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldUncapitalize()
		{
			// Arrange
			string str = "United people of the world";

			// Act
			string result = str.Uncapitalize();

			// Assert
			result.Should().Be("united people of the world");
		}

		//Just lowers the first char and leaves the rest alone
		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"some title", "some title"},
			new string[] {"some Title", "some Title"},
			new string[] {"SOMETITLE", "sOMETITLE"},
			new string[] {"someTitle", "someTitle"},
			new string[] {"some title goes here", "some title goes here"},
			new string[] {"some TITLE", "some TITLE"},
		};
	}
}