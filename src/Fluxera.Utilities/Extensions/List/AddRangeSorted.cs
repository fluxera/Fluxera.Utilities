// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;

	/// <summary>
	///     Extension methods for the <see cref="List{T}" /> type.
	/// </summary>
	public static partial class ListExtensions
	{
		/// <summary>
		///     Adds the given items into a list sorted.
		/// </summary>
		/// <typeparam name="T">The type of the element.</typeparam>
		/// <param name="target">The list to add the item to.</param>
		/// <param name="items">The items to add.</param>
		/// <param name="comparer">The optional item comparer.</param>
		public static void AddRangeSorted<T>(this List<T> target, IEnumerable<T> items, IComparer<T> comparer = null)
		{
			Guard.ThrowIfNull(target);

			items ??= [];

			foreach(T item in items)
			{
				target.AddSorted(item, comparer);
			}
		}
	}
}
