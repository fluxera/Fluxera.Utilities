// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	///     Extension methods for the <see cref="ICollection{T}" /> type.
	/// </summary>
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
			 Guard.ThrowIfNull(collection);
			 Guard.ThrowIfNull(predicate);

			IList<T> deleteList = collection.Where(predicate).ToList();
			deleteList.ForEach(x => collection.Remove(x));
		}
	}
}
