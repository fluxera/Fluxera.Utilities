namespace Fluxera.Utilities.UnitTests.Extensions.Enum
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class EnumValuesTests
	{
		[Test]
		public void ShouldGetEnumValues()
		{
			// Arrange
			NumberedEnum e = NumberedEnum.Two;

			// Act
			long[] enums = e.EnumValues();

			// Assert
			enums.Length.Should().Be(3);
		}
	}
}
