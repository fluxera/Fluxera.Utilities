// ReSharper disable ConditionIsAlwaysTrueOrFalse

// ReSharper disable ExpressionIsAlwaysNull

namespace Fluxera.Utilities.UnitTests.Extensions.Enumerable
{
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsAnyTests
	{
		[Test]
		public void ReturnsFalseGivenEmptyEnumerable()
		{
			IEnumerable<object> enumeration = null;

			bool result = enumeration.IsAny();

			result.Should().BeFalse();
		}

		[Test]
		public void ReturnsTrueGivenEnumerableThatHaveValues()
		{
			IEnumerable<int> enumeration = new List<int> { 1, 2, 3, 4 };

			bool result = enumeration.IsAny();

			result.Should().BeTrue();
		}
	}
}
