// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.IO;
	using Fluxera.Guards;

	/// <summary>
	///     Extension methods for the <see cref="Stream" /> type.
	/// </summary>
	public static partial class StreamExtensions
	{
		/// <summary>
		///     Copies any stream into a local <see cref="MemoryStream" />.
		/// </summary>
		/// <param name="stream">The source stream.</param>
		/// <returns>The new, copied, rewound memory stream.</returns>
		/// <exception cref="ArgumentException"></exception>
		public static MemoryStream CopyToMemory(this Stream stream)
		{
			Guard.Against.Null(stream, nameof(stream));

			MemoryStream memoryStream = new MemoryStream((int)stream.Length);
			CopyTo(stream, memoryStream);
			memoryStream.Rewind();
			return memoryStream;
		}
	}
}
