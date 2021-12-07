// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.IO;

	public static partial class ArrayExtensions
	{
		/// <summary>
		///     Returns a <see cref="MemoryStream" /> from a byte array.
		/// </summary>
		/// <param name="buffer">The array with the data to use.</param>
		/// <returns>A memory stream with the data from the array.</returns>
		public static MemoryStream ToMemoryStream(this byte[] buffer)
		{
			MemoryStream memoryStream = new MemoryStream(buffer);
			memoryStream.Rewind();
			return memoryStream;
		}
	}
}
