// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;

	/// <summary>
	///     Extension methods for the <see cref="MethodInfo" /> type.
	/// </summary>
	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Determines if the given method is a property setter.
		/// </summary>
		/// <param name="method">The member to determine if it's a property setter.</param>
		/// <returns><c>true</c> if it's a property setter, <c>false</c> if it's not a property setter.</returns>
		public static bool IsPropertySetter(this MethodInfo method)
		{
			return method.IsSpecialName && method.Name.StartsWith("set_", StringComparison.Ordinal);
		}
	}
}
