namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ToBase64Tests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
		[TestCase("")]
		[TestCase(null)]
		public void ToBase64ReturnsEmptyStringWhenCalledOnNullOrEmpty(string input)
		{
			const string expectedValue = "";

			string result = input.ToBase64();

			result.Should().Be(expectedValue);
		}
	}
}
