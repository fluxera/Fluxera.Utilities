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
	public class PascalizeTests 
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldPascalize(string input, string expected)
		{
			string result = input.Camelize();
			expected = expected.Substring(0, 1).ToLower() + expected.Substring(1);
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldPascalize()
		{
			// Arrange
			string str = "united_people_of_the_world";

			// Act
			string result = str.Pascalize();

			// Assert
			result.Should().Be("UnitedPeopleOfTheWorld");
		}

		//Pascalize a camelized string.
		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"customer", "Customer" },
			new string[] {"CUSTOMER", "CUSTOMER" },
			new string[] {"CUStomer", "CUStomer" },
			new string[] {"customer_name", "CustomerName" },
			new string[] {"customer_first_name", "CustomerFirstName" },
			new string[] {"customer_first_name_goes_here", "CustomerFirstNameGoesHere" },
			new string[] {"customer name", "Customer name" },
		};
	}
}