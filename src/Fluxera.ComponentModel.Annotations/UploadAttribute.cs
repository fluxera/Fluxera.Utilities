// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///		A data-type attribute for upload values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class UploadAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public UploadAttribute() : base(DataType.Upload)
		{
		}
	}
}
