// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///     A data-type attribute to signal that the values comes from a selection of values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class SelectAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public SelectAttribute() : base("SelectEnum")
		{
		}

		/// <inheritdoc />
		public SelectAttribute(string optionsPropertyName) : base("Select")
		{
			this.OptionsPropertyName = optionsPropertyName;
		}

		/// <summary>
		///     The name of the property that contains the options for a selection.
		/// </summary>
		public string OptionsPropertyName { get; }

		/// <summary>
		///     Flag, indicating if a selection has an 'empty' option.
		/// </summary>
		public bool HasEmptyOption { get; set; } = true;
	}
}
