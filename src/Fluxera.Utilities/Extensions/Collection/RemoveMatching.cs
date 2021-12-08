// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Guards;

	public static partial class CollectionExtensions
	{
		/// <summary>
		///     Removes all items from the collection that match the given predicate.
		/// </summary>
		/// <typeparam name="T">The type of the elements.</typeparam>
		/// <param name="collection">The collection to remove from.</param>
		/// <param name="predicate">The predicate for matching items to remove.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public static void RemoveMatching<T>(this ICollection<T> collection, Func<T, bool> predicate)
		{
			Guard.Against.Null(collection, nameof(collection));
			Guard.Against.Null(predicate, nameof(predicate));

			IList<T> deleteList = collection.Where(predicate).ToList();
			deleteList.ForEach(x => collection.Remove(x));
		}
	}
}
