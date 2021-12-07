namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System.IO;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class StreamExtensionsTests
	{
		[Test]
		public void ShouldRewindStream()
		{
			using (MemoryStream stream = "Hallo".ToMemoryStream())
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					// Arrange
					reader.ReadToEnd();

					// Act
					stream.Position.Should().NotBe(0);
					stream.Rewind();

					// Assert
					stream.Position.Should().Be(0);
				}
			}
		}

		// TODO: Continue at CopyToMemory
	}
}
