// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class TypeExtensions
	{
		/// <summary>
		/// Determines whether the given type is numeric.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>
		///   <c>true</c> if the specified type is numeric; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNumeric(this Type type)
		{
			Type targetType = type.UnwrapNullableType();
			return
				targetType == typeof(sbyte) ||
				targetType == typeof(byte) ||
				targetType == typeof(short) ||
				targetType == typeof(ushort) ||
				targetType == typeof(int) ||
				targetType == typeof(uint) ||
				targetType == typeof(long) ||
				targetType == typeof(ulong) ||
				targetType == typeof(decimal) ||
				targetType == typeof(float) ||
				targetType == typeof(double);
		}
	}
}
