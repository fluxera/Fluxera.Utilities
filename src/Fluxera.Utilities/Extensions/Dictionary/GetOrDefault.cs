// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Concurrent;
	using System.Collections.Generic;

	public static partial class DictionaryExtensions
	{
		/// <summary>
		///     Gets a value from the dictionary with given key. Returns default value if can not find.
		/// </summary>
		/// <param name="dictionary">Dictionary to check and get</param>
		/// <param name="key">Key to find the value</param>
		/// <typeparam name="TKey">Type of the key</typeparam>
		/// <typeparam name="TValue">Type of the value</typeparam>
		/// <returns>Value if found, default if can not found.</returns>
		public static TValue? GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
		{
			return dictionary.TryGetValue(key, out TValue obj) ? obj : default;
		}

		/// <summary>
		///     Gets a value from the dictionary with given key. Returns default value if can not find.
		/// </summary>
		/// <param name="dictionary">Dictionary to check and get</param>
		/// <param name="key">Key to find the value</param>
		/// <typeparam name="TKey">Type of the key</typeparam>
		/// <typeparam name="TValue">Type of the value</typeparam>
		/// <returns>Value if found, default if can not found.</returns>
		public static TValue? GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
		{
			return dictionary.TryGetValue(key, out TValue obj) ? obj : default;
		}

		/// <summary>
		///     Gets a value from the dictionary with given key. Returns default value if can not find.
		/// </summary>
		/// <param name="dictionary">Dictionary to check and get</param>
		/// <param name="key">Key to find the value</param>
		/// <typeparam name="TKey">Type of the key</typeparam>
		/// <typeparam name="TValue">Type of the value</typeparam>
		/// <returns>Value if found, default if can not found.</returns>
		public static TValue? GetOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
		{
			return dictionary.TryGetValue(key, out TValue obj) ? obj : default;
		}

		/// <summary>
		///     Gets a value from the dictionary with given key. Returns default value if can not find.
		/// </summary>
		/// <param name="dictionary">Dictionary to check and get</param>
		/// <param name="key">Key to find the value</param>
		/// <typeparam name="TKey">Type of the key</typeparam>
		/// <typeparam name="TValue">Type of the value</typeparam>
		/// <returns>Value if found, default if can not found.</returns>
		public static TValue? GetOrDefault<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key)
		{
			return dictionary.TryGetValue(key, out TValue obj) ? obj : default;
		}
	}
}
