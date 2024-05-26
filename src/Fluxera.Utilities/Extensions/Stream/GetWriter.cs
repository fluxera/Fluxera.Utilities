// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.IO;
	using System.Text;

	/// <summary>
	///     Extension methods for the <see cref="Stream" /> type.
	/// </summary>
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
			Guard.ThrowIfNull(stream);
			Guard.ThrowIfFalse(stream.CanWrite, message: "The stream does not support writing.");

			encoding ??= Encoding.UTF8;
			return new StreamWriter(stream, encoding);
		}
	}
}
