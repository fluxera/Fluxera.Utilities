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
		///     Gets all options of the enum.
		/// </summary>
		public static TEnum[] EnumOptions<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.EnumOptions();
		}
	}
}
