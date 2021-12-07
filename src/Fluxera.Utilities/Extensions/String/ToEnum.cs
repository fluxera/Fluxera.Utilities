// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Converts the string to a matching enum value fro the given enum.
		///     The case of the string is ignored.
		/// </summary>
		/// <typeparam name="TEnum">The type of the target enum.</typeparam>
		/// <param name="value">The string to convert.</param>
		/// <returns>The corresponding enum value.</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static TEnum ToEnum<TEnum>(this string value) where TEnum : struct, Enum
		{
			return value.ToEnum<TEnum>(true);
		}

		/// <summary>
		///     Converts the string to a matching enum value fro the given enum.
		/// </summary>
		/// <typeparam name="TEnum">The type of the target enum.</typeparam>
		/// <param name="value">The string to convert.</param>
		/// <param name="ignoreCase">Flag, if the casing of the string should be ignored.</param>
		/// <returns>The corresponding enum value.</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static TEnum ToEnum<TEnum>(this string value, bool ignoreCase) where TEnum : struct, Enum
		{
			Guard.Against.Null(value, nameof(value));

			return (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
		}

		/// <summary>
		///     Converts the string to a matching enum value fro the given enum.
		///     The case of the string is ignored. Returns null in case of parse error.
		/// </summary>
		/// <typeparam name="TEnum">The type of the target enum.</typeparam>
		/// <param name="str">The string to convert.</param>
		/// <returns>The corresponding enum value.</returns>
		public static TEnum? ToNullableEnum<TEnum>(this string str) where TEnum : struct, Enum
		{
			return str.ToNullableEnum<TEnum>(true);
		}

		/// <summary>
		///     Converts the string to a matching enum value fro the given enum.
		///     Returns null in case of parse error.
		/// </summary>
		/// <typeparam name="TEnum">The type of the target enum.</typeparam>
		/// <param name="str">The string to convert.</param>
		/// <param name="ignoreCase">Flag, if the casing of the string should be ignored.</param>
		/// <returns>The corresponding enum value.</returns>
		public static TEnum? ToNullableEnum<TEnum>(this string str, bool ignoreCase) where TEnum : struct, Enum
		{
			if(!Enum.TryParse(str, ignoreCase, out TEnum result))
			{
				return null;
			}

			return result;
		}
	}
}
