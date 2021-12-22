// ReSharper disable once CheckNamespace

namespace Fluxera.Collections.Generic
{
	using System;
	using System.Collections.Generic;
	using JetBrains.Annotations;

	/// <summary>
	///     A specialized <see cref="IList{T}" /> that enforces a constraint on the
	///     base type of the types to add tio this list.
	/// </summary>
	/// <typeparam name="TBaseType">The base type of the types that can be added to this list.</typeparam>
	[PublicAPI]
	public interface ITypeList<in TBaseType> : IList<Type>
	{
		/// <summary>
		///     Adds a type to the list.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		void Add<T>() where T : TBaseType;

		/// <summary>
		///     Adds a type to the list if it is not already in the list.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		bool TryAdd<T>() where T : TBaseType;

		/// <summary>
		///     Checks if the type exists in the list.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		bool Contains<T>() where T : TBaseType;

		/// <summary>
		///     Removes a type from the list.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		void Remove<T>() where T : TBaseType;
	}
}
