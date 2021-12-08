namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class RemoveSpacesTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
