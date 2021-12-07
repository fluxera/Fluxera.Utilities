// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	public static partial class ObjectExtensions
	{
		/// <summary>
		///     Gets the type default value for the underlying data type, in case of reference types: null
		///     and for values types default(T).
		/// </summary>
		/// <typeparam name="T">The Type of the value.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns>The default value</returns>
		public static T? GetDefaultValue<T>(this T value)
		{
			return default;
		}
	}
}
