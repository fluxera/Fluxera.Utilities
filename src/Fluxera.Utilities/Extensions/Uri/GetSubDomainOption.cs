// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using JetBrains.Annotations;

	/// <summary>
	///     Options for the sub-domain retrieval.
	/// </summary>
	[PublicAPI]
	public enum GetSubDomainOption
	{
		/// <summary>
		///     Exclude the www part.
		/// </summary>
		ExcludeWWW,

		/// <summary>
		///     Include the www part.
		/// </summary>
		IncludeWWW
	}
}
