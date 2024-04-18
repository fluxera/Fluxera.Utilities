namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     An attribute to provide the composite indices of an entity. <br />
	///     To create the actual indices consult the underlying stores documentation.
	/// </summary>
	/// <seealso cref="Attribute" />
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class CompositeIndexAttribute : Attribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="CompositeIndexAttribute" /> type.
		/// </summary>
		/// <param name="propertyNames"></param>
		public CompositeIndexAttribute(params string[] propertyNames)
		{
			this.PropertyNames = propertyNames;
			this.IsUnique = false;
		}

		/// <summary>
		///     Gets the property names for the index.
		/// </summary>
		public string[] PropertyNames { get; }

		/// <summary>
		///     Flag, indicating if the index is unique.
		/// </summary>
		public bool IsUnique { get; set; }

		/// <summary>
		///     Gets the ordering for the index.
		/// </summary>
		public IndexOrder Order { get; set; } = IndexOrder.Ascending;
	}
}
