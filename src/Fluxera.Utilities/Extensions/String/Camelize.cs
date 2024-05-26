// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
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
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Camelize(str);
		}
	}
}
