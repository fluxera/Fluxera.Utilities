// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for struct types.
	/// </summary>
	public static partial class ValueTypeExtensions
	{
		/// <summary>
		///     Determines if the specified <see cref="T" /> is a nullable.
		/// </summary>
		/// <returns><c>true</c> if the specified type is nullable; otherwise, <c>false</c>.</returns>
		/// <param name="t">T.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static bool IsNullable<T>(this T t)
		{
			return false;
		}

		/// <summary>
		///     Determines if the specified <see cref="T" /> is a nullable.
		/// </summary>
		/// <returns><c>true</c> if the specified type is nullable; otherwise, <c>false</c>.</returns>
		/// <param name="t">T.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static bool IsNullable<T>(this T? t) where T : struct
		{
			return true;
		}
	}
}
