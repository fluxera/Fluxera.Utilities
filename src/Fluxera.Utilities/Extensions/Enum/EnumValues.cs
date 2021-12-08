// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class EnumExtensions
	{
		/// <summary>
		///     Gets all values of the enum.
		/// </summary>
		public static long[] EnumValues<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.EnumValues();
		}
	}
}
