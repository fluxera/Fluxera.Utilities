namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
    public class PluralizeTests : InflectorTestBase
    {
        [Test]
        public void Pluralize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Key.Pluralize(), pair.Value);
            }
        }

        [Test]
        public void Singularize()
        {
            foreach (KeyValuePair<string, string> pair in this.TestData)
            {
                Assert.AreEqual(pair.Value.Singularize(), pair.Key);
            }
        }

        public PluralizeTests()
        {
            this.TestData.Add("search", "searches");
            this.TestData.Add("switch", "switches");
            this.TestData.Add("fix", "fixes");
            this.TestData.Add("box", "boxes");
            this.TestData.Add("process", "processes");
            this.TestData.Add("address", "addresses");
            this.TestData.Add("case", "cases");
            this.TestData.Add("stack", "stacks");
            this.TestData.Add("wish", "wishes");
            this.TestData.Add("fish", "fish");

            this.TestData.Add("category", "categories");
            this.TestData.Add("query", "queries");
            this.TestData.Add("ability", "abilities");
            this.TestData.Add("agency", "agencies");
            this.TestData.Add("movie", "movies");

            this.TestData.Add("archive", "archives");

            this.TestData.Add("index", "indices");

            this.TestData.Add("wife", "wives");
            this.TestData.Add("safe", "saves");
            this.TestData.Add("half", "halves");

            this.TestData.Add("move", "moves");

            this.TestData.Add("salesperson", "salespeople");
            this.TestData.Add("person", "people");

            this.TestData.Add("spokesman", "spokesmen");
            this.TestData.Add("man", "men");
            this.TestData.Add("woman", "women");

            this.TestData.Add("basis", "bases");
            this.TestData.Add("diagnosis", "diagnoses");

            this.TestData.Add("datum", "data");
            this.TestData.Add("medium", "media");
            this.TestData.Add("analysis", "analyses");

            this.TestData.Add("node_child", "node_children");
            this.TestData.Add("child", "children");

            this.TestData.Add("experience", "experiences");
            this.TestData.Add("day", "days");

            this.TestData.Add("comment", "comments");
            this.TestData.Add("foobar", "foobars");
            this.TestData.Add("newsletter", "newsletters");

            this.TestData.Add("old_news", "old_news");
            this.TestData.Add("news", "news");

            this.TestData.Add("series", "series");
            this.TestData.Add("species", "species");

            this.TestData.Add("quiz", "quizzes");

            this.TestData.Add("perspective", "perspectives");

            this.TestData.Add("ox", "oxen");
            this.TestData.Add("photo", "photos");
            this.TestData.Add("buffalo", "buffaloes");
            this.TestData.Add("tomato", "tomatoes");
            this.TestData.Add("dwarf", "dwarves");
            this.TestData.Add("elf", "elves");
            this.TestData.Add("information", "information");
            this.TestData.Add("equipment", "equipment");
            this.TestData.Add("bus", "buses");
            this.TestData.Add("status", "statuses");
            this.TestData.Add("status_code", "status_codes");
            this.TestData.Add("mouse", "mice");

            this.TestData.Add("louse", "lice");
            this.TestData.Add("house", "houses");
            this.TestData.Add("octopus", "octopi");
            this.TestData.Add("virus", "viri");
            this.TestData.Add("alias", "aliases");
            this.TestData.Add("portfolio", "portfolios");

            this.TestData.Add("vertex", "vertices");
            this.TestData.Add("matrix", "matrices");

            this.TestData.Add("axis", "axes");
            this.TestData.Add("testis", "testes");
            this.TestData.Add("crisis", "crises");

            this.TestData.Add("rice", "rice");
            this.TestData.Add("shoe", "shoes");

            this.TestData.Add("horse", "horses");
            this.TestData.Add("prize", "prizes");
            this.TestData.Add("edge", "edges");

            /* Tests added by Bas Jansen */
            this.TestData.Add("goose", "geese");
            this.TestData.Add("deer", "deer");
            this.TestData.Add("sheep", "sheep");
            this.TestData.Add("wolf", "wolves");
            this.TestData.Add("volcano", "volcanoes");
            this.TestData.Add("aircraft", "aircraft");
            this.TestData.Add("alumna", "alumnae");
            this.TestData.Add("alumnus", "alumni");
            this.TestData.Add("fungus", "fungi");
        }
    }
}
