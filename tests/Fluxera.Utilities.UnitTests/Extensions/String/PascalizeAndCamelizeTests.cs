namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class PascalizeAndCamelizeTests : InflectorTestBase
    {
        [Test]
        public void Pascalize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Pascalize(), pair.Value);
            }
        }

        /// <summary>
        /// Same as pascalize, except first char is lowercase
        /// </summary>
        [Test]
        public void Camelize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                string lowercaseFirstChar = pair.Value.Substring(0, 1).ToLower() + pair.Value.Substring(1);
                Assert.AreEqual(pair.Key.Camelize(), lowercaseFirstChar);
            }
        }

        public PascalizeAndCamelizeTests()
        {
            this.TestData.Add("customer", "Customer");
            this.TestData.Add("CUSTOMER", "CUSTOMER");
            this.TestData.Add("CUStomer", "CUStomer");
            this.TestData.Add("customer_name", "CustomerName");
            this.TestData.Add("customer_first_name", "CustomerFirstName");
            this.TestData.Add("customer_first_name_goes_here", "CustomerFirstNameGoesHere");
            this.TestData.Add("customer name", "Customer name");
        }
    }
}