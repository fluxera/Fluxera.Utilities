namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class RepeatTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
