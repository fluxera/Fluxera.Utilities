namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	internal static class EnumTraits<TEnum> where TEnum : struct, Enum
	{
		private static readonly HashSet<TEnum> valuesSet;

		static EnumTraits()
		{
			Type enumType = typeof(TEnum);
			Type underlyingType = Enum.GetUnderlyingType(enumType);

			EnumValues = (TEnum[])Enum.GetValues(typeof(TEnum));
			valuesSet = new HashSet<TEnum>(EnumValues);

			IList<long> longValues = EnumValues
				.Select(value => Convert.ChangeType(value, underlyingType))
				.Select(Convert.ToInt64)
				.ToList();

			IsEmpty = longValues.Count == 0;
			if (!IsEmpty)
			{
				IList<long> sorted = longValues.OrderBy(v => v).ToList();
				MinValue = sorted.Min();
				MaxValue = sorted.Max();
			}
		}

		public static TEnum[] EnumValues { get; }

		// ReSharper disable StaticMemberInGenericType
		public static bool IsEmpty { get; }

		public static long MinValue { get; }

		public static long MaxValue { get; }
		// ReSharper restore StaticMemberInGenericType

		public static bool IsValid(TEnum value) => valuesSet.Contains(value);
	}
}
