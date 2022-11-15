// ReSharper disable ConditionIsAlwaysTrueOrFalse

// ReSharper disable ExpressionIsAlwaysNull

namespace Fluxera.Utilities.UnitTests.Extensions.Enumerable
{
	using System.Collections.Generic;
	using System.Linq;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsNullOrEmptyTests
	{
		[Test]
		public void ShouldCheckNotNullOrEmptyForEmpty()
		{
			// Arrange
			IEnumerable<string> enumerable = new List<string>
			{
				"Test", "Auto", "Radio",
			};

			bool isNullOrEmpty = enumerable.IsNotNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeTrue();
		}


		[Test]
		public void ShouldCheckNotNullOrEmptyForNull()
		{
			// Arrange
			IEnumerable<string> enumerable = null;

			bool isNullOrEmpty = enumerable.IsNotNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckNullOrEmptyForEmpty()
		{
			// Arrange
			IEnumerable<string> enumerable = Enumerable.Empty<string>();

			bool isNullOrEmpty = enumerable.IsNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckNullOrEmptyForNull()
		{
			// Arrange
			IEnumerable<string> enumerable = null;

			bool isNullOrEmpty = enumerable.IsNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeTrue();
		}
	}
}
