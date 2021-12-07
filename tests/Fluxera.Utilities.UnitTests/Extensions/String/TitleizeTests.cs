namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class TitleizeTests : InflectorTestBase
    {
        [Test]
        public void Titleize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Titleize(), pair.Value);
            }
        }

        public TitleizeTests()
        {
            //Uppercases individual words and removes some characters 
            this.TestData.Add("some title", "Some Title");
            this.TestData.Add("some-title", "Some Title");
            this.TestData.Add("sometitle", "Sometitle");
            this.TestData.Add("some-title: The begining", "Some Title: The Begining");
            this.TestData.Add("some_title:_the_begining", "Some Title: The Begining");
            this.TestData.Add("some title: The_begining", "Some Title: The Begining");
        }
    }
}