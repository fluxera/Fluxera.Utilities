namespace Fluxera.Utilities.UnitTests.Extensions.Enumerable
{
	using System.Collections.Generic;
	using System.Linq;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AsReadOnlyTests
	{
		[Test]
		public void ShouldCreateReadOnly()
		{
			// Arrange
			IEnumerable<string> enumerable = Enumerable.Empty<string>();

			// Act
			IReadOnlyCollection<string> readOnlyList = enumerable.AsReadOnly();

			// Assert
			readOnlyList.Should().NotBeNull();
		}
	}
}
