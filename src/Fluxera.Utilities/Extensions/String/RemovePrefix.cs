// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Removes the first occurrence of the given prefixes from the beginning of the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <param name="preFixes">one or more prefix.</param>
		/// <returns>Modified string or the same string if it has not any of given prefixes</returns>
		public static string RemovePreFix(this string str, params string[] preFixes)
		{
			return str.RemovePreFix(StringComparison.Ordinal, preFixes);
		}

		/// <summary>
		///     Removes the first occurrence of the given prefixes from the beginning of the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <param name="comparisonType">String comparison type</param>
		/// <param name="preFixes">one or more prefix.</param>
		/// <returns>Modified string or the same string if it has not any of given prefixes</returns>
		public static string RemovePreFix(this string str, StringComparison comparisonType, params string[] preFixes)
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
