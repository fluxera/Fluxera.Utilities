// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="ICollection{T}" /> type.
	/// </summary>
	[PublicAPI]
	public static partial class CollectionExtensions
	{
		/// <summary>
		///     Adds an item to the collection if it's not already in the collection.
		/// </summary>
		/// <param name="collection">The collection</param>
		/// <param name="item">Item to check and add</param>
		/// <typeparam name="T">Type of the items in the collection</typeparam>
		/// <returns>Returns True if added, returns False if not.</returns>
		public static bool AddIfNotContains<T>(this ICollection<T> collection, T item)
		{
			Guard.Against.Null(collection, nameof(collection));

			if(collection.Contains(item))
			{
				return false;
			}

			collection.Add(item);
			return true;
		}

		/// <summary>
		///     Adds items to the collection which are not already in the collection.
		/// </summary>
		/// <param name="collection">The collection</param>
		/// <param name="items">Item to check and add</param>
		/// <typeparam name="T">Type of the items in the collection</typeparam>
		/// <returns>Returns the added items.</returns>
		public static IEnumerable<T> AddIfNotContains<T>(this ICollection<T> collection, IEnumerable<T> items)
		{
			Guard.Against.Null(collection, nameof(collection));

			IList<T> addedItems = new List<T>();

			foreach(T item in items)
			{
				if(collection.Contains(item))
				{
					continue;
				}

				collection.Add(item);
				addedItems.Add(item);
			}

			return addedItems;
		}

		/// <summary>
		///     Adds an item to the collection if it's not already in the collection based on the given
		///     <paramref name="predicate" />.
		/// </summary>
		/// <param name="collection">The collection</param>
		/// <param name="predicate">The condition to decide if the item is already in the collection</param>
		/// <param name="itemFactory">A factory that returns the item</param>
		/// <typeparam name="T">Type of the items in the collection</typeparam>
		/// <returns>Returns True if added, returns False if not.</returns>
		public static bool AddIfNotContains<T>(this ICollection<T> collection,
			Func<T, bool> predicate, Func<T> itemFactory)
		{
			Guard.Against.Null(collection, nameof(collection));
			Guard.Against.Null(predicate, nameof(predicate));
			Guard.Against.Null(itemFactory, nameof(itemFactory));

			if(collection.Any(predicate))
			{
				return false;
			}

			collection.Add(itemFactory());
			return true;
		}

		/// <summary>
		///     Adds an item to the collection if it's not already in the collection based on the given
		///     <paramref name="predicate" />.
		/// </summary>
		/// <param name="collection">The collection</param>
		/// <param name="predicate">The condition to decide if the item is already in the collection</param>
		/// <param name="itemFactory">A factory that returns the item</param>
		/// <typeparam name="T">Type of the items in the collection</typeparam>
		/// <returns>Returns True if added, returns False if not.</returns>
		public static bool AddIfNotContains<T>(this ICollection<T> collection, Predicate<T> predicate, Func<T> itemFactory)
		{
			Guard.Against.Null(collection, nameof(collection));
			Guard.Against.Null(predicate, nameof(predicate));
			Guard.Against.Null(itemFactory, nameof(itemFactory));

			if(collection.Any(x => predicate(x)))
			{
				return false;
			}

			collection.Add(itemFactory());
			return true;
		}
	}
}
