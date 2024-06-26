﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	///     Extension methods for the <see cref="IEnumerable{T}" /> type.
	/// </summary>
	public static partial class EnumerableExtensions
	{
		/// <summary>
		///     Executes the given <see cref="Action" /> for every item in the enumerable.
		/// </summary>
		/// <typeparam name="T">The type of the element.</typeparam>
		/// <param name="enumerable">The enumerable containing the elements</param>
		/// <param name="action">The action execute.</param>
		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
		{
			enumerable = Guard.ThrowIfNull(enumerable);
			action = Guard.ThrowIfNull(action);

			foreach(T item in enumerable)
			{
				action(item);
			}
		}
	}
}
