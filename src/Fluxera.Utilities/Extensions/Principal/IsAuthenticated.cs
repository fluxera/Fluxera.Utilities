// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Diagnostics;
	using System.Security.Principal;
	using Guards;

	public static partial class PrincipalExtensions
	{
		/// <summary>
		///     Determines whether this principal is authenticated.
		/// </summary>
		/// <param name="principal">The principal.</param>
		/// <returns><c>true</c> if the specified principal is authenticated; otherwise, <c>false</c>.</returns>
		[DebuggerStepThrough]
		public static bool IsAuthenticated(this IPrincipal principal)
		{
			Guard.Against.Null(principal, nameof(principal));

			return (principal.Identity != null) && principal.Identity.IsAuthenticated;
		}
	}
}
