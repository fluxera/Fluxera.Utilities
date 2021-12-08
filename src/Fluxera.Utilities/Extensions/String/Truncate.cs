// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Truncates the string to a specified length and optionally replace the truncated part with '...' suffix.
		/// </summary>
		/// <param name="str">The string that will be truncated.</param>
		/// <param name="maxLength">The total length of characters to maintain before the  truncate happens.</param>
		/// <param name="addSuffix">Add '...' suffix to the end of the result if this is <c>true</c>. Default is <c>false</c>.</param>
		/// <returns>truncated string</returns>
		public static string Truncate(this string str, int maxLength, bool addSuffix = false)
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
				if(addSuffix)
				{
					truncatedString += suffix;
				}
			}

			return truncatedString;
		}
	}
}
