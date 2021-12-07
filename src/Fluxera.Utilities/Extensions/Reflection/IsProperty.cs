// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;

	public static partial class ReflectionExtensions
	{
		public static bool IsProperty(this MethodInfo method)
		{
			return method.IsSpecialName && (method.Name.StartsWith("get_", StringComparison.Ordinal) ||
				method.Name.StartsWith("set_", StringComparison.Ordinal));
		}
	}
}
