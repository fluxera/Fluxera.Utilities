// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;

	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Determines if the given method is a property getter.
		/// </summary>
		/// <param name="method">The member to determine if it's a property getter.</param>
		/// <returns><c>true</c> if it's a property getter, <c>false</c> if it's not a property getter.</returns>
		public static bool IsPropertyGetter(this MethodInfo method)
		{
			return method.IsSpecialName && method.Name.StartsWith("get_", StringComparison.Ordinal);
		}
	}
}
