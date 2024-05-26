// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="List{T}" /> type.
	/// </summary>
	[PublicAPI]
	public static partial class ListExtensions
	{
		/// <summary>
		///     Adds the given item into a list sorted.
		/// </summary>
		/// <typeparam name="T">The type of the element.</typeparam>
		/// <param name="target">The list to add the item to.</param>
		/// <param name="item">The item to add.</param>
		/// <param name="comparer">The optional item comparer.</param>
		public static void AddSorted<T>(this List<T> target, T item, IComparer<T> comparer = null)
		{
			Guard.ThrowIfNull(target, nameof(target));
			Guard.ThrowIfNull(item, nameof(item));

			comparer ??= Comparer<T>.Default;

			int position = target.BinarySearch(item, comparer);
			if(position < 0)
			{
				position = ~position;
			}

			target.Insert(position, item);
		}
	}
}
