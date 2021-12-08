// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.IO;
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class StreamExtensions
	{
		/// <summary>
		///     Rewinds (set the current position to 0) the stream.
		/// </summary>
		/// <param name="stream">The stream to Rewind</param>
		/// <exception cref="ArgumentException"></exception>
		public static void Rewind(this Stream stream)
		{
			Guard.Against.Null(stream, nameof(stream));
			Guard.Against.False(stream.CanSeek, nameof(stream), "The stream does not support seeking.");

			stream.Seek(0, SeekOrigin.Begin);
		}
	}
}
