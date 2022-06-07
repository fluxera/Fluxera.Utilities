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
		///     Returns the singular form of the specified word.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>A string that is the singular form of the input parameter.</returns>
		public static string Singularize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Singularize(str);
		}
	}
}
