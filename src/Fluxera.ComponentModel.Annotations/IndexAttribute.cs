namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     An attribute to provide an index of the entity. <br />
	///     To create the actual indices consult the underlying stores documentation.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class IndexAttribute : Attribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="IndexAttribute" /> type.
		/// </summary>
		public IndexAttribute()
		{
			this.IsUnique = false;
		}

		/// <summary>
		///     Flag, indicating that the index is unique.
		/// </summary>
		public bool IsUnique { get; set; }

		/// <summary>
		///     Gets the ordering for the index.
		/// </summary>
		public IndexOrder Order { get; set; } = IndexOrder.Ascending;
	}
}
