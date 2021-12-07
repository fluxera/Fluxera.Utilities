// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Guards;

	public static partial class ListExtensions
	{
		/// <summary>
		///     Adds the given item sorted into a list.
		/// </summary>
		/// <typeparam name="T">The type of the element.</typeparam>
		/// <param name="target">The list to add the item to.</param>
		/// <param name="item">The item to add.</param>
		/// <param name="comparer">The optional item comparer.</param>
		public static void AddSorted<T>(this List<T> target, T item, IComparer<T> comparer = null)
		{
			Guard.Against.Null(target, nameof(target));
			Guard.Against.Null(item, nameof(item));

			comparer ??= Comparer<T>.Default;

			int position = target.BinarySearch(item, comparer);
			if (position < 0)
			{
				position = ~position;
			}

			target.Insert(position, item);
		}

		/// <summary>
		///     Adds the given items sorted into a list.
		/// </summary>
		/// <typeparam name="T">The type of the element.</typeparam>
		/// <param name="target">The list to add the item to.</param>
		/// <param name="items">The items to add.</param>
		/// <param name="comparer">The optional item comparer.</param>
		public static void AddRangeSorted<T>(this List<T> target, IEnumerable<T> items, IComparer<T> comparer = null)
		{
			if (target is null)
			{
				throw new ArgumentNullException(nameof(target));
			}

			items ??= Enumerable.Empty<T>();

			foreach (T item in items)
			{
				target.AddSorted(item, comparer);
			}
		}
	}
}
