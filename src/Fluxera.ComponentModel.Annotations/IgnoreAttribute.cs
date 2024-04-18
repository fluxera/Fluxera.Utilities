namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///		A marker attribute to signal potential data stores to ignore this value.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class IgnoreAttribute : Attribute
	{
	}
}
