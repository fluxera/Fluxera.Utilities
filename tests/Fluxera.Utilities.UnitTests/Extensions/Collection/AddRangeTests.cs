namespace Fluxera.Utilities.UnitTests.Extensions.Collection
{
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class AddRangeTests
	{
		[Test]
		public void ShouldAddRangeToList()
		{
			// Arrange
			ICollection<string> list = new List<string>();

			// Act
			list.AddRange(new List<string>
			{
				"Hallo", "Du", "Welt",
			});

			// Assert
			list.Count.Should().Be(3);
		}
	}
}