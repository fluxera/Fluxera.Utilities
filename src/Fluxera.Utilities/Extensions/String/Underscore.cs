// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Replaces all dashes with underscores.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The string containing underscores.</returns>
		public static string Underscore(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Underscore(str);
		}
	}
}
