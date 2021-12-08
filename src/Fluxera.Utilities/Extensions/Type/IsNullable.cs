// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Determines if the specified type is a nullable.
		/// </summary>
		/// <returns><c>true</c> if the specified type is a nullable; otherwise, <c>false</c>.</returns>
		/// <param name="type">Type.</param>
		public static bool IsNullable(this Type type)
		{
			return Nullable.GetUnderlyingType(type) != null;
		}
	}
}
