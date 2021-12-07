namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class OrdinalizeTests : InflectorTestBase
    {
        [Test]
        public void Ordinalize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Ordinalize(), pair.Value);
            }
        }

        [TestCase(0, "0th")]
        [TestCase(1, "1st")]
        [TestCase(2, "2nd")]
        [TestCase(3, "3rd")]
        [TestCase(4, "4th")]
        [TestCase(5, "5th")]
        [TestCase(6, "6th")]
        [TestCase(7, "7th")]
        [TestCase(8, "8th")]
        [TestCase(9, "9th")]
        [TestCase(10, "10th")]
        [TestCase(11, "11th")]
        [TestCase(12, "12th")]
        [TestCase(13, "13th")]
        [TestCase(14, "14th")]
        [TestCase(20, "20th")]
        [TestCase(21, "21st")]
        [TestCase(22, "22nd")]
        [TestCase(23, "23rd")]
        [TestCase(24, "24th")]
        [TestCase(100, "100th")]
        [TestCase(101, "101st")]
        [TestCase(102, "102nd")]
        [TestCase(103, "103rd")]
        [TestCase(104, "104th")]
        [TestCase(110, "110th")]
        [TestCase(1000, "1000th")]
        [TestCase(1001, "1001st")]
        public void OrdanizeNumbersTest(int number, string ordanized)
        {
            Assert.AreEqual(number.Ordinalize(), ordanized);
        }

        public OrdinalizeTests()
        {
            this.TestData.Add("0", "0th");
            this.TestData.Add("1", "1st");
            this.TestData.Add("2", "2nd");
            this.TestData.Add("3", "3rd");
            this.TestData.Add("4", "4th");
            this.TestData.Add("5", "5th");
            this.TestData.Add("6", "6th");
            this.TestData.Add("7", "7th");
            this.TestData.Add("8", "8th");
            this.TestData.Add("9", "9th");
            this.TestData.Add("10", "10th");
            this.TestData.Add("11", "11th");
            this.TestData.Add("12", "12th");
            this.TestData.Add("13", "13th");
            this.TestData.Add("14", "14th");
            this.TestData.Add("20", "20th");
            this.TestData.Add("21", "21st");
            this.TestData.Add("22", "22nd");
            this.TestData.Add("23", "23rd");
            this.TestData.Add("24", "24th");
            this.TestData.Add("100", "100th");
            this.TestData.Add("101", "101st");
            this.TestData.Add("102", "102nd");
            this.TestData.Add("103", "103rd");
            this.TestData.Add("104", "104th");
            this.TestData.Add("110", "110th");
            this.TestData.Add("1000", "1000th");
            this.TestData.Add("1001", "1001st");
        }
    }
}