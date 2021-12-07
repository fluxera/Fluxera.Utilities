namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class EnsureEndsWithTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
