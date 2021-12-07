namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class TypeExtensionsTests
	{
		//[Test]
		//public void Should_Generic_Type_From_Nullable()
		//{
		//    var nullableType = typeof(Guid?);
		//    var guidType = nullableType.GetFirstGenericArgumentIfNullable();

		//    guidType.ShouldBe(typeof(Guid));
		//}

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
