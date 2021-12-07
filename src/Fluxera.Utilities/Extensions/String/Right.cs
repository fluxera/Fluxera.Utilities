// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Gets a substring of a string from end of the string.
		/// </summary>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="str" /> is null</exception>
		/// <exception cref="ArgumentException">Thrown if <paramref name="len" /> is bigger that string's length</exception>
		public static string Right(this string str, int len)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			if(str.Length < len)
			{
				throw new ArgumentException("len argument can not be bigger than given string's length!");
			}

			return str.Substring(str.Length - len, len);
		}
	}
}
