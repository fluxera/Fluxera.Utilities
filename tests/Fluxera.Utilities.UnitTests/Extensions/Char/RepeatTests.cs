// ReSharper disable ReturnValueOfPureMethodIsNotUsed

namespace Fluxera.Utilities.UnitTests.Extensions.Char
{
	using System;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class RepeatTests
	{
		[Test]
		public void ShouldNotAllowNegativeCount()
		{
			// Arrange
			const char c = 'w';

			// Act
			Action action = () => c.Repeat(-4);

			// Assert
			action.Should().Throw<ArgumentException>();
		}

		[Test]
		public void ShouldRepeatCharacterMultipleTimes()
		{
			// Arrange
			const char c = 'w';

			// Act
			string result = c.Repeat(3);

			// Assert
			result.Should().Be("www");
		}

		[Test]
		public void ShouldRepeatCharacterZeroTimes()
		{
			// Arrange
			const char c = 'w';

			// Act
			string result = c.Repeat(0);

			// Assert
			result.Should().Be(string.Empty);
		}
	}
}
