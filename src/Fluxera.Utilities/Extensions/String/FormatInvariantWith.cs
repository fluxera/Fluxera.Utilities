// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Globalization;
	using Fluxera.Guards;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Applies formatting to the string using the invariant culture.
		/// </summary>
		/// <param name="str">The string containing the format template.</param>
		/// <param name="args">The arguments for formatting.</param>
		/// <returns>The formatted string.</returns>
		public static string FormatInvariantWith(this string str, params object[] args)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.FormatWith(CultureInfo.InvariantCulture, args);
		}
	}
}
