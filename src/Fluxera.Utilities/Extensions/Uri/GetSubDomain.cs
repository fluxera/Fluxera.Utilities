// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Text;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class UriExtensions
	{
		public static string GetSubDomain(this Uri uri,
			GetSubDomainOption getSubDomainOption = GetSubDomainOption.IncludeWWW)
		{
			StringBuilder stringBuilder = new StringBuilder();

			for (int i = 0; i < uri.Host.Split('.').Length - 2; i++)
			{
				// Ignore any www values of ExcludeWWW option is set.
				if (getSubDomainOption == GetSubDomainOption.ExcludeWWW &&
					uri.Host.Split('.')[i].ToLowerInvariant() == "www")
				{
					continue;
				}

				string value;

				if (i < uri.Host.Split('.').Length - 3 && uri.Host.Split('.')[i + 1].ToLowerInvariant() != "www")
				{
					value = uri.Host.Split('.')[i] + ".";
				}
				else
				{
					value = uri.Host.Split('.')[i];
				}

				stringBuilder.Append(value);
			}

			return stringBuilder.ToString(); // Return the sub-domain.
		}
	}
}
