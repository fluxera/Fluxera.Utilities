namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class StringExtensionsTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldCamelize()
		{
			// Arrange
			string str = "united_people_of_the_world";

			// Act
			string result = str.Camelize();

			// Assert
			result.Should().Be("unitedPeopleOfTheWorld");
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

		[Test]
		public void ShouldOrdinalize()
		{
			// Arrange
			string str = "6";

			// Act
			string result = str.Ordinalize();

			// Assert
			result.Should().Be("6th");
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

		[Test]
		public void ShouldPluralize()
		{
			// Arrange
			string str = "person";

			// Act
			string result = str.Pluralize();

			// Assert
			result.Should().Be("people");
		}

		[Test]
		public void ShouldSingularize()
		{
			// Arrange
			string str = "people";

			// Act
			string result = str.Singularize();

			// Assert
			result.Should().Be("person");
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
		public void ShouldUncapitalize()
		{
			// Arrange
			string str = "United people of the world";

			// Act
			string result = str.Uncapitalize();

			// Assert
			result.Should().Be("united people of the world");
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
	}
}
