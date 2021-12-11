namespace Fluxera.Utilities.UnitTests.Extensions.Collection
{
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class AddRangeForTests
	{
		[Test]
		public void ShouldAddRangeFilteredToList()
		{
			// Arrange
			ICollection<string> list = new List<string>();

			// Act
			list.AddRangeFor(new List<string>
			{
				"Hallo", "Du", "Welt",
			}, x => x.Length > 2);

			// Assert
			list.Count.Should().Be(2);
		}
	}
}