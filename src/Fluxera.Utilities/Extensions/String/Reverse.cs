﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Reverses the string. If the string is null, null is returned.
		/// </summary>
		/// <param name="str">The string to reverse.</param>
		/// <returns>The reversed string.</returns>
		public static string Reverse(this string str)
		{
			if(string.IsNullOrEmpty(str))
			{
				return string.Empty;
			}

			if(str.Length == 1)
			{
				return str;
			}

			Span<char> result = str.Length > 1024 ? str.ToCharArray() : stackalloc char[str.Length];
			if(str.Length <= 1024)
			{
				str.AsSpan().CopyTo(result);
			}

			result.Reverse();

			return result.ToString();
		}
	}
}
