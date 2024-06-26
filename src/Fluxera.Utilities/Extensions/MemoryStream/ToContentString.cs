﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.IO;
	using System.Text;
	using System.Threading.Tasks;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="MemoryStream" /> type.
	/// </summary>
	[PublicAPI]
	public static class MemoryStreamExtensions
	{
		/// <summary>
		///     Converts the content of the stream to a string. <see cref="Encoding.UTF8" /> is used as default encoding.
		/// </summary>
		/// <param name="stream">The stream to read from.</param>
		/// <returns>The content of the stream as string.</returns>
		public static Task<string> ToContentString(this MemoryStream stream)
		{
			return stream.ToContentString(Encoding.UTF8);
		}

		/// <summary>
		///     Converts the content of the stream to a string. The content is encoded with the given encoding.
		/// </summary>
		/// <param name="stream">The stream to read from.</param>
		/// <param name="encoding">The encoding to use.</param>
		/// <returns>The content of the stream as string.</returns>
		public static async Task<string> ToContentString(this MemoryStream stream, Encoding encoding)
		{
			Guard.ThrowIfNull(stream);
			Guard.ThrowIfNull(encoding);

			using(StreamReader reader = new StreamReader(stream, encoding))
			{
				return await reader.ReadToEndAsync();
			}
		}
	}
}
