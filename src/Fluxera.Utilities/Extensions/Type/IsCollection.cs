// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections;
	using System.Reflection;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Determines if is enumerable the specified type.
		/// </summary>
		/// <returns><c>true</c> if is enumerable the specified type; otherwise, <c>false</c>.</returns>
		/// <param name="type">Type.</param>
		public static bool IsCollection(this Type type)
		{
			return typeof(ICollection).GetTypeInfo().IsAssignableFrom(type);
		}
	}
}
