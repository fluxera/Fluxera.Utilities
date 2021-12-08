namespace Fluxera.Utilities.UnitTests.Extensions.Collection
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class RemoveMatchingTests
	{
		[Test]
		public void ShouldRemoveAllMatchingItems()
		{
			// Arrange
			ICollection<string> collection = new Collection<string>
			{
				"Hallo", "du", "da", "im", "Radio", "!",
			};

			// Act
			collection.RemoveMatching(x => x.StartsWith("d"));

			// Assert
			collection.Count.Should().Be(4);
		}
	}
}
