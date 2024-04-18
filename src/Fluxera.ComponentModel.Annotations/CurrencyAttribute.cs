// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///		A data-type attribute for currency values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class CurrencyAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public CurrencyAttribute() : base(DataType.Currency)
		{
		}
	}
}
