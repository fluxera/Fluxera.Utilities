// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		private static readonly char[] padding = { '=' };

		/// <summary>
		///		Decodes the given URL-safe string.
		/// </summary>
		/// <remarks>
		///		https://petedavis.io/blog/url-encoding-password-reset-or-email-confirmation-tokens
		/// </remarks>
		public static string UrlSafeEncode(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.TrimEnd(padding).Replace('+', '-').Replace('/', '_');
		}
	}
}
