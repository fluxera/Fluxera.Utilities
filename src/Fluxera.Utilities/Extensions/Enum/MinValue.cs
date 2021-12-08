// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class EnumExtensions
	{
		/// <summary>
		///     Gets the minimum value of the enum.
		/// </summary>
		public static long MinValue<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.MinValue();
		}

		/// <summary>
		///     Gets the minimum value of the enum.
		/// </summary>
		public static long Min<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.MinValue();
		}
	}
}
