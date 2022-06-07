// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Text;
	using System.Text.RegularExpressions;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Decodes a string from base64 to its normal representation. <br />
		///     See: https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string <br />
		///     See: https://www.aspforums.net/Threads/567945/Check-if-Base64-string-is-Valid-or-not-using-C-and-VBNet-in-ASPNet/
		/// </summary>
		/// <param name="str">String to encode.</param>
		/// <param name="encoding">Encoding to use. Defaults to Encoding.Default.</param>
		/// <returns>The decoded version of the string</returns>
		public static string FromBase64(this string str, Encoding encoding = null)
		{
			if(string.IsNullOrEmpty(str))
			{
				return string.Empty;
			}

			// Check for valid base64.
			str = str.Trim();
			bool isValidBase64 = str.Length % 4 == 0 && Regex.IsMatch(str, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

			if(!isValidBase64)
			{
				throw new ArgumentException("The input string is not valid base64 encoded.");
			}

			byte[] data = Convert.FromBase64String(str);
			encoding ??= Encoding.Default;
			return encoding.GetString(data);
		}
	}
}
