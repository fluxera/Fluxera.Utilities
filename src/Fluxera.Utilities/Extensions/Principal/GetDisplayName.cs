// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Diagnostics;
	using System.Security.Claims;
	using Fluxera.Guards;

	/// <summary>
	///     Extension methods for the <see cref="ClaimsPrincipal" /> type.
	/// </summary>
	public static partial class PrincipalExtensions
	{
		/// <summary>
		///     Gets the display name from the <see cref="ClaimsIdentity" /> or uses the subject.
		/// </summary>
		/// <param name="principal">The principal.</param>
		/// <returns>The display name.</returns>
		[DebuggerStepThrough]
		public static string GetDisplayName(this ClaimsPrincipal principal)
		{
			principal = Guard.Against.Null(principal);

			string name = principal.Identity?.Name;
			if(!string.IsNullOrWhiteSpace(name))
			{
				return name;
			}

			Claim sub = principal.FindFirst("sub");
			return sub is not null ? sub.Value : string.Empty;
		}
	}
}
