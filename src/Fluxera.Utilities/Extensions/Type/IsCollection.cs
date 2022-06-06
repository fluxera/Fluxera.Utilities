// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Reflection;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Determines if the specified type is a collection.
		/// </summary>
		/// <returns><c>true</c> if the specified type is a collection; otherwise, <c>false</c>.</returns>
		/// <param name="type">Type.</param>
		public static bool IsCollection(this Type type)
		{
			if(type.IsGenericType)
			{
				return
					IsAssignableFromGenericType(typeof(ICollection<>), type) ||
					IsAssignableFromGenericType(typeof(IReadOnlyCollection<>), type);
			}

			return
				typeof(ICollection).GetTypeInfo().IsAssignableFrom(type);
		}

		private static bool IsAssignableFromGenericType(Type genericType, Type givenType)
		{
			Type[] interfaceTypes = givenType.GetInterfaces();

			foreach(Type it in interfaceTypes)
			{
				if(it.IsGenericType && it.GetGenericTypeDefinition() == genericType)
				{
					return true;
				}
			}

			if(givenType.IsGenericType && givenType.GetGenericTypeDefinition() == genericType)
			{
				return true;
			}

			Type baseType = givenType.BaseType;
			return baseType != null && IsAssignableFromGenericType(genericType, baseType);
		}
	}
}
