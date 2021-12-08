// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class ArrayExtensions
	{
		/// <summary>
		///     Checks if the given index is within the array.
		/// </summary>
		/// <param name="source">The array to check the index for.</param>
		/// <param name="index">The index to check.</param>
		/// <returns>True, if the index lies within the array.</returns>
		public static bool IsIndexWithin(this Array source, int index)
		{
			Guard.Against.Null(source, nameof(source));

			return index >= 0 && index < source.Length;
		}
	}
}
