namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     An attribute to signal potential data stores that this property should be stored as database reference.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class ReferenceAttribute<T> : ReferenceAttribute where T : class
	{
		/// <inheritdoc />
		public ReferenceAttribute() : base(typeof(T))
		{
		}
	}

	/// <summary>
	///     An attribute to signal potential data stores that this property should be stored as database reference.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ReferenceAttribute : Attribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="ReferenceAttribute" /> type.
		/// </summary>
		/// <param name="referencedEntityType"></param>
		public ReferenceAttribute(Type referencedEntityType)
		{
			Guard.Against.Null(referencedEntityType);

			this.ReferencedEntityName = referencedEntityType.Name;
		}

		/// <summary>
		///     Creates a new instance of the <see cref="ReferenceAttribute" /> type.
		/// </summary>
		/// <param name="referencedEntityName"></param>
		public ReferenceAttribute(string referencedEntityName)
		{
			Guard.Against.NullOrWhiteSpace(referencedEntityName);

			this.ReferencedEntityName = referencedEntityName;
		}

		/// <summary>
		///     Gets the name of the referenced entity.
		/// </summary>
		public string ReferencedEntityName { get; }

		/// <summary>
		///     Gets or sets the (optional) name of the storage (f.e. the name of a database or file).
		/// </summary>
		public string StorageName { get; set; }
	}
}
