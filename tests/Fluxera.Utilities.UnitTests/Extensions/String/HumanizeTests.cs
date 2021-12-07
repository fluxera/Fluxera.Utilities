namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class HumanizeTests : InflectorTestBase
    {
        [Test]
        public void Humanize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Humanize(), pair.Value);
            }
        }

        public HumanizeTests()
        {
            //Capitalizes the first word, lowercases the rest and turns underscores into spaces
            this.TestData.Add("some_title", "Some title");
            this.TestData.Add("some-title", "Some-title");
            this.TestData.Add("Some_title", "Some title");
            this.TestData.Add("someTitle", "Sometitle");
            this.TestData.Add("someTitle_Another", "Sometitle another");
        }
    }
}