// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.IO;
	using System.Text;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Converts the string to a memory stream. <br />
		///     The stream is rewound after the bytes are written to it. <br />
		///     <see cref="Encoding.UTF8" />) encoding is used.
		/// </summary>
		/// <param name="value">The string to write to the memory steam.</param>
		/// <returns>The new memory stream containing the bytes of the string.</returns>
		/// <exception cref="ArgumentException"></exception>
		public static MemoryStream ToMemoryStream(this string value)
		{
			return value.ToMemoryStream(Encoding.UTF8);
		}

		/// <summary>
		///     Converts the string to a memory stream.  <br />
		///     The stream is rewound after the bytes are written to it. <br />
		///     The given encoding is used.
		/// </summary>
		/// <param name="value">The string to write to the memory steam.</param>
		/// <param name="encoding">The encoding to use.</param>
		/// <returns>The new memory stream containing the bytes of the string.</returns>
		/// <exception cref="ArgumentException"></exception>
		public static MemoryStream ToMemoryStream(this string value, Encoding encoding)
		{
			byte[] data = value.GetBytes(encoding);
			MemoryStream memoryStream = data.ToMemoryStream();
			return memoryStream;
		}
	}
}
