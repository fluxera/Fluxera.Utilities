// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Converts all underscores to dashes.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The dasherized string.</returns>
		public static string Dasherize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Dasherize(str);
		}
	}
}
