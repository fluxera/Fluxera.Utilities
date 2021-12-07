namespace Fluxera.Utilities.UnitTests.Extensions.Enum
{
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class HasFlagTests
	{
		[Test]
		public void ShouldCheckForFlag()
		{
			// Arrange
			FlaggedEnum e = FlaggedEnum.Two | FlaggedEnum.Five;

			// Act
			bool hasFlags = e.HasFlag(FlaggedEnum.Five);

			// Assert
			hasFlags.Should().BeTrue();
		}
	}
}
