// ReSharper disable once CheckNamespace
// ReSharper disable StaticMemberInGenericType

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Linq;

	internal static class EnumTraits<TEnum> where TEnum : struct, Enum
	{
		private static readonly Lazy<TEnum[]> enumOptions = new Lazy<TEnum[]>(() => (TEnum[])Enum.GetValues(typeof(TEnum)));

		private static readonly Lazy<long[]> enumValues = new Lazy<long[]>(() =>
		{
			Type enumType = typeof(TEnum);
			Type underlyingType = Enum.GetUnderlyingType(enumType);

			long[] longValues = enumOptions.Value
				.Select(value => Convert.ChangeType(value, underlyingType))
				.Select(Convert.ToInt64)
				.ToArray();

			return longValues;
		});

		private static readonly Lazy<long[]> enumValuesSorted = new Lazy<long[]>(() => enumValues.Value.OrderBy(value => value).ToArray());

		private static readonly Lazy<bool> isEmpty = new Lazy<bool>(() => enumValues.Value.Length == 0);

		private static readonly Lazy<long> minValue = new Lazy<long>(() => enumValuesSorted.Value.Min());

		private static readonly Lazy<long> maxValue = new Lazy<long>(() => enumValuesSorted.Value.Max());

		public static TEnum[] EnumOptions()
		{
			return enumOptions.Value;
		}

		public static long[] EnumValues()
		{
			return enumValues.Value;
		}

		public static bool IsEmpty()
		{
			return isEmpty.Value;
		}

		public static long MinValue()
		{
			return minValue.Value;
		}

		public static long MaxValue()
		{
			return maxValue.Value;
		}
	}
}
