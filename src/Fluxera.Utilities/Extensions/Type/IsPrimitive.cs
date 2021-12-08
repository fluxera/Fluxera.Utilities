// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Determines whether the specified type is a primitive.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="includeNullable">if set to <c>true</c> include nullable.</param>
		/// <param name="includeEnums">if set to <c>true</c> include enums.</param>
		/// <returns>
		///     <c>true</c> if the specified type is a primitive; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsPrimitive(this Type type, bool includeNullable = true, bool includeEnums = false)
		{
			if(type.IsPrimitiveInternal(includeEnums))
			{
				return true;
			}

			if(includeNullable && type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(Nullable<>)))
			{
				return type.GenericTypeArguments[0].IsPrimitiveInternal(includeEnums);
			}

			return false;
		}

		private static bool IsPrimitiveInternal(this Type type, bool includeEnums)
		{
			if(type.IsPrimitive)
			{
				return true;
			}

			if(includeEnums && type.IsEnum)
			{
				return true;
			}

			return (type == typeof(string)) ||
				(type == typeof(decimal)) ||
				(type == typeof(DateTime)) ||
				(type == typeof(DateTimeOffset)) ||
				(type == typeof(TimeSpan)) ||
				(type == typeof(Guid));
		}
	}
}
