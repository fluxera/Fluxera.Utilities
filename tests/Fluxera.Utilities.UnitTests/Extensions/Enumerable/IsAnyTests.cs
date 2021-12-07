namespace Fluxera.Utilities.UnitTests.Extensions.Enumerable
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsAnyTests
	{
		[Test]
		public void ReturnsTrueGivenEnumerableThatHaveValues()
		{
			IEnumerable<int> enumeration = new List<int> { 1, 2, 3, 4 };

			bool result = enumeration.IsAny();

			result.Should().BeTrue();
		}

		[Test]
		public void ReturnsFalseGivenEmptyEnumerable()
		{
			IEnumerable<object> enumeration = null;

			bool result = enumeration.IsAny();

			result.Should().BeFalse();
		}
	}
}
