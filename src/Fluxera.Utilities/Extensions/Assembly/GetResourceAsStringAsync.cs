﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.IO;
	using System.Reflection;
	using System.Threading.Tasks;
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class AssemblyExtensions
	{
		/// <summary>
		///     Gets the content of the given resource location as string.
		/// </summary>
		/// <param name="assembly">The assembly to use.</param>
		/// <param name="resourceLocation">The location of the resource.</param>
		/// <returns>The content of the resource.</returns>
		public static async Task<string> GetResourceAsStringAsync(this Assembly assembly, string resourceLocation)
		{
			Guard.Against.Null(assembly, nameof(assembly));

			string result = string.Empty;

			await using (Stream stream = assembly.GetManifestResourceStream(resourceLocation))
			{
				if (stream != null && stream.CanRead)
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						result = await reader.ReadToEndAsync();
					}
				}
			}

			return result;
		}
	}
}
