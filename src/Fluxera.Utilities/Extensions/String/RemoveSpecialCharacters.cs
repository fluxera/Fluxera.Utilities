// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Linq;
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Removes all special characters from the string. If any special character
		///     should remain in the string, this character can be given as ignore items.
		/// </summary>
		/// <param name="str">The string to convert.</param>
		/// <param name="ignore">The characters to ignore when replacing.</param>
		/// <returns>The string without special characters.</returns>
		public static string RemoveSpecialCharacters(this string str, params char[] ignore)
		{
			Guard.Against.NullOrEmpty(str, nameof(str));

			string result = string.Empty;
			ignore ??= Array.Empty<char>();

			foreach(char character in str)
			{
				if(char.IsLetterOrDigit(character) || ignore.Contains(character))
				{
					result += character;
				}
			}

			return result;
		}
	}
}
