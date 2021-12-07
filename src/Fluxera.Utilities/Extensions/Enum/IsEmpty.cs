// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class EnumExtensions
	{
		/// <summary>
		///     Gets a flag, if the enum has no values.
		/// </summary>
		public static bool IsEmpty<TEnum>(this TEnum @enum) where TEnum : struct, Enum
		{
			return EnumTraits<TEnum>.IsEmpty;
		}
	}
}
