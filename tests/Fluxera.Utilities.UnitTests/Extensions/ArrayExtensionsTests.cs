namespace Fluxera.Utilities.UnitTests.Extensions
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ArrayExtensionsTests
	{
		[Test]
		public void ShouldBeWithin()
		{
			// Arrange
			int[] array = new int[9];

			// Act & Assert
			array.IsIndexWithin(0).Should().BeTrue();
			array.IsIndexWithin(4).Should().BeTrue();
			array.IsIndexWithin(8).Should().BeTrue();
			array.IsIndexWithin(9).Should().BeFalse();
		}
	}
}
