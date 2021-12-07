// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.IO;
	using System.Threading.Tasks;
	using Guards;

	public static partial class StreamExtensions
	{
		/// <summary>
		///     Gets all bytes of a <see cref="Stream" />.
		/// </summary>
		/// <param name="stream"></param>
		/// <returns>the bytes.</returns>
		public static byte[] GetBytes(this Stream stream)
		{
			Guard.Against.Null(stream, nameof(stream));
			Guard.Against.False(stream.CanRead, nameof(stream), "The stream does not support reading.");

			byte[] buffer = new byte[16 * 1024];
			using (MemoryStream ms = new MemoryStream())
			{
				int read;
				while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
				{
					ms.Write(buffer, 0, read);
				}

				return ms.ToArray();
			}
		}

		public static byte[] GetAllBytes(this Stream stream)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				stream.CopyTo(memoryStream);
				return memoryStream.ToArray();
			}
		}

		public static async Task<byte[]> GetAllBytesAsync(this Stream stream)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				await stream.CopyToAsync(memoryStream);
				return memoryStream.ToArray();
			}
		}
	}
}
