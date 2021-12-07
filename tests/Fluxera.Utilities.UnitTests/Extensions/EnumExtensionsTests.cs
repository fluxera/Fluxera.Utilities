namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class EnumExtensionsTests
	{
		private enum EmptyEnum { }

		private enum UnnumberedEnum
		{
			One,
			Two,
			Three,
		}

		private enum NumberedEnum
		{
			One = 500,
			Two = 0,
			Three = -300,
		}

		[Flags]
		private enum FlaggedEnum
		{
			One = 0,
			Two = 1,
			Three = 2,
			Four = 4,
			Five = 8,
		}

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

		[Test]
		public void ShouldGetEnumValues()
		{
			// Arrange
			NumberedEnum e = NumberedEnum.Two;

			// Act
			NumberedEnum[] enums = e.EnumValues();

			// Assert
			enums.Length.Should().Be(3);
		}

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
