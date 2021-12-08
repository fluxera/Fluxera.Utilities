// ReSharper disable once CheckNamespace
namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="IConverter{Char}" /> type.
	/// </summary>
	[PublicAPI]
	public static class CharConverterExtensions
	{
		/// <summary>
		///     Returns an <see cref="IConverter{Char}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static IConverter<char> Convert(this char value)
		{
			return new Converter<char>(value);
		}

		/// <summary>
		///     Returns an <see cref="IConverter{Char}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <param name="formatProvider">The format provider used in the conversions, f.e. CultureInfo.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static IConverter<char> Convert(this char value, IFormatProvider formatProvider)
		{
			return new Converter<char>(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a bool.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static bool ToBool(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToBool();
		}

		/// <summary>
		///     Converts the internal string of the converter to a bool.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static bool? ToNullableBool(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableBool();
		}

		/// <summary>
		///     Converts the internal string of the converter to a byte.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static byte ToByte(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToByte();
		}

		/// <summary>
		///     Converts the internal string of the converter to a byte.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static byte? ToNullableByte(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableByte();
		}

		/// <summary>
		///     Converts the internal string of the converter to a short.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static short ToShort(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToShort();
		}

		/// <summary>
		///     Converts the internal string of the converter to a short.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static short? ToNullableShort(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableShort();
		}

		/// <summary>
		///     Converts the internal string of the converter to an int.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static int ToInt(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToInt();
		}

		/// <summary>
		///     Converts the internal string of the converter to an int.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static int? ToNullableInt(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableInt();
		}

		/// <summary>
		///     Converts the internal string of the converter to a long.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static long ToLong(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToLong();
		}

		/// <summary>
		///     Converts the internal string of the converter to a long.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static long? ToNullableLong(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableLong();
		}

		/// <summary>
		///     Converts the internal string of the converter to a float.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static float ToFloat(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToFloat();
		}

		/// <summary>
		///     Converts the internal string of the converter to a float.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static float? ToNullableFloat(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableFloat();
		}

		/// <summary>
		///     Converts the internal string of the converter to a double.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static double ToDouble(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToDouble();
		}

		/// <summary>
		///     Converts the internal string of the converter to a double.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static double? ToNullableDouble(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableDouble();
		}

		/// <summary>
		///     Converts the internal string of the converter to a decimal.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static decimal ToDecimal(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToDecimal();
		}

		/// <summary>
		///     Converts the internal string of the converter to a decimal.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static decimal? ToNullableDecimal(this IConverter<char> converter)
		{
			return converter.ToStringConverter().ToNullableDecimal();
		}

		private static IConverter<string> ToStringConverter(this IConverter<char> converter)
		{
			return new Converter<string>(converter.Value.ToString(), converter.FormatProvider);
		}
	}
}
