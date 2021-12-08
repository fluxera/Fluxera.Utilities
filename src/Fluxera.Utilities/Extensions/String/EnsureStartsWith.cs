// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Ensures that a string starts with a given prefix.
		/// </summary>
		/// <param name="str">The string to check.</param>
		/// <param name="prefix">The prefix value to check for.</param>
		/// <returns>The string including the prefix.</returns>
		public static string EnsureStartsWith(this string str, string prefix)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.StartsWith(prefix) ? str : string.Concat(prefix, str);
		}

		/// <summary>
		///     Ensures that a string starts with a given prefix.
		/// </summary>
		/// <param name="str">The string to check.</param>
		/// <param name="prefix">The prefix value to check for.</param>
		/// <returns>The string including the prefix.</returns>
		public static string EnsureStartsWith(this string str, char prefix)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.StartsWith(prefix.ToString()) ? str : string.Concat(prefix, str);
		}
	}
}
