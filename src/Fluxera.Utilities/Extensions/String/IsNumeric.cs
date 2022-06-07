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
		///     Checks if the contents of the string is a numeric value.
		/// </summary>
		/// <param name="str">The string to check.</param>
		/// <returns>True, if the string contents is a numeric value.</returns>
		public static bool IsNumeric(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return double.TryParse(str, out double _);
		}
	}
}
