// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class TypeExtensions
	{
		/// <summary>
		/// Gets the type without nullable.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		public static Type UnwrapNullableType(this Type type)
		{
			return Nullable.GetUnderlyingType(type) ?? type;
		}

		/// <summary>
		/// Gets the type without nullable.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		[Obsolete("Use UnwrapNullableType()")]
		public static Type GetTypeWithoutNullable(this Type type)
		{
			return type.UnwrapNullableType();
		}
	}
}
