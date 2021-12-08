namespace Fluxera.Utilities.UnitTests.Extensions.Enum
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class EnumOptionsTests
	{
		[Test]
		public void ShouldGetEnumOptions()
		{
			// Arrange
			NumberedEnum e = NumberedEnum.Two;

			// Act
			NumberedEnum[] enums = e.EnumOptions();

			// Assert
			enums.Length.Should().Be(3);
		}
	}
}
