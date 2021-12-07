namespace Fluxera.Utilities.UnitTests.Extensions.List
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AddSortedTests
	{
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