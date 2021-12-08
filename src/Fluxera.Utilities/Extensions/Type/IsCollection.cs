// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections;
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
			return typeof(ICollection).GetTypeInfo().IsAssignableFrom(type);
		}
	}
}
