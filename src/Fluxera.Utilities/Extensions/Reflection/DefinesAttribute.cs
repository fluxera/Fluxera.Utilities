// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="MemberInfo" /> type.
	/// </summary>
	[PublicAPI]
	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Returns true if the member is marked with the specified attribute.
		/// </summary>
		/// <param name="type">The member to check.</param>
		/// <param name="attributeType">The attribute type to check for.</param>
		/// <returns>True, if the member is marked with the attribute.</returns>
		public static bool DefinesAttribute(this MemberInfo type, Type attributeType)
		{
			return type.IsDefined(attributeType, true);
		}

		/// <summary>
		///     Returns true if the member is marked with the specified attribute.
		/// </summary>
		/// <typeparam name="TAttribute">The attribute type to check for.</typeparam>
		/// <param name="type">The member to check.</param>
		/// <returns>True, if the member is marked with the attribute.</returns>
		public static bool DefinesAttribute<TAttribute>(this MemberInfo type) where TAttribute : Attribute
		{
			return type.DefinesAttribute(typeof(TAttribute));
		}
	}
}
