namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation attribute that checks if the value end with the given value.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class EndsWithAttribute : ValidationAttribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="EndsWithAttribute" /> type.
		/// </summary>
		/// <param name="end"></param>
		/// <param name="stringComparison"></param>
		public EndsWithAttribute(string end, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
		{
			Guard.ThrowIfNullOrEmpty(end);

			this.End = end;
			this.StringComparison = stringComparison;
		}

		/// <summary>
		///     Gets the ending string to check for.
		/// </summary>
		public string End { get; }

		/// <summary>
		///     Gets the <see cref="StringComparison" /> to use.
		/// </summary>
		public StringComparison StringComparison { get; }

		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value is string stringValue)
			{
				bool endsWith = !string.IsNullOrWhiteSpace(stringValue) && stringValue.EndsWith(this.End, this.StringComparison);
				return endsWith;
			}

			throw new InvalidOperationException("The attribute can only be used with string properties.");
		}
	}
}
