namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class UnderscoreTests : InflectorTestBase
    {
        [Test]
        public void Underscore()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Underscore(), pair.Value);
            }
        }

        public UnderscoreTests()
        {
            //Makes an underscored lowercase string
            this.TestData.Add("SomeTitle", "some_title");
            this.TestData.Add("someTitle", "some_title");
            this.TestData.Add("some title", "some_title");
            this.TestData.Add("some title that will be underscored", "some_title_that_will_be_underscored");
            this.TestData.Add("SomeTitleThatWillBeUnderscored", "some_title_that_will_be_underscored");
        }
    }
}