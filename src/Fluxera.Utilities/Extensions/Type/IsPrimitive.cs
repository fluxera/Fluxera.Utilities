// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;

	public static partial class TypeExtensions
	{
		private static readonly HashSet<Type> extraPrimitiveTypes = new HashSet<Type>
		{
			typeof(string),
			typeof(decimal),
			typeof(DateOnly),
			typeof(TimeOnly),
			typeof(DateTime),
			typeof(DateTimeOffset),
			typeof(TimeSpan),
			typeof(Guid)
		};

		/// <summary>
		///     Determines whether the specified type is a primitive. It automatically
		///     unwraps the type of a nullable.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="includeEnums">if set to <c>true</c> include enums.</param>
		/// <returns>
		///     <c>true</c> if the specified type is a primitive; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsPrimitive(this Type type, bool includeEnums = false)
		{
			type = type.UnwrapNullableType();

			if(type.IsPrimitive)
			{
				return true;
			}

			if(includeEnums && type.IsEnum)
			{
				return true;
			}

			return extraPrimitiveTypes.Contains(type);
		}
	}
}
