// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Truncates the string to a specified length and replace the truncated part to '...'.
		/// </summary>
		/// <param name="str">The string that will be truncated.</param>
		/// <param name="maxLength">The total length of characters to maintain before the  truncate happens.</param>
		/// <returns>truncated string</returns>
		public static string Truncate(this string str, int maxLength)
		{
			if (string.IsNullOrEmpty(str))
			{
				return string.Empty;
			}

			Guard.Against.Negative(maxLength, nameof(maxLength));

			const string suffix = "...";
			int strLength = maxLength - suffix.Length;
			string truncatedString = str;

			if((maxLength > 0) && (strLength > 0) && (str.Length > maxLength))
			{
				truncatedString = str.Substring(0, strLength);
				truncatedString = truncatedString.TrimEnd();
				truncatedString += suffix;
			}

			return truncatedString;
		}
	}
}
