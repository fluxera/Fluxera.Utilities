// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Capitalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The capitalized string.</returns>
		public static string Capitalize(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Capitalize(str);
		}
	}
}
