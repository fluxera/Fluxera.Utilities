namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsNumericTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
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
	}
}
