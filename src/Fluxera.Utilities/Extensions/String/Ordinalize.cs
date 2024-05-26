// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Ordinalizes the given number that is given as string, f.e. '6' to '6th'.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The ordinalized string.</returns>
		public static string Ordinalize(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);
			Guard.ThrowIfFalse(str.IsNumeric(), message: "The string value must represent a numeric value.");

			return Inflector.Ordinalize(str);
		}
	}
}
