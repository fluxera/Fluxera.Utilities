namespace Fluxera.Utilities.UnitTests.Extensions.Enum
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsEmptyTests
	{
		[Test]
		public void ShouldCheckForEmpty()
		{
			// Arrange
			EmptyEnum e = 0;

			// Act
			bool isEmpty = e.IsEmpty();

			// Assert
			isEmpty.Should().BeTrue();
		}
	}
}
