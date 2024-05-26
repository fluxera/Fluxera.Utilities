// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Uncapitalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The uncapitalized string.</returns>
		public static string Uncapitalize(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Uncapitalize(str);
		}
	}
}
