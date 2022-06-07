// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Gets all base classes recursively for the given type.
		/// </summary>
		/// <param name="type">The type to get its base classes.</param>
		/// <param name="includeObject">True, to include the standard <see cref="object" /> type in the returned array.</param>
		public static Type[] GetBaseClasses(this Type type, bool includeObject = true)
		{
			IList<Type> types = new List<Type>();
			AddTypeAndBaseTypesRecursive(types, type.BaseType, includeObject);
			return types.ToArray();
		}

		private static void AddTypeAndBaseTypesRecursive(IList<Type> types, Type type, bool includeObject)
		{
			if(type == null)
			{
				return;
			}

			if(!includeObject && type == typeof(object))
			{
				return;
			}

			AddTypeAndBaseTypesRecursive(types, type.BaseType, includeObject);
			types.Add(type);
		}
	}
}
