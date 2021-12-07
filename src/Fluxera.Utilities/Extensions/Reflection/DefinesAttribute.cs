// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Returns true if the type of the object is marked with the specified attribute.
		/// </summary>
		/// <param name="type">The object to check.</param>
		/// <param name="attributeType">The attribute type to check for.</param>
		/// <returns>True, if the type is marked with the attribute.</returns>
		public static bool DefinesAttribute(this MemberInfo type, Type attributeType)
		{
			return type.IsDefined(attributeType, true);
		}

		/// <summary>
		///     Returns true if the type of the object is marked with the specified attribute.
		/// </summary>
		/// <typeparam name="TAttribute">The attribute type to check for.</typeparam>
		/// <param name="type">The object to check.</param>
		/// <returns>True, if the type is marked with the attribute.</returns>
		public static bool DefinesAttribute<TAttribute>(this MemberInfo type) where TAttribute : Attribute
		{
			return type.DefinesAttribute(typeof(TAttribute));
		}
	}
}
