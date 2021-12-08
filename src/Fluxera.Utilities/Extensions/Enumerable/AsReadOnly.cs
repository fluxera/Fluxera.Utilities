// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Linq;
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class EnumerableExtensions
	{
		/// <summary>
		///     Converts the enumerable to a read-only collection.
		/// </summary>
		/// <typeparam name="T">The type of the elements.</typeparam>
		/// <param name="enumerable">The collection to write-protect.</param>
		/// <returns>A write-protected collection.</returns>
		public static IReadOnlyCollection<T> AsReadOnly<T>(this IEnumerable<T> enumerable)
		{
			Guard.Against.Null(enumerable, nameof(enumerable));

			return new ReadOnlyCollection<T>(enumerable.ToList());
		}
	}
}
