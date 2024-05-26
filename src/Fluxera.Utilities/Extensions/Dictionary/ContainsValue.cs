// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="IDictionary{TKey,TValue}" /> type.
	/// </summary>
	[PublicAPI]
	public static partial class DictionaryExtensions
	{
		/// <summary>
		///     Returns true if the value is contained in the dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the keys.</typeparam>
		/// <typeparam name="TValue">The type of the values.</typeparam>
		/// <param name="dictionary">The dictionary to search in.</param>
		/// <param name="value">The value to search for.</param>
		/// <returns>True, if the dictionary contains the value.</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static bool ContainsValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value)
		{
			Guard.ThrowIfNull(dictionary);

			return dictionary.Values.Any(x => x.Equals(value));
		}
	}
}
