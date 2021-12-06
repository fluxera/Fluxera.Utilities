namespace Fluxera.Utilities
{
	using System.IO;
	using JetBrains.Annotations;

	/// <summary>
	///     A helper class for temporary files and folders.
	/// </summary>
	[PublicAPI]
	public static class TempPathHelper
	{
		/// <summary>
		///     Try to create a temp file up to ten times until failure.
		/// </summary>
		/// <param name="extension">The desired file extension. The default is <c>tmp</c>.</param>
		/// <exception cref="IOException">When no file could be created after ten attempts.</exception>
		/// <returns>The path of the temp file.</returns>
		public static string CreateTempFile(string extension = "tmp")
		{
			int attempt = 0;
			while(true)
			{
				string fileName = Path.GetRandomFileName();
				fileName = Path.ChangeExtension(fileName, $".{extension.Trim().TrimStart('.')}");
				fileName = Path.Combine(Path.GetTempPath(), fileName);

				try
				{
					using FileStream fileStream = new FileStream(fileName, FileMode.CreateNew);
					return fileName;
				}
				catch(IOException ex)
				{
					if(++attempt == 10)
					{
						throw new IOException("No unique temporary file name is available.", ex);
					}
				}
			}
		}

		/// <summary>
		///     Try to create a temp folger up to ten times until failure.
		/// </summary>
		/// <exception cref="IOException">When no file could be created after ten attempts.</exception>
		/// <returns>The path of the temp folger.</returns>
		public static string CreateTempFolder()
		{
			int attempt = 0;
			while(true)
			{
				string fileName = Path.GetRandomFileName();
				fileName = Path.Combine(Path.GetTempPath(), fileName);

				try
				{
					Directory.CreateDirectory(fileName);

					return fileName;
				}
				catch(IOException ex)
				{
					if(++attempt == 10)
					{
						throw new IOException("No unique temporary directory name is available.", ex);
					}
				}
			}
		}
	}
}
