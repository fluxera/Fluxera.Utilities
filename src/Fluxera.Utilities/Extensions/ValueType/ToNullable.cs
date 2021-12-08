// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	public static partial class ValueTypeExtensions
	{
		/// <summary>
		///     Converts the specified value to a corresponding nullable type.
		/// </summary>
		/// <typeparam name="T">The type of the resulting nullable.</typeparam>
		/// <param name="value">The value to make nullable.</param>
		/// <returns>The created nullable.</returns>
		public static T? ToNullable<T>(this T value) where T : struct
		{
			return value.IsDefault() ? null : new T?(value);
		}
	}
}
