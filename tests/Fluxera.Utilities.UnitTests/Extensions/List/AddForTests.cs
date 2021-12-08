namespace Fluxera.Utilities.UnitTests.Extensions.List
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AddForTests
	{
		[Test]
		public void ShouldAddFilteredToList()
		{
			// Arrange
			IList<string> list = new List<string>();

			// Act
			list.AddFor("Hallo", x => x.Length > 2);
			list.AddFor("Du", x => x.Length > 2);
			list.AddFor("Welt", x => x.Length > 2);

			// Assert
			list.Count.Should().Be(2);
		}
	}
}
