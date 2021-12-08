namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class EnsureStartsWithTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
