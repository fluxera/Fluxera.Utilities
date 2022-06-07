// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	/// <summary>
	///     Extension methods for the <see cref="Enum" /> type.
	/// </summary>
	public static partial class EnumExtensions
	{
		/// <summary>
		///     Gets the maximum value of the enum.
		/// </summary>
		public static long MaxValue<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.MaxValue();
		}

		/// <summary>
		///     Gets the maximum value of the enum.
		/// </summary>
		public static long Max<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.MaxValue();
		}
	}
}
