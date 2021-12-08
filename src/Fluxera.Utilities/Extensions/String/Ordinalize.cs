// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Ordinalizes the given number that is given as string, f.e. '6' to '6th'.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The ordinalized string.</returns>
		public static string Ordinalize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));
			Guard.Against.False(str.IsNumeric(), nameof(str));

			return Inflector.Ordinalize(str);
		}
	}
}
