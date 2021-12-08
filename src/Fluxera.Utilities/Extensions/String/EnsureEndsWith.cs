// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Ensures that a string ends with a given suffix.
		/// </summary>
		/// <param name="str">The string to check.</param>
		/// <param name="suffix">The suffix value to check for.</param>
		/// <returns>The string including the suffix.</returns>
		public static string EnsureEndsWith(this string str, string suffix)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.EndsWith(suffix) ? str : string.Concat(str, suffix);
		}

		/// <summary>
		///     Ensures that a string ends with a given suffix.
		/// </summary>
		/// <param name="str">The string to check.</param>
		/// <param name="suffix">The suffix value to check for.</param>
		/// <returns>The string including the suffix.</returns>
		public static string EnsureEndsWith(this string str, char suffix)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.EndsWith(suffix.ToString()) ? str : string.Concat(str, suffix);
		}
	}
}
