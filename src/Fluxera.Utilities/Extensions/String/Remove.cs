// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Linq;
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Removes all whitespace (not line endings, etc.) from the string.
		/// </summary>
		/// <param name="str">The string to remove the spaces from.</param>
		public static string RemoveSpaces(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.Replace(" ", string.Empty);
		}

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

		/// <summary>
		///     Removes first occurrence of the given postfixes from end of the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <param name="postFixes">one or more postfix.</param>
		/// <returns>Modified string or the same string if it has not any of given postfixes</returns>
		public static string? RemovePostFix(this string str, params string[] postFixes)
		{
			return str.RemovePostFix(StringComparison.Ordinal, postFixes);
		}

		/// <summary>
		///     Removes first occurrence of the given postfixes from end of the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <param name="comparisonType">String comparison type</param>
		/// <param name="postFixes">one or more postfix.</param>
		/// <returns>Modified string or the same string if it has not any of given postfixes</returns>
		public static string? RemovePostFix(this string str, StringComparison comparisonType, params string[] postFixes)
		{
			if(str.IsNullOrEmpty())
			{
				return null;
			}

			if(postFixes.IsNullOrEmpty())
			{
				return str;
			}

			foreach(string postFix in postFixes)
			{
				if(str.EndsWith(postFix, comparisonType))
				{
					return str.Left(str.Length - postFix.Length);
				}
			}

			return str;
		}

		/// <summary>
		///     Removes first occurrence of the given prefixes from beginning of the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <param name="preFixes">one or more prefix.</param>
		/// <returns>Modified string or the same string if it has not any of given prefixes</returns>
		public static string? RemovePreFix(this string str, params string[] preFixes)
		{
			return str.RemovePreFix(StringComparison.Ordinal, preFixes);
		}

		/// <summary>
		///     Removes first occurrence of the given prefixes from beginning of the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <param name="comparisonType">String comparison type</param>
		/// <param name="preFixes">one or more prefix.</param>
		/// <returns>Modified string or the same string if it has not any of given prefixes</returns>
		public static string? RemovePreFix(this string str, StringComparison comparisonType, params string[] preFixes)
		{
			if(str.IsNullOrEmpty())
			{
				return null;
			}

			if(preFixes.IsNullOrEmpty())
			{
				return str;
			}

			foreach(string preFix in preFixes)
			{
				if(str.StartsWith(preFix, comparisonType))
				{
					return str.Right(str.Length - preFix.Length);
				}
			}

			return str;
		}
	}
}
