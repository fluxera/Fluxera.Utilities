// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Linq;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Removes all special characters from the string.
		///     If any special character should remain in the string, this character can be given as ignore items.
		/// </summary>
		/// <param name="str">The string to convert.</param>
		/// <param name="ignore">The characters to ignore when replacing.</param>
		/// <returns>The string without special characters.</returns>
		public static string RemoveSpecialCharacters(this string str, params char[] ignore)
		{
			Guard.ThrowIfNullOrEmpty(str);

			string result = string.Empty;
			ignore ??= [];

			return str.Where(character => char.IsLetterOrDigit(character) || ignore.Contains(character))
					  .Aggregate(result, (current, character) => current + character);
		}
	}
}
