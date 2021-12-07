namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using System.Text;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetBytesTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldGetBytesDefaultEncoding()
		{
			// Arrange
			string str = "Test";

			// Act
			byte[] result = str.GetBytes();

			// Assert
			result.Should().NotBeNull();
			result.Length.Should().Be(4);
		}

		[Test]
		public void ShouldGetBytesUtf32Encoding()
		{
			// Arrange
			string str = "Test";

			// Act
			byte[] result = str.GetBytes(Encoding.UTF32);

			// Assert
			result.Should().NotBeNull();
			result.Length.Should().Be(16);
		}
	}
}
