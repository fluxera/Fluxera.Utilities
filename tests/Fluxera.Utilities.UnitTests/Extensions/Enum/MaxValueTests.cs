namespace Fluxera.Utilities.UnitTests.Extensions.Enum
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class MaxValueTests
	{
		[Test]
		public void ShouldGetMaxValueNumbered()
		{
			// Arrange
			NumberedEnum e = NumberedEnum.Two;

			// Act
			long minValue = e.MaxValue();

			// Assert
			minValue.Should().Be(500);
		}

		[Test]
		public void ShouldGetMaxValueUnnumbered()
		{
			// Arrange
			UnnumberedEnum e = UnnumberedEnum.Two;

			// Act
			long minValue = e.MaxValue();

			// Assert
			minValue.Should().Be(2);
		}
	}
}
