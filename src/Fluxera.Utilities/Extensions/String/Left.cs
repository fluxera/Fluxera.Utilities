// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using Fluxera.Guards;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Gets a substring of a string from beginning of the string.
		/// </summary>
		public static string Left(this string str, int length)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			if(str.Length < length)
			{
				throw new ArgumentException("Value cannot be bigger than the length of the given string.", nameof(length));
			}

			return str.Substring(0, length);
		}
	}
}
