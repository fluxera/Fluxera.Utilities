namespace Fluxera.ComponentModel.Annotations.UnitTests
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class StartsWithAttributeTests
	{
		[Test]
		public void ShouldHaveValidationError()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				StartsWithString = "Welt, Hallo!"
			};

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeFalse();
			results.Count.Should().Be(1);
		}

		[Test]
		public void ShouldNotHaveValidationError()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				StartsWithString = "Hallo!"
			};

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeTrue();
			results.Count.Should().Be(0);
		}
	}
}
