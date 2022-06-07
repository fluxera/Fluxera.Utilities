// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Fluxera.Guards;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Concatenates the string value with the given additional strings.
		/// </summary>
		/// <param name="str">The string value to concatenate to.</param>
		/// <param name="values">The additional string values to be concatenated.</param>
		/// <returns>The concatenated string.</returns>
		public static string ConcatWith(this string str, params string[] values)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));
			Guard.Against.NullOrEmpty(values, nameof(values));

			return string.Concat(str, string.Concat(values));
		}

		/// <summary>
		///     Concatenates the string value with the given additional strings and delimiter character.
		/// </summary>
		/// <param name="str">The string value to concatenate to.</param>
		/// <param name="delimiter">The delimiter character between each element.</param>
		/// <param name="values">The additional string values to be concatenated.</param>
		/// <returns>The concatenated string</returns>
		public static string ConcatWith(this string str, char delimiter, params string[] values)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));
			Guard.Against.NullOrEmpty(values, nameof(values));

			string[] valuesToConcat = new string[values.Length];
			for(int i = 0; i < values.Length; i++)
			{
				valuesToConcat[i] = string.Concat(delimiter, values[i]);
			}

			return string.Concat(str, string.Concat(valuesToConcat));
		}
	}
}
