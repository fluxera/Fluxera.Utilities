// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Pascalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The pascal cased string.</returns>
		public static string Pascalize(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Pascalize(str);
		}
	}
}
