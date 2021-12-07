// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Diagnostics;
	using System.Security.Claims;
	using Guards;

	public static partial class PrincipalExtensions
	{
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <param name="principal">The principal.</param>
		/// <returns></returns>
		[DebuggerStepThrough]
		public static string GetDisplayName(this ClaimsPrincipal principal)
		{
			Guard.Against.Null(principal, nameof(principal));

			string name = principal.Identity.Name;
			if(!string.IsNullOrWhiteSpace(name))
			{
				return name;
			}

			Claim sub = principal.FindFirst("sub");
			if (sub != null)
			{
				return sub.Value;
			}

			return string.Empty;
		}
	}
}
