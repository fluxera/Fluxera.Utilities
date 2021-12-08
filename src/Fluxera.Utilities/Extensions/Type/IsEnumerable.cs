// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections;
	using System.Reflection;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Determines if the specified type is an enumerable.
		/// </summary>
		/// <returns><c>true</c> if type is an enumerable; otherwise, <c>false</c>.</returns>
		/// <param name="type">Type.</param>
		public static bool IsEnumerable(this Type type)
		{
			return typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(type);
		}
	}
}
