// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.IO;
	using Guards;

	public static partial class StreamExtensions
	{
		/// <summary>
		///     Copies one stream into a another one.
		/// </summary>
		/// <param name="stream">The source stream.</param>
		/// <param name="targetStream">The target stream.</param>
		/// <exception cref="ArgumentException"></exception>
		public static void CopyTo(this Stream stream, Stream targetStream)
		{
			stream.CopyTo(targetStream, 4096);
		}

		/// <summary>
		///     Copies one stream into a another one.
		/// </summary>
		/// <param name="stream">The source stream.</param>
		/// <param name="targetStream">The target stream.</param>
		/// <param name="bufferSize">The buffer size used to read / write.</param>
		/// <exception cref="ArgumentException"></exception>
		public static void CopyTo(this Stream stream, Stream targetStream, int bufferSize)
		{
			Guard.Against.Null(stream, nameof(stream));
			Guard.Against.Null(targetStream, nameof(targetStream));

			Guard.Against.False(stream.CanRead, nameof(stream), "The stream does not support reading.");
			Guard.Against.False(targetStream.CanWrite, nameof(targetStream), "The stream does not support writing.");

			byte[] buffer = new byte[bufferSize];
			int bytesRead;

			while ((bytesRead = stream.Read(buffer, 0, bufferSize)) > 0)
			{
				targetStream.Write(buffer, 0, bytesRead);
			}
		}
	}
}
