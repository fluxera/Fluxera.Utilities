namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ConcatWithTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
