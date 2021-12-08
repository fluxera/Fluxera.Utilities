namespace Fluxera.Utilities.UnitTests.Extensions.MemoryStream
{
	using System.IO;
	using System.Threading.Tasks;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ToContentStringTests
	{
		[Test]
		public async Task ShouldLoadString()
		{
			// Arrange
			string str = "Måtthias";

			// Act
			string result;
			using (MemoryStream stream = str.ToMemoryStream())
			{
				result = await stream.ToContentString();
			}

			// Assert
			result.Should().Be(str);
		}
	}
}
