// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Uncapitalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The uncapitalized string.</returns>
		public static string Uncapitalize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Uncapitalize(str);
		}
	}
}
