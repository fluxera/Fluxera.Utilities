// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     A shortcut to use <see cref="Random" /> class.
	/// </summary>
	[PublicAPI]
	public static class RandomHelper
	{
		private static readonly Random random = new Random();

		/// <summary>
		///     Returns a random number within a specified range.
		/// </summary>
		/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
		/// <param name="maxValue">
		///     The exclusive upper bound of the random number returned. maxValue must be greater than or equal
		///     to minValue.
		/// </param>
		/// <returns>
		///     A 32-bit signed integer greater than or equal to minValue and less than maxValue;
		///     that is, the range of return values includes minValue but not maxValue.
		///     If minValue equals maxValue, minValue is returned.
		/// </returns>
		public static int GetRandom(int minValue, int maxValue)
		{
			lock(random)
			{
				return random.Next(minValue, maxValue);
			}
		}

		/// <summary>
		///     Returns a nonnegative random number less than the specified maximum.
		/// </summary>
		/// <param name="maxValue">
		///     The exclusive upper bound of the random number to be generated. maxValue must be greater than or
		///     equal to zero.
		/// </param>
		/// <returns>
		///     A 32-bit signed integer greater than or equal to zero, and less than maxValue;
		///     that is, the range of return values ordinarily includes zero but not maxValue.
		///     However, if maxValue equals zero, maxValue is returned.
		/// </returns>
		public static int GetRandom(int maxValue)
		{
			lock(random)
			{
				return random.Next(maxValue);
			}
		}

		/// <summary>
		///     Returns a nonnegative random number.
		/// </summary>
		/// <returns>A 32-bit signed integer greater than or equal to zero and less than <see cref="int.MaxValue" />.</returns>
		public static int GetRandom()
		{
			lock(random)
			{
				return random.Next();
			}
		}

		/// <summary>
		///     Gets random of given objects.
		/// </summary>
		/// <typeparam name="T">Type of the objects</typeparam>
		/// <param name="items">List of object to select a random one</param>
		public static T GetRandomOf<T>(params T[] items)
		{
			items = Guard.Against.Null(items);

			return items[GetRandom(0, items.Length)];
		}

		/// <summary>
		///     Gets random item from the given list.
		/// </summary>
		/// <typeparam name="T">Type of the objects</typeparam>
		/// <param name="items">List of object to select a random one</param>
		public static T GetRandomOfList<T>(IList<T> items)
		{
			items = Guard.Against.Null(items);

			return items[GetRandom(0, items.Count)];
		}

		/// <summary>
		///     Generates a randomized list from given enumerable.
		/// </summary>
		/// <typeparam name="T">Type of items in the list</typeparam>
		/// <param name="items">items</param>
		public static IList<T> GenerateRandomizedList<T>(IEnumerable<T> items)
		{
			items = Guard.Against.Null(items);

			IList<T> currentList = new List<T>(items);
			IList<T> randomList = new List<T>();

			while(currentList.Any())
			{
				int randomIndex = GetRandom(0, currentList.Count);
				randomList.Add(currentList[randomIndex]);
				currentList.RemoveAt(randomIndex);
			}

			return randomList;
		}
	}
}
