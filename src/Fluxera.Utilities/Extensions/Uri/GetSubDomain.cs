// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Text;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="Uri" /> type.
	/// </summary>
	[PublicAPI]
	public static class UriExtensions
	{
		/// <summary>
		///     Gets the sub-domain part from the given <see cref="Uri" />.
		/// </summary>
		/// <param name="uri"></param>
		/// <param name="option"></param>
		/// <returns></returns>
		public static string GetSubDomain(this Uri uri, GetSubDomainOption option = GetSubDomainOption.IncludeWWW)
		{
			StringBuilder stringBuilder = new StringBuilder();

			for(int i = 0; i < uri.Host.Split('.').Length - 2; i++)
			{
				// Ignore any 'www' values when ExcludeWWW option is set.
				if(option == GetSubDomainOption.ExcludeWWW &&
				   uri.Host.Split('.')[i].ToLowerInvariant() == "www")
				{
					continue;
				}

				string value;

				if(i < uri.Host.Split('.').Length - 3 && uri.Host.Split('.')[i + 1].ToLowerInvariant() != "www")
				{
					value = uri.Host.Split('.')[i] + ".";
				}
				else
				{
					value = uri.Host.Split('.')[i];
				}

				stringBuilder.Append(value);
			}

			// Build the sub-domain value.
			return stringBuilder.ToString();
		}
	}
}
