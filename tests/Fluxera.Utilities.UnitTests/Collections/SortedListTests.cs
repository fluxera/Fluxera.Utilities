namespace Fluxera.Utilities.UnitTests.Collections
{
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Collections.Generic;
	using NUnit.Framework;

	[TestFixture]
	public class SortedListTests
	{
		[Test]
		public void ShouldAddSorted()
		{
			// Arrange
			IList<string> list = new SortedList<string>();

			// Act
			list.Add("c");
			list.Add("b");
			list.Add("j");
			list.Add("g");
			list.Add("a");

			// Assert
			list.IndexOf("a").Should().Be(0);
			list.IndexOf("b").Should().Be(1);
			list.IndexOf("c").Should().Be(2);
			list.IndexOf("g").Should().Be(3);
			list.IndexOf("j").Should().Be(4);
		}
	}
}
