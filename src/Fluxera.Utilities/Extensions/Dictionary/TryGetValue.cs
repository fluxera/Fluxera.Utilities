// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;

	/// <summary>
	///     Extension methods for the <see cref="IDictionary{TKey,TValue}" /> type.
	/// </summary>
	public static partial class DictionaryExtensions
	{
		/// <summary>
		///     Try to get a value from a dictionary.
		/// </summary>
		/// <typeparam name="T">Type of the value.</typeparam>
		/// <param name="dictionary">The dictionary to check and get from.</param>
		/// <param name="key">The key of the value.</param>
		/// <param name="value">Value for key (or default value if key not exists).</param>
		/// <returns>True if key does exists in the dictionary.</returns>
		internal static bool TryGetValue<T>(this IDictionary<string, object> dictionary, string key, out T value)
		{
			if(dictionary.TryGetValue(key, out object valueObj) && valueObj is T obj)
			{
				value = obj;
				return true;
			}

			value = default;
			return false;
		}
	}
}
