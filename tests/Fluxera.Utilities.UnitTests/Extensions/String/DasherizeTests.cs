namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class DasherizeTests : InflectorTestBase
    {
        [Test]
        public void Dasherize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Dasherize(), pair.Value);
            }
        }

        public DasherizeTests()
        {
            //Just replaces underscore with a dash
            this.TestData.Add("some_title", "some-title");
            this.TestData.Add("some-title", "some-title");
            this.TestData.Add("some_title_goes_here", "some-title-goes-here");
            this.TestData.Add("some_title and_another", "some-title and-another");
        }
    }
}