// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.IO;

	/// <summary>
	///     Extension methods for the <see cref="Stream" /> type.
	/// </summary>
	public static partial class StreamExtensions
	{
		/// <summary>
		///     Writes all passed bytes to the specified stream.
		/// </summary>
		/// <param name="stream">The stream.</param>
		/// <param name="bytes">The byte array / buffer.</param>
		public static void Write(this Stream stream, byte[] bytes)
		{
			Guard.ThrowIfNull(stream);

			stream.Write(bytes, 0, bytes.Length);
		}
	}
}
