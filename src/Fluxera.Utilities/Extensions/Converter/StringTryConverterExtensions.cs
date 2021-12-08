// ReSharper disable once CheckNamespace
namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Globalization;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="ITryConverter{String}" /> type.
	/// </summary>
	[PublicAPI]
	public static class StringTryConverterExtensions
	{
		/// <summary>
		///     Returns an <see cref="ITryConverter{String}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static ITryConverter<string> TryConvert(this string value)
		{
			return new TryConverter<string>(value);
		}

		/// <summary>
		///     Returns an <see cref="ITryConverter{String}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <param name="formatProvider">The format provider used in the conversions, f.e. CultureInfo.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static ITryConverter<string> TryConvert(this string value, IFormatProvider formatProvider)
		{
			return new TryConverter<string>(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a bool.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToBool(this ITryConverter<string> converter, out bool result)
		{
			string value = converter.Value;
			return bool.TryParse(value.ConvertBoolString(), out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a byte.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToByte(this ITryConverter<string> converter, out byte result)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return byte.TryParse(value, NumberStyles.Any, formatProvider, out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a short.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToShort(this ITryConverter<string> converter, out short result)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return short.TryParse(value, NumberStyles.Any, formatProvider, out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to an int.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToInt(this ITryConverter<string> converter, out int result)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return int.TryParse(value, NumberStyles.Any, formatProvider, out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a long.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToLong(this ITryConverter<string> converter, out long result)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return long.TryParse(value, NumberStyles.Any, formatProvider, out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a float.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToFloat(this ITryConverter<string> converter, out float result)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return float.TryParse(value, NumberStyles.Any, formatProvider, out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a double.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToDouble(this ITryConverter<string> converter, out double result)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return double.TryParse(value, NumberStyles.Any, formatProvider, out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a decimal.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToDecimal(this ITryConverter<string> converter, out decimal result)
		{
			string value = converter.Value;
			IFormatProvider formatProvider = converter.FormatProvider;
			return decimal.TryParse(value, NumberStyles.Any, formatProvider, out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a Guid.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToGuid(this ITryConverter<string> converter, out Guid result)
		{
			string value = converter.Value;
			return Guid.TryParse(value, out result);
		}
	}
}
