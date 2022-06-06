namespace Fluxera.Utilities.UnitTests.Extensions.Type
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsEnumerableTests
	{
		public static IEnumerable<object[]> TestCases()
		{
			yield return new object[] { typeof(IEnumerable), true };
			yield return new object[] { typeof(IEnumerable<>), true };

			yield return new object[] { typeof(IList), true };
			yield return new object[] { typeof(IList<>), true };
			yield return new object[] { typeof(IReadOnlyList<>), true };

			yield return new object[] { typeof(ICollection), true };
			yield return new object[] { typeof(ICollection<>), true };
			yield return new object[] { typeof(IReadOnlyCollection<>), true };

			yield return new object[] { typeof(IDictionary), true };
			yield return new object[] { typeof(IDictionary<,>), true };
			yield return new object[] { typeof(IReadOnlyDictionary<,>), true };

			yield return new object[] { typeof(ISet<>), true };
			yield return new object[] { typeof(IReadOnlySet<>), true };

			yield return new object[] { typeof(string), true };
		}

		[Test]
		[TestCaseSource(nameof(TestCases))]
		public void ShouldRecognizeAsEnumerable(Type type, bool expected)
		{
			type.IsEnumerable().Should().Be(expected);
		}
	}
}
