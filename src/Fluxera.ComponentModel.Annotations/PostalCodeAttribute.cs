// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///		A data-type attribute for postal code values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class PostalCodeAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public PostalCodeAttribute() : base(DataType.PostalCode)
		{
		}
	}
}
