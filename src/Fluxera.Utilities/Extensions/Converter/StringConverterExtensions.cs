// ReSharper disable once CheckNamespace
namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="IConverter{String}" /> type.
	/// </summary>
	[PublicAPI]
	public static class StringConverterExtensions
	{
		/// <summary>
		///     Returns an <see cref="IConverter{String}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static IConverter<string> Convert(this string value)
		{
			return new Converter<string>(value);
		}

		/// <summary>
		///     Returns an <see cref="IConverter{String}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <param name="formatProvider">The format provider used in the conversions, f.e. CultureInfo.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static IConverter<string> Convert(this string value, IFormatProvider formatProvider)
		{
			return new Converter<string>(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a bool.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static bool ToBool(this IConverter<string> converter)
		{
			string value = converter.Value;
			return bool.Parse(value.ConvertBoolString());
		}

		/// <summary>
		///     Converts the internal string of the converter to a bool.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static bool? ToNullableBool(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToBool(out bool result);
			return success ? result : default(bool?);
		}

		/// <summary>
		///     Converts the internal string of the converter to a byte.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static byte ToByte(this IConverter<string> converter)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return byte.Parse(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a byte.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static byte? ToNullableByte(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToByte(out byte result);
			return success ? result : default(byte?);
		}

		/// <summary>
		///     Converts the internal string of the converter to a short.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static short ToShort(this IConverter<string> converter)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return short.Parse(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a short.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static short? ToNullableShort(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToShort(out short result);
			return success ? result : default(short?);
		}

		/// <summary>
		///     Converts the internal string of the converter to an int.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static int ToInt(this IConverter<string> converter)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return int.Parse(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to an int.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static int? ToNullableInt(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToInt(out int result);
			return success ? result : default(int?);
		}

		/// <summary>
		///     Converts the internal string of the converter to a long.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static long ToLong(this IConverter<string> converter)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return long.Parse(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a long.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static long? ToNullableLong(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToLong(out long result);
			return success ? result : default(long?);
		}

		/// <summary>
		///     Converts the internal string of the converter to a float.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static float ToFloat(this IConverter<string> converter)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return float.Parse(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a float.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static float? ToNullableFloat(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToFloat(out float result);
			return success ? result : default(float?);
		}

		/// <summary>
		///     Converts the internal string of the converter to a double.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static double ToDouble(this IConverter<string> converter)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return double.Parse(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a double.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static double? ToNullableDouble(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToDouble(out double result);
			return success ? result : default(double?);
		}

		/// <summary>
		///     Converts the internal string of the converter to a decimal.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static decimal ToDecimal(this IConverter<string> converter)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return decimal.Parse(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter to a decimal.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static decimal? ToNullableDecimal(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToDecimal(out decimal result);
			return success ? result : default(decimal?);
		}

		/// <summary>
		///     Converts the internal string of the converter to a Guid.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static Guid ToGuid(this IConverter<string> converter)
		{
			string value = converter.Value;
			return Guid.Parse(value);
		}

		/// <summary>
		///     Converts the internal string of the converter to a Guid.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <returns>The converted value.</returns>
		public static Guid? ToNullableGuid(this IConverter<string> converter)
		{
			bool success = converter.TryConvert().ToGuid(out Guid result);
			return success ? result : default(Guid?);
		}

		private static ITryConverter<string> TryConvert(this IConverter<string> converter)
		{
			return new TryConverter<string>(converter.Value, converter.FormatProvider);
		}

		internal static string ConvertBoolString(this string value)
		{
			switch (value)
			{
				// Note: Handle special custom cases.
				case "1":
				case "t":
				case "T":
				case "y":
				case "Y":
				case "yes":
				case "Yes":
					return "true";
				case "0":
				case "f":
				case "F":
				case "n":
				case "N":
				case "no":
				case "No":
					return "false";
			}

			return value;
		}
	}
}
