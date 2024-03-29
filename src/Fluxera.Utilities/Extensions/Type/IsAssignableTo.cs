﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class TypeExtensions
	{
		/// <summary>
		///     Checks if <see cref="Type" /> <paramref name="from" /> is assignable to <see cref="Type" /> T.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public static bool IsAssignableTo<T>(this Type from)
		{
			return from.IsAssignableTo(typeof(T));
		}
	}
}
