// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Text;
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Converts the string to a byte-array using the default encoding.
		/// </summary>
		/// <param name="str">The input string.</param>
		/// <returns>The created byte array.</returns>
		public static byte[] GetBytes(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return str.GetBytes(Encoding.UTF8);
		}

		/// <summary>
		///     Converts the string to a byte-array using the given encoding.
		/// </summary>
		/// <param name="str">The input string.</param>
		/// <param name="encoding">The encoding to be used.</param>
		/// <returns>The created byte array.</returns>
		public static byte[] GetBytes(this string str, Encoding encoding)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			encoding ??= Encoding.UTF8;
			return encoding.GetBytes(str);
		}
	}
}
