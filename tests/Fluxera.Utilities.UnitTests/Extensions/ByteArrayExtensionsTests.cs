namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System.IO;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ByteArrayExtensionsTests
	{
		[Test]
		public void ShouldStreamBeCorrectSizeAndData()
		{
			// Arrange
			byte[] array = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

			// Act
			MemoryStream memoryStream = array.ToMemoryStream();

			// Assert
			memoryStream.Length.Should().Be(10);
			byte[] bytes = memoryStream.ToArray();
			for (int index = 0; index < bytes.Length; index++)
			{
				bytes[index].Should().Be(array[index]);
			}
		}
	}
}
