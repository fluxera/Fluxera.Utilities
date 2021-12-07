// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	public static partial class ValueTypeExtensions
	{
		/// <summary>
		///     Determines if is nullable the specified <see cref="T" />.
		/// </summary>
		/// <returns><c>true</c> if is nullable the specified t; otherwise, <c>false</c>.</returns>
		/// <param name="t">T.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static bool IsNullable<T>(T t)
		{
			return false;
		}

		/// <summary>
		///     Determines if is nullable the specified <see cref="T" />.
		/// </summary>
		/// <returns><c>true</c> if is nullable the specified t; otherwise, <c>false</c>.</returns>
		/// <param name="t">T.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static bool IsNullable<T>(T? t) where T : struct
		{
			return true;
		}
	}
}
