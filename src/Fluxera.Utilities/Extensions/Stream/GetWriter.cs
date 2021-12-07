// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.IO;
	using System.Text;
	using Guards;

	public static partial class StreamExtensions
	{
		/// <summary>
		///     Opens a <see cref="StreamWriter" /> using the default encoding (<see cref="Encoding.UTF8" />).
		/// </summary>
		/// <param name="stream">The stream.</param>
		/// <returns>The stream writer.</returns>
		/// <exception cref="ArgumentException"></exception>
		public static StreamWriter GetWriter(this Stream stream)
		{
			return stream.GetWriter(Encoding.UTF8);
		}

		/// <summary>
		///     Opens a <see cref="StreamWriter" /> using the specified encoding.
		/// </summary>
		/// <param name="stream">The stream.</param>
		/// <param name="encoding">The encoding.</param>
		/// <returns>The stream writer.</returns>
		/// <exception cref="ArgumentException"></exception>
		public static StreamWriter GetWriter(this Stream stream, Encoding encoding)
		{
			Guard.Against.Null(stream, nameof(stream));
			Guard.Against.False(stream.CanWrite, nameof(stream), "The stream does not support writing.");

			encoding = encoding ?? Encoding.UTF8;
			return new StreamWriter(stream, encoding);
		}
	}
}
