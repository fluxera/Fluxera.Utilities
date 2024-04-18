namespace Fluxera.ComponentModel.Annotations.UnitTests
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class AttributeTests
	{
		[Test]
		public void ShouldNotHaveValidationError()
		{
			// Arrange
			TestClass obj = new TestClass();

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeTrue();
			results.Count.Should().Be(0);
		}
	}
}
