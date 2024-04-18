namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation attribute that checks if the value starts with the given value.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class StartsWithAttribute : ValidationAttribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="StartsWithAttribute" /> type.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="stringComparison"></param>
		public StartsWithAttribute(string start, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
		{
			Guard.Against.NullOrEmpty(start, nameof(start));

			this.Start = start;
			this.StringComparison = stringComparison;
		}

		/// <summary>
		///     Gets the starting string to check for.
		/// </summary>
		public string Start { get; }

		/// <summary>
		///     Gets the <see cref="StringComparison" /> to use.
		/// </summary>
		public StringComparison StringComparison { get; }

		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value is string stringValue)
			{
				bool startsWith = !string.IsNullOrWhiteSpace(stringValue) &&
					stringValue.StartsWith(this.Start, this.StringComparison);
				return startsWith;
			}

			throw new InvalidOperationException("The attribute can only be used with string properties.");
		}
	}
}
