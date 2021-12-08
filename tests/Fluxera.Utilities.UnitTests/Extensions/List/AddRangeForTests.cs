namespace Fluxera.Utilities.UnitTests.Extensions.List
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AddRangeForTests
	{
		[Test]
		public void ShouldAddRangeFilteredToList()
		{
			// Arrange
			IList<string> list = new List<string>();

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