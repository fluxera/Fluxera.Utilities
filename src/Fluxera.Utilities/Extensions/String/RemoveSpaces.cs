// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Removes all whitespace (not line endings, etc.) from the string.
		/// </summary>
		/// <param name="str">The string to remove the spaces from.</param>
		public static string RemoveSpaces(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return str.Replace(" ", string.Empty);
		}
	}
}
