namespace Fluxera.Utilities.UnitTests.Extensions.Enum
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class MinValueTests
	{
		[Test]
		public void ShouldGetMinValueNumbered()
		{
			// Arrange
			NumberedEnum e = NumberedEnum.Two;

			// Act
			long minValue = e.MinValue();

			// Assert
			minValue.Should().Be(-300);
		}

		[Test]
		public void ShouldGetMinValueUnnumbered()
		{
			// Arrange
			UnnumberedEnum e = UnnumberedEnum.Two;

			// Act
			long minValue = e.MinValue();

			// Assert
			minValue.Should().Be(0);
		}
	}
}
