// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///		A data-type attribute for password values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class PasswordAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public PasswordAttribute() : base(DataType.Password)
		{
		}
	}
}
