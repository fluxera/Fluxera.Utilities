// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Globalization;
	using System.Text;
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Replaces all diacritical marks with a ascii representation.
		/// </summary>
		/// <param name="str">The string to convert.</param>
		/// <returns>The string without diacritical marks.</returns>
		public static string ReplaceDiacritics(this string str)
		{
			Guard.Against.NullOrEmpty(str, nameof(str));

			string normalizedString = str.Normalize(NormalizationForm.FormD);
			StringBuilder stringBuilder = new StringBuilder();

			foreach(char c in normalizedString)
			{
				UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
				if(unicodeCategory != UnicodeCategory.NonSpacingMark)
				{
					stringBuilder.Append(c);
				}
			}

			return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
		}
	}
}
