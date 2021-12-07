﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
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
	}
}
