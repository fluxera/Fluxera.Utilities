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
		///     A generic version of <see cref="Enum.HasFlag(Enum)" />.
		/// </summary>
		public static bool HasFlag<TEnum>(this TEnum left, TEnum right) where TEnum : struct, Enum
		{
			return (left.ToLong() & right.ToLong()) != 0;
		}

		private static long ToLong<TEnum>(this TEnum value)
			where TEnum : struct, Enum, IConvertible
		{
			return value.ToInt64(null);
		}
	}
}
