namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class UncapitalizeTests : InflectorTestBase
    {
        [Test]
        public void Uncapitalize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Uncapitalize(), pair.Value);
            }
        }

        public UncapitalizeTests()
        {
            //Just lowers the first char and leaves the rest alone
            this.TestData.Add("some title", "some title");
            this.TestData.Add("some Title", "some Title");
            this.TestData.Add("SOMETITLE", "sOMETITLE");
            this.TestData.Add("someTitle", "someTitle");
            this.TestData.Add("some title goes here", "some title goes here");
            this.TestData.Add("some TITLE", "some TITLE");
        }
    }
}