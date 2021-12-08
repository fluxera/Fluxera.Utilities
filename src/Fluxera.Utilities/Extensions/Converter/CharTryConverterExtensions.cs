// ReSharper disable once CheckNamespace
namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="ITryConverter{T}" /> type.
	/// </summary>
	[PublicAPI]
	public static class CharTryConverterExtensions
	{
		/// <summary>
		///     Returns an <see cref="ITryConverter{Char}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static ITryConverter<char> TryConvert(this char value)
		{
			return new TryConverter<char>(value);
		}

		/// <summary>
		///     Returns an <see cref="ITryConverter{Char}" /> instance on which several extensions exist.
		/// </summary>
		/// <param name="value">The string to wrap in an IConverter.</param>
		/// <param name="formatProvider">The format provider used in the conversions, f.e. CultureInfo.</param>
		/// <returns>The string wrapped in an IConverter.</returns>
		public static ITryConverter<char> TryConvert(this char value, IFormatProvider formatProvider)
		{
			return new TryConverter<char>(value, formatProvider);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a bool.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToBool(this ITryConverter<char> converter, out bool result)
		{
			return converter.ToStringConverter().ToBool(out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a byte.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToByte(this ITryConverter<char> converter, out byte result)
		{
			return converter.ToStringConverter().ToByte(out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a short.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToShort(this ITryConverter<char> converter, out short result)
		{
			return converter.ToStringConverter().ToShort(out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to an int.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToInt(this ITryConverter<char> converter, out int result)
		{
			return converter.ToStringConverter().ToInt(out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a long.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToLong(this ITryConverter<char> converter, out long result)
		{
			return converter.ToStringConverter().ToLong(out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a float.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToFloat(this ITryConverter<char> converter, out float result)
		{
			return converter.ToStringConverter().ToFloat(out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a double.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToDouble(this ITryConverter<char> converter, out double result)
		{
			return converter.ToStringConverter().ToDouble(out result);
		}

		/// <summary>
		///     Converts the internal string of the converter safely to a decimal.
		/// </summary>
		/// <param name="converter">The converter containing the string to convert.</param>
		/// <param name="result">The converted value.</param>
		/// <returns>A flag indicating the success of the parse operation.</returns>
		public static bool ToDecimal(this ITryConverter<char> converter, out decimal result)
		{
			return converter.ToStringConverter().ToDecimal(out result);
		}

		private static ITryConverter<string> ToStringConverter(this ITryConverter<char> converter)
		{
			return new TryConverter<string>(converter.Value.ToString(), converter.FormatProvider);
		}
	}
}
