// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Removes the first occurrence of the given postfixes from the end of the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <param name="postFixes">one or more postfix.</param>
		/// <returns>Modified string or the same string if it has not any of given postfixes</returns>
		public static string? RemovePostFix(this string str, params string[] postFixes)
		{
			return str.RemovePostFix(StringComparison.Ordinal, postFixes);
		}

		/// <summary>
		///     Removes the first occurrence of the given postfixes from the end of the given string.
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
	}
}
