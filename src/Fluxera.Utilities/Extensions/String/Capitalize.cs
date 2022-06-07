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
		///     Capitalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The capitalized string.</returns>
		public static string Capitalize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Capitalize(str);
		}
	}
}
