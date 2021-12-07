namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System;
	using System.Globalization;
	using System.Text;
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

		public enum TestEnum
		{
			One,
			Two,
			Three,
		}

		[Test]
		[TestCase("")]
		[TestCase(null)]
		public void FromBase64ReturnsEmptyStringWhenCalledOnNullOrEmpty(string input)
		{
			const string expectedValue = "";

			string result = input.FromBase64();

			result.Should().Be(expectedValue);
		}

		[Test]
		[TestCase("Hello,World")]
		public void ReturnsCorrectBase64RepresentationOfString(string input)
		{
			const string expectedValue = "SGVsbG8sV29ybGQ=";

			string result = input.ToBase64();

			result.Should().Be(expectedValue);
		}

		[Test]
		[TestCase("SGVsbG8sV29ybGQ=")]
		public void ReturnsCorrectStringRepresentationOfBase64String(string input)
		{
			const string expectedValue = "Hello,World";

			string result = input.FromBase64();

			result.Should().Be(expectedValue);
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
		public void ShouldCheckIfStringIsNumeric()
		{
			// Arrange & Act & Assert
			"45,789".IsNumeric().Should().BeTrue();
			"-45,789".IsNumeric().Should().BeTrue();
			"45".IsNumeric().Should().BeTrue();
			"-45".IsNumeric().Should().BeTrue();
			"5.000".IsNumeric().Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIsNotNullOrEmptyWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNotNullOrEmpty();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNotNullOrEmptyWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNotNullOrEmpty();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNotNullOrWhiteSpaceWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNotNullOrWhiteSpace();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNotNullOrWhiteSpaceWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNotNullOrWhiteSpace();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNullOrEmptyWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNullOrEmpty();

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIsNullOrEmptyWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNullOrEmpty();

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIsNullOrWhiteSpaceWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNullOrWhiteSpace();

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIsNullOrWhiteSpaceWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNullOrWhiteSpace();

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldConcatWith()
		{
			// Arrange
			string str = "ha";

			// Act
			string result = str.ConcatWith("ho", "he");

			// Assert
			// ReSharper disable once StringLiteralTypo
			result.Should().Be("hahohe");
		}

		[Test]
		public void ShouldConcatWithDelimiter()
		{
			// Arrange
			string str = "ha";

			// Act
			string result = str.ConcatWith(',', "ho", "he");

			// Assert
			// ReSharper disable once StringLiteralTypo
			result.Should().Be("ha,ho,he");
		}

		[Test]
		public void ShouldConvertToEnum()
		{
			// Arrange
			string str = "Two";

			// Act
			TestEnum result = str.ToEnum<TestEnum>();

			// Assert
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToEnumIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			TestEnum result = str.ToEnum<TestEnum>(true);

			// Assert
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToEnumNotExists()
		{
			// Arrange
			string str = "Four";

			// Act
			Action action = () => str.ToEnum<TestEnum>();

			// Assert
			action.Should().Throw<ArgumentException>();
		}

		[Test]
		public void ShouldConvertToEnumNotIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			Action action = () => str.ToEnum<TestEnum>(false);

			// Assert
			action.Should().Throw<ArgumentException>();
		}

		[Test]
		public void ShouldConvertToNullableEnum()
		{
			// Arrange
			string str = "Two";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>();

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToNullableEnumIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>(true);

			// Assert
			result.Should().NotBeNull();
			result.Should().Be(TestEnum.Two);
		}

		[Test]
		public void ShouldConvertToNullableEnumNotExists()
		{
			// Arrange
			string str = "Four";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>();

			// Assert
			result.Should().BeNull();
		}

		[Test]
		public void ShouldConvertToNullableEnumNotIgnoreCase()
		{
			// Arrange
			string str = "two";

			// Act
			TestEnum? result = str.ToNullableEnum<TestEnum>(false);

			// Assert
			result.Should().BeNull();
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
		public void ShouldEnsureEndsWith()
		{
			// Arrange
			string str = "log.";

			// Act
			string result = str.EnsureEndsWith("txt");

			// Assert
			result.Should().Be("log.txt");
		}

		[Test]
		public void ShouldEnsureStartsWith()
		{
			// Arrange
			string str = ".txt";

			// Act
			string result = str.EnsureStartsWith("log");

			// Assert
			result.Should().Be("log.txt");
		}

		[Test]
		public void ShouldFormatWithCurrentCulture()
		{
			// Arrange
			string str = "Hello {0:N2} World!";

			// Act
			string result = str.FormatWith(5000);

			// Assert
			result.Should().Be("Hello 5.000,00 World!");
		}

		[Test]
		public void ShouldFormatWithForeignCulture()
		{
			// Arrange
			string str = "Hello {0:N2} World!";

			// Act
			string result = str.FormatWith(CultureInfo.GetCultureInfo("en-US"), 5000);

			// Assert
			result.Should().Be("Hello 5,000.00 World!");
		}

		[Test]
		public void ShouldFormatWithInvariantCulture()
		{
			// Arrange
			string str = "Hello {0:N} World!";

			// Act
			string result = str.FormatInvariantWith(5000);

			// Assert
			result.Should().Be("Hello 5,000.00 World!");
		}

		[Test]
		public void ShouldGetBytesDefaultEncoding()
		{
			// Arrange
			string str = "Test";

			// Act
			byte[] result = str.GetBytes();

			// Assert
			result.Should().NotBeNull();
			result.Length.Should().Be(4);
		}

		[Test]
		public void ShouldGetBytesUtf32Encoding()
		{
			// Arrange
			string str = "Test";

			// Act
			byte[] result = str.GetBytes(Encoding.UTF32);

			// Assert
			result.Should().NotBeNull();
			result.Length.Should().Be(16);
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
		public void ShouldRemoveSpaces()
		{
			// Arrange
			string str = "united people of the world";

			// Act
			string result = str.RemoveSpaces();

			// Assert
			// ReSharper disable once StringLiteralTypo
			result.Should().Be("unitedpeopleoftheworld");
		}

		[Test]
		public void ShouldRemoveSpecialCharacters()
		{
			// Arrange
			string str = "!32§1%abc$x(y)z&1?2=3";

			// Act
			string result = str.RemoveSpecialCharacters();

			// Assert
			result.Should().Be("321abcxyz123");
		}

		[Test]
		public void ShouldRemoveSpecialCharactersWithIgnoreList()
		{
			// Arrange
			string str = "!32§1%abc$x(y)z&1?2=3";

			// Act
			string result = str.RemoveSpecialCharacters('$');

			// Assert
			result.Should().Be("321abc$xyz123");
		}

		[Test]
		public void ShouldRepeat()
		{
			// Arrange
			string str = "test";

			// Act
			string result = str.Repeat(3);

			// Assert
			// ReSharper disable once StringLiteralTypo
			result.Should().Be("testtesttest");
		}

		[Test]
		public void ShouldReplaceDiacritics()
		{
			// Arrange
			// ReSharper disable once StringLiteralTypo
			string str = "Grützi!";

			// Act
			string result = str.ReplaceDiacritics();

			// Assert
			// ReSharper disable once StringLiteralTypo
			result.Should().Be("Grutzi!");
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

		[Test]
		[TestCase("")]
		[TestCase(null)]
		public void ToBase64ReturnsEmptyStringWhenCalledOnNullOrEmpty(string input)
		{
			const string expectedValue = "";

			string result = input.ToBase64();

			result.Should().Be(expectedValue);
		}

		[Test]
		[TestCase(null)]
		[TestCase("")]
		public void TruncateReturnsEmptyStringGivenNullOrEmptyString(string input)
		{
			string result = input.Truncate(5);

			result.Should().Be(string.Empty);
		}
	}
}
