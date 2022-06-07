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
		///     Gets all values of the enum.
		/// </summary>
		public static long[] EnumValues<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.EnumValues();
		}
	}
}
