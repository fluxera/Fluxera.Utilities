// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Fluxera.Guards;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Encodes the given string for safe usage in URLs, f.e. for password reset or email confirmation tokens.
		/// </summary>
		/// <remarks>
		///     https://petedavis.io/blog/url-encoding-password-reset-or-email-confirmation-tokens
		/// </remarks>
		public static string UrlSafeDecode(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			string base64String = str.Replace('_', '/').Replace('-', '+');
			switch(str.Length % 4)
			{
				case 2:
					base64String += "==";
					break;
				case 3:
					base64String += "=";
					break;
			}

			return base64String;
		}
	}
}
