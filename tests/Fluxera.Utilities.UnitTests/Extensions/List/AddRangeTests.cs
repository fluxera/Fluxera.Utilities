namespace Fluxera.Utilities.UnitTests.Extensions.List
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AddRangeTests
	{
		[Test]
		public void ShouldAddRangeToList()
		{
			// Arrange
			IList<string> list = new List<string>();

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