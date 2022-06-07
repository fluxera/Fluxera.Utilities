// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class TypeExtensions
	{
		/// <summary>
		/// </summary>
		/// <param name="toCheck"></param>
		/// <param name="generic"></param>
		/// <returns></returns>
		[Obsolete]
		public static bool IsSubclassOfRawGeneric(this Type toCheck, Type generic)
		{
			while(toCheck != null && toCheck != typeof(object))
			{
				Type cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
				if(generic == cur)
				{
					return true;
				}

				toCheck = toCheck.BaseType;
			}

			return false;
		}
	}
}
