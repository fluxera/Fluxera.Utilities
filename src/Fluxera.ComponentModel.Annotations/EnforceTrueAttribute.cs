namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation attribute that checks if the value is <c>true</c>.
	/// </summary>
	/// <remarks>
	///     http://stackoverflow.com/questions/4730183/mvc-model-require-true/9036075#9036075
	/// </remarks>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class EnforceTrueAttribute : ValidationAttribute
	{
		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value == null)
			{
				return false;
			}

			if(value.GetType() != typeof(bool))
			{
				throw new InvalidOperationException("Can only be used on boolean properties.");
			}

			return (bool)value;
		}
	}
}
