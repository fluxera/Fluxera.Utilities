namespace Fluxera.Utilities.UnitTests.Extensions.Type
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.Immutable;
	using System.Collections.ObjectModel;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsCollectionTests
	{
		public static IEnumerable<object[]> TestCases()
		{
			yield return new object[] { typeof(ICollection), true };
			yield return new object[] { typeof(IList), true };
			yield return new object[] { typeof(IDictionary), true };
			yield return new object[] { typeof(Array), true };
			yield return new object[] { typeof(ArrayList), true };
			yield return new object[] { typeof(Hashtable), true };

			yield return new object[] { typeof(IEnumerable), false };
			yield return new object[] { typeof(IEnumerable<>), false };

			yield return new object[] { typeof(IList<>), true };
			yield return new object[] { typeof(IList<string>), true };
			yield return new object[] { typeof(IReadOnlyList<>), true };
			yield return new object[] { typeof(List<>), true };
			yield return new object[] { typeof(List<string>), true };
			yield return new object[] { typeof(IImmutableList<>), true };
			yield return new object[] { typeof(IImmutableList<string>), true };
			yield return new object[] { typeof(ImmutableList<>), true };
			yield return new object[] { typeof(ImmutableList<string>), true };
			yield return new object[] { typeof(ImmutableArray<>), true };
			yield return new object[] { typeof(ImmutableArray<string>), true };

			yield return new object[] { typeof(ICollection<>), true };
			yield return new object[] { typeof(ICollection<string>), true };
			yield return new object[] { typeof(IReadOnlyCollection<>), true };
			yield return new object[] { typeof(IReadOnlyCollection<string>), true };
			yield return new object[] { typeof(Collection<>), true };
			yield return new object[] { typeof(Collection<string>), true };
			yield return new object[] { typeof(ReadOnlyCollection<>), true };
			yield return new object[] { typeof(ReadOnlyCollection<string>), true };

			yield return new object[] { typeof(IDictionary<,>), true };
			yield return new object[] { typeof(IDictionary<string, string>), true };
			yield return new object[] { typeof(IReadOnlyDictionary<,>), true };
			yield return new object[] { typeof(IReadOnlyDictionary<string, string>), true };
			yield return new object[] { typeof(Dictionary<,>), true };
			yield return new object[] { typeof(Dictionary<string, string>), true };
			yield return new object[] { typeof(ReadOnlyDictionary<,>), true };
			yield return new object[] { typeof(ReadOnlyDictionary<string, string>), true };
			yield return new object[] { typeof(IImmutableDictionary<,>), true };
			yield return new object[] { typeof(IImmutableDictionary<string, string>), true };
			yield return new object[] { typeof(ImmutableDictionary<,>), true };
			yield return new object[] { typeof(ImmutableDictionary<string, string>), true };

			yield return new object[] { typeof(ISet<>), true };
			yield return new object[] { typeof(ISet<string>), true };
			yield return new object[] { typeof(IReadOnlySet<>), true };
			yield return new object[] { typeof(IReadOnlySet<string>), true };
			yield return new object[] { typeof(HashSet<>), true };
			yield return new object[] { typeof(HashSet<string>), true };
			yield return new object[] { typeof(SortedSet<>), true };
			yield return new object[] { typeof(SortedSet<string>), true };
			yield return new object[] { typeof(ImmutableHashSet<>), true };
			yield return new object[] { typeof(ImmutableHashSet<string>), true };
			yield return new object[] { typeof(ImmutableHashSet<>), true };
			yield return new object[] { typeof(ImmutableHashSet<string>), true };

			yield return new object[] { typeof(IImmutableQueue<>), false };
			yield return new object[] { typeof(IImmutableQueue<string>), false };
			yield return new object[] { typeof(ImmutableQueue<>), false };
			yield return new object[] { typeof(ImmutableQueue<string>), false };

			yield return new object[] { typeof(string), false };
		}

		[Test]
		[TestCaseSource(nameof(TestCases))]
		public void ShouldRecognizeAsCollection(Type type, bool expected)
		{
			type.IsCollection().Should().Be(expected);
		}
	}
}
