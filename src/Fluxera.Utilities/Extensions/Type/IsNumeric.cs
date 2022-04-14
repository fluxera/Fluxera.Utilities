// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Determines if the given type is numeric.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>
		///     <c>true</c> if the specified type is numeric; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNumeric(this Type type)
		{
			type = type.UnwrapNullableType();
			return
				(type == typeof(sbyte)) ||
				(type == typeof(byte)) ||
				(type == typeof(short)) ||
				(type == typeof(ushort)) ||
				(type == typeof(int)) ||
				(type == typeof(uint)) ||
				(type == typeof(long)) ||
				(type == typeof(ulong)) ||
				(type == typeof(decimal)) ||
				(type == typeof(float)) ||
				(type == typeof(double));
		}
	}
}
