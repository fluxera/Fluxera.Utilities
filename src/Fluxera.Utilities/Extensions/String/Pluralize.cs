// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Returns the plural form of the specified word.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>A string that is the plural form of the input parameter.</returns>
		public static string Pluralize(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Pluralize(str);
		}
	}
}
