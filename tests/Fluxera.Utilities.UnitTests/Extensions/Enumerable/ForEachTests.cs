// ReSharper disable ExpressionIsAlwaysNull

// ReSharper disable ReturnValueOfPureMethodIsNotUsed

namespace Fluxera.Utilities.UnitTests.Extensions.Enumerable
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class ForEachTests
	{
		[Test]
		public void ForEachExecutesActionOncePerItem()
		{
			IEnumerable<int> input = new List<int> { 1, 2, 3 };
			int sum = 0;
			Action<int> action = x => sum += x;

			input.ForEach(action);

			sum.Should().Be(6);
		}

		[Test]
		public void ForEachThrowsGivenNullAction()
		{
			IEnumerable<object> enumeration = new List<object>();

			Action<object> enumAction = null;

			Action action = () => enumeration.ForEach(enumAction);

			action.Should().Throw<ArgumentNullException>();
		}

		[Test]
		public void ForEachThrowsGivenNullInput()
		{
			IEnumerable<object> enumeration = null;

			Action action = () => enumeration.ForEach(x => x.ToString());

			action.Should().Throw<ArgumentNullException>();
		}

		[Test]
		public void ShouldIterateForEachElement()
		{
			// Arrange
			IEnumerable<string> enumerable = new List<string>
			{
				"Test", "Auto", "Radio",
			};

			// Act
			string result = string.Empty;
			enumerable.ForEach(x => result += x);

			// Assert
			result.Should().NotBeEmpty();
			result.Should().Be("TestAutoRadio");
		}
	}
}
