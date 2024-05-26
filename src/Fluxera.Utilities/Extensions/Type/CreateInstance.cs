// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="Type" /> type.
	/// </summary>
	[PublicAPI]
	public static partial class TypeExtensions
	{
		/// <summary>
		///     Creates and returns an instance of the desired type.
		/// </summary>
		/// <param name="type">The type to be instantiated.</param>
		/// <param name="constructorParameters">Optional constructor parameters.</param>
		/// <returns>The instantiated object.</returns>
		public static object CreateInstance(this Type type, params object[] constructorParameters)
		{
			Guard.ThrowIfNull(type);

			return type.CreateInstance<object>(constructorParameters);
		}

		/// <summary>
		///     Creates and returns an instance of the desired type cast to the
		///     generic parameter type T. The instance is created using
		///     <see cref="Activator.CreateInstance(Type, object[])" />. The result
		///     is safely cast to the target type.
		/// </summary>
		/// <typeparam name="T">The data type the instance is cast to.</typeparam>
		/// <param name="type">The type to be instantiated.</param>
		/// <param name="constructorParameters">Optional constructor parameters.</param>
		/// <returns>The instantiated object.</returns>
		public static T CreateInstance<T>(this Type type, params object[] constructorParameters) where T : class
		{
			object instance = Activator.CreateInstance(type, constructorParameters);
			return instance as T;
		}
	}
}
