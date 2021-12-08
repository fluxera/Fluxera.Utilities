namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class RemoveSpecialCharactersTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
