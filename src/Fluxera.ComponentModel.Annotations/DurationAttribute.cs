// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///		A data-type attribute for duration (timespan) values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class DurationAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public DurationAttribute() : base(DataType.Duration)
		{
		}
	}
}
