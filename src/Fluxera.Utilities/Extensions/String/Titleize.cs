// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Return the string in a form that can be used as title. <br/>
		///     Every word is capitalized and the string stripped of dashes and underscores.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>A string that is in title form.</returns>
		public static string Titleize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Titleize(str);
		}
	}
}
