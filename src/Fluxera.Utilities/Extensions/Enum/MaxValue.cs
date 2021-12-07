// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class EnumExtensions
	{
		/// <summary>
		///     Gets the maximum value of the enum.
		/// </summary>
		public static long MaxValue<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.MaxValue;
		}
	}
}
