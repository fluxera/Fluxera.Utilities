namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ReplaceDiacriticsTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
