// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Text;
	using System.Text.RegularExpressions;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Encodes string to base64. <br />
		///		See: https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
		/// </summary>
		/// <param name="str">String to encode.</param>
		/// <param name="encoding">Encoding to use. Defaults to Encoding.Default.</param>
		/// <returns>The base64 encoded version of the string</returns>
		public static string ToBase64(this string str, Encoding? encoding = null)
		{
			if(string.IsNullOrWhiteSpace(str))
			{
				return string.Empty;
			}

			encoding ??= Encoding.Default;

			byte[] stringBytes = encoding.GetBytes(str);
			return Convert.ToBase64String(stringBytes);
		}
	}
}
