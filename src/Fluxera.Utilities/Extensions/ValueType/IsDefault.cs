// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class ValueTypeExtensions
	{
		/// <summary>
		///     Determines whether the specified value is empty (default(T)).
		/// </summary>
		/// <typeparam name="T">The type of the value object.</typeparam>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the specified value is empty.</returns>
		public static bool IsDefault<T>(this T value) where T : struct
		{
			return value.Equals(default(T));
		}

		/// <summary>
		///     Determines whether the specified value is not empty (!default(T)).
		/// </summary>
		/// <typeparam name="T">The type of the value object.</typeparam>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the specified value is not empty.</returns>
		public static bool IsNotDefault<T>(this T value) where T : struct
		{
			return !value.IsDefault();
		}
	}
}
