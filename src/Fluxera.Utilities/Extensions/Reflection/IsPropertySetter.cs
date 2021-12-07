// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;

	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Determines if current member is a property setter.
		/// </summary>
		/// <param name="method">The member to determine if it's a property setter</param>
		/// <returns>
		///     <codeInline>true</codeInline> if it's a property setter, <codeInline>false</codeInline> if it's not a property
		///     setter
		/// </returns>
		public static bool IsPropertySetter(this MethodInfo method)
		{
			return method.IsSpecialName && method.Name.StartsWith("set_", StringComparison.Ordinal);
		}
	}
}
