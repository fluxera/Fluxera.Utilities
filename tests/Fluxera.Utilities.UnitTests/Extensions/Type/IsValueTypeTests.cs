namespace Fluxera.Utilities.UnitTests.Extensions.Type
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsValueTypeTests
	{
		public static IEnumerable<object[]> TestCases()
		{
			yield return new object[] { typeof(DateTime), true };
			yield return new object[] { typeof(DateTime?), true };
		}

		[Test]
		[TestCaseSource(nameof(TestCases))]
		public void ShouldRecognizeAsPrimitive(Type type, bool expected)
		{
			type.IsValueType().Should().Be(expected);
		}
	}
}
