// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.IO;
	using System.Reflection;
	using System.Threading.Tasks;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="Assembly" /> type.
	/// </summary>
	[PublicAPI]
	public static class AssemblyExtensions
	{
		/// <summary>
		///     Gets the content of the given embedded resource location as string.
		/// </summary>
		/// <param name="assembly">The assembly to use.</param>
		/// <param name="resourceLocation">The location of the resource.</param>
		/// <returns>The content of the resource.</returns>
		public static async Task<string> GetResourceAsStringAsync(this Assembly assembly, string resourceLocation)
		{
			Guard.ThrowIfNull(assembly);

			string result = string.Empty;

			await using(Stream stream = assembly.GetManifestResourceStream(resourceLocation))
			{
				if(stream != null && stream.CanRead)
				{
					using(StreamReader reader = new StreamReader(stream))
					{
						result = await reader.ReadToEndAsync();
					}
				}
			}

			return result;
		}
	}
}
