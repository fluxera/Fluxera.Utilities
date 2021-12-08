// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Returns true if the type of is marked with the specified attribute.
		/// </summary>
		/// <param name="type">The type to check.</param>
		/// <param name="attributeType">The attribute type to check for.</param>
		/// <returns>True, if the type is marked with the attribute.</returns>
		public static bool DefinesAttribute(this Type type, Type attributeType)
		{
			return type.GetTypeInfo().IsDefined(attributeType, true);
		}

		/// <summary>
		///     Returns true if the type of is marked with the specified attribute.
		/// </summary>
		/// <typeparam name="TAttribute">The attribute type to check for.</typeparam>
		/// <param name="type">The type to check.</param>
		/// <returns>True, if the type is marked with the attribute.</returns>
		public static bool DefinesAttribute<TAttribute>(this Type type) where TAttribute : Attribute
		{
			return type.DefinesAttribute(typeof(TAttribute));
		}
	}
}
