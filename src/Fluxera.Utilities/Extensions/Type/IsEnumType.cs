// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Determines whether the specified type is an enum type. It automatically
		///     unwraps the type of a nullable.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>
		///     <c>true</c> if the specified type is an enum type; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsEnumType(this Type type)
		{
			type = type.UnwrapNullableType();
			return (type.BaseType == typeof(Enum)) || type.IsEnum;
		}
	}
}
