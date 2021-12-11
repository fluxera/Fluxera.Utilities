namespace Fluxera.Utilities.UnitTests.Extensions.Collection
{
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class AddForTests
	{
		[Test]
		public void ShouldAddFilteredToList()
		{
			// Arrange
			ICollection<string> list = new List<string>();

			// Act
			list.AddFor("Hallo", x => x.Length > 2);
			list.AddFor("Du", x => x.Length > 2);
			list.AddFor("Welt", x => x.Length > 2);

			// Assert
			list.Count.Should().Be(2);
		}
	}
}
