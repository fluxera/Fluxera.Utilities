// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	///     Extension methods for the <see cref="ICollection{T}" /> type.
	/// </summary>
	public static partial class CollectionExtensions
	{
		/// <summary>
		///     Adds the given values to the target list if the element to add matches the given predicate.
		/// </summary>
		/// <typeparam name="T">The type of the elements.</typeparam>
		/// <param name="target">The target list to add the elements to.</param>
		/// <param name="values">The elements to add.</param>
		/// <param name="predicate">The predicate to match.</param>
		public static void AddRangeFor<T>(this ICollection<T> target, IEnumerable<T> values, Predicate<T> predicate)
		{
			target = Guard.ThrowIfNull(target);
			values = Guard.ThrowIfNull(values);

			foreach(T value in values)
			{
				target.AddFor(value, predicate);
			}
		}
	}
}
