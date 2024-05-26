// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Globalization;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Applies formatting to the string using the current culture.
		/// </summary>
		/// <param name="str">The string containing the format template.</param>
		/// <param name="args">The arguments for formatting.</param>
		/// <returns>The formatted string.</returns>
		public static string FormatWith(this string str, params object[] args)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return str.FormatWith(CultureInfo.CurrentCulture, args);
		}

		/// <summary>
		///     Applies formatting to the string using the given format provider.
		/// </summary>
		/// <param name="str">The string containing the format template.</param>
		/// <param name="formatProvider">The format provider to use.</param>
		/// <param name="args">The arguments for formatting.</param>
		/// <returns>The formatted string.</returns>
		public static string FormatWith(this string str, IFormatProvider formatProvider, params object[] args)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			formatProvider ??= CultureInfo.CurrentCulture;
			return string.Format(formatProvider, str, args);
		}
	}
}
