namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation that checks if the annotated property contains the given check value.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class ContainsAttribute : ValidationAttribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="ContainsAttribute" /> type.
		/// </summary>
		/// <param name="part"></param>
		public ContainsAttribute(string part)
		{
			Guard.ThrowIfNull(part);

			this.Part = part;
		}

		/// <summary>
		///     Gets the string that should be contained in the property value.
		/// </summary>
		public string Part { get; }


		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value is string stringValue)
			{
				bool contains = !string.IsNullOrWhiteSpace(stringValue) && stringValue.Contains(this.Part);
				return contains;
			}

			throw new InvalidOperationException("The attribute can only be used with string properties.");
		}
	}
}
