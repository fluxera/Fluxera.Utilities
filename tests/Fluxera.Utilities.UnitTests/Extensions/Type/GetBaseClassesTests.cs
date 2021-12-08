namespace Fluxera.Utilities.UnitTests.Extensions.Type
{
	using System;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetBaseClassesTests
	{
		public abstract class MyBaseClass1 { }

		public class MyBaseClass2 : MyBaseClass1 { }

		public class MyClass : MyBaseClass2 { }

		[Test]
		public void ShouldGetBaseClasses()
		{
			Type[] baseClasses = typeof(MyClass).GetBaseClasses(false);

			baseClasses.Length.Should().Be(2);
			baseClasses[0].Should().Be(typeof(MyBaseClass1));
			baseClasses[1].Should().Be(typeof(MyBaseClass2));
		}
	}
}
