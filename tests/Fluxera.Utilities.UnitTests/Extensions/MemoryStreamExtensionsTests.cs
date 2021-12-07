// ReSharper disable StringLiteralTypo

namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System.IO;
	using System.Threading.Tasks;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class MemoryStreamExtensionsTests
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
