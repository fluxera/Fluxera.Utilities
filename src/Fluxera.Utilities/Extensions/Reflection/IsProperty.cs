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
		///     Determines if the given method is a property.
		/// </summary>
		/// <param name="method">The method to check.</param>
		/// <returns><c>true</c> if it's a property, <c>false</c> if it's not a property.</returns>
		public static bool IsProperty(this MethodInfo method)
		{
			return method.IsSpecialName && (
				method.Name.StartsWith("get_", StringComparison.Ordinal) ||
				method.Name.StartsWith("set_", StringComparison.Ordinal));
		}
	}
}
