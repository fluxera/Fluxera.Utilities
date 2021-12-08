// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class ListExtensions
	{
		/// <summary>
		///     Adds the given value to the target list if the value matches the given predicate.
		/// </summary>
		/// <typeparam name="T">The type of the elements.</typeparam>
		/// <param name="target">The target list to add the elements to.</param>
		/// <param name="value">The element to add.</param>
		/// <param name="predicate">The predicate to match by the elements to add.</param>
		public static void AddFor<T>(this IList<T> target, T value, Predicate<T> predicate)
		{
			Guard.Against.Null(target, nameof(target));

			if (predicate(value))
			{
				target.Add(value);
			}
		}
	}
}
