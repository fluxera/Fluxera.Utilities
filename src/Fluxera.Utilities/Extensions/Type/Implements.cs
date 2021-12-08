// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Linq;
	using System.Reflection;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Returns true of the supplied <paramref name="type" /> implements the given interface type <typeparamref name="T" />.
		/// </summary>
		/// <typeparam name="T">The type (interface) to check for.</typeparam>
		/// <param name="type">The type to check.</param>
		/// <returns>True if the given type implements the interface.</returns>
		public static bool Implements<T>(this Type type)
		{
			return type.Implements(typeof(T));
		}

		/// <summary>
		///     Returns true of the supplied <paramref name="type" /> implements the given interface type.
		/// </summary>
		/// <param name="type">The type to check.</param>
		/// <param name="interfaceType">The type (interface) to check for.</param>
		/// <returns>True if the given type implements the interface.</returns>
		public static bool Implements(this Type type, Type interfaceType)
		{
			return type.GetTypeInfo().GetInterfaces().Any(x => x == interfaceType);
		}
	}
}
