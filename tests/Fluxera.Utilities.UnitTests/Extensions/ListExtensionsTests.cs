namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class ListExtensionsTests
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

		[Test]
		public void ShouldAddSorted()
		{
			// Arrange
			List<string> list = new List<string>();

			// Act
			list.AddSorted("c");
			list.AddSorted("b");
			list.AddSorted("j");
			list.AddSorted("g");
			list.AddSorted("a");

			// Assert
			list.IndexOf("a").Should().Be(0);
			list.IndexOf("b").Should().Be(1);
			list.IndexOf("c").Should().Be(2);
			list.IndexOf("g").Should().Be(3);
			list.IndexOf("j").Should().Be(4);
		}
	}
}
