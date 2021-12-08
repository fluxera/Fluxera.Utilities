// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class EnumExtensions
	{
		/// <summary>
		///     Gets all options of the enum.
		/// </summary>
		public static TEnum[] EnumOptions<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.EnumOptions();
		}
	}
}
