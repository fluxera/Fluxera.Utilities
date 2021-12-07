// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;

	public static partial class DictionaryExtensions
	{
		/// <summary>
		///     Gets a value from the dictionary with given key. Returns default value if can not find.
		/// </summary>
		/// <param name="dictionary">Dictionary to check and get</param>
		/// <param name="key">Key to find the value</param>
		/// <param name="factory">A factory method used to create the value if not found in the dictionary</param>
		/// <typeparam name="TKey">Type of the key</typeparam>
		/// <typeparam name="TValue">Type of the value</typeparam>
		/// <returns>Value if found, default if can not found.</returns>
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
			Func<TKey, TValue> factory)
		{
			if (dictionary.TryGetValue(key, out TValue obj))
			{
				return obj;
			}

			return dictionary[key] = factory(key);
		}

		/// <summary>
		///     Gets a value from the dictionary with given key. Returns default value if can not find.
		/// </summary>
		/// <param name="dictionary">Dictionary to check and get</param>
		/// <param name="key">Key to find the value</param>
		/// <param name="factory">A factory method used to create the value if not found in the dictionary</param>
		/// <typeparam name="TKey">Type of the key</typeparam>
		/// <typeparam name="TValue">Type of the value</typeparam>
		/// <returns>Value if found, default if can not found.</returns>
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
			Func<TValue> factory)
		{
			return dictionary.GetOrAdd(key, k => factory());
		}
	}
}
