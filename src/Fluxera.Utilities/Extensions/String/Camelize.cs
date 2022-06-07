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
		///     Camelizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The camel cased string.</returns>
		public static string Camelize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Camelize(str);
		}
	}
}
