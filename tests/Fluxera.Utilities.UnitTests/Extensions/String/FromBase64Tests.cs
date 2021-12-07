namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class FromBase64Tests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
		[TestCase("SGVsbG8sV29ybGQ=")]
		public void ReturnsCorrectStringRepresentationOfBase64String(string input)
		{
			const string expectedValue = "Hello,World";

			string result = input.FromBase64();

			result.Should().Be(expectedValue);
		}
	}
}
