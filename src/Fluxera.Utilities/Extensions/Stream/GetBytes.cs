// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.IO;
	using System.Threading.Tasks;

	/// <summary>
	///     Extension methods for the <see cref="Stream" /> type.
	/// </summary>
	public static partial class StreamExtensions
	{
		/// <summary>
		///     Gets all bytes of a <see cref="Stream" />.
		/// </summary>
		/// <param name="stream"></param>
		/// <returns>The data of the stream.</returns>
		public static byte[] GetBytes(this Stream stream)
		{
			Guard.ThrowIfNull(stream);
			Guard.ThrowIfFalse(stream.CanRead, message: "The stream does not support reading.");

			byte[] buffer = new byte[16 * 1024];
			using(MemoryStream ms = new MemoryStream())
			{
				int read;
				while((read = stream.Read(buffer, 0, buffer.Length)) > 0)
				{
					ms.Write(buffer, 0, read);
				}

				return ms.ToArray();
			}
		}

		/// <summary>
		///     Gets all bytes from the steam.
		/// </summary>
		/// <param name="stream"></param>
		/// <returns>The data of the stream.</returns>
		public static byte[] GetAllBytes(this Stream stream)
		{
			Guard.ThrowIfNull(stream);
			Guard.ThrowIfFalse(stream.CanRead, message: "The stream does not support reading.");

			using(MemoryStream memoryStream = new MemoryStream())
			{
				stream.CopyTo(memoryStream);
				return memoryStream.ToArray();
			}
		}

		/// <summary>
		///     Gets all bytes from the steam.
		/// </summary>
		/// <param name="stream"></param>
		/// <returns>The data of the stream.</returns>
		public static async Task<byte[]> GetAllBytesAsync(this Stream stream)
		{
			Guard.ThrowIfNull(stream);
			Guard.ThrowIfFalse(stream.CanRead, message: "The stream does not support reading.");

			await using(MemoryStream memoryStream = new MemoryStream())
			{
				await stream.CopyToAsync(memoryStream);
				return memoryStream.ToArray();
			}
		}
	}
}
