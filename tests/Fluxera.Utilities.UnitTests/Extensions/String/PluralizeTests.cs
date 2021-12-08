namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	/// <summary>
	///		See: https://github.com/srkirkland/Inflector
	/// </summary>
	[TestFixture]
	public class PluralizeTests
	{
		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldPluralize(string input, string expected)
		{
			string result = input.Pluralize();
			result.Should().Be(expected);
		}

		[Test]
		public void ShouldPluralize()
		{
			// Arrange
			string str = "person";

			// Act
			string result = str.Pluralize();

			// Assert
			result.Should().Be("people");
		}

		public static IEnumerable<string[]> TestData = new List<string[]>
		{
			new string[] {"search", "searches"},
			new string[] {"switch", "switches"},
			new string[] {"fix", "fixes"},
			new string[] {"box", "boxes"},
			new string[] {"process", "processes"},
			new string[] {"address", "addresses"},
			new string[] {"case", "cases"},
			new string[] {"stack", "stacks"},
			new string[] {"wish", "wishes"},
			new string[] {"fish", "fish"},

			new string[] {"category", "categories"},
			new string[] {"query", "queries"},
			new string[] {"ability", "abilities"},
			new string[] {"agency", "agencies"},
			new string[] {"movie", "movies"},

			new string[] {"archive", "archives"},

			new string[] {"index", "indices"},

			new string[] {"wife", "wives"},
			new string[] {"safe", "saves"},
			new string[] {"half", "halves"},

			new string[] {"move", "moves"},

			new string[] {"salesperson", "salespeople"},
			new string[] {"person", "people"},

			new string[] {"spokesman", "spokesmen"},
			new string[] {"man", "men"},
			new string[] {"woman", "women"},

			new string[] {"basis", "bases"},
			new string[] {"diagnosis", "diagnoses"},

			new string[] {"datum", "data"},
			new string[] {"medium", "media"},
			new string[] {"analysis", "analyses"},

			new string[] {"node_child", "node_children"},
			new string[] {"child", "children"},

			new string[] {"experience", "experiences"},
			new string[] {"day", "days"},

			new string[] {"comment", "comments"},
			new string[] {"foobar", "foobars"},
			new string[] {"newsletter", "newsletters"},

			new string[] {"old_news", "old_news"},
			new string[] {"news", "news"},

			new string[] {"series", "series"},
			new string[] {"species", "species"},

			new string[] {"quiz", "quizzes"},

			new string[] {"perspective", "perspectives"},

			new string[] {"ox", "oxen"},
			new string[] {"photo", "photos"},
			new string[] {"buffalo", "buffaloes"},
			new string[] {"tomato", "tomatoes"},
			new string[] {"dwarf", "dwarves"},
			new string[] {"elf", "elves"},
			new string[] {"information", "information"},
			new string[] {"equipment", "equipment"},
			new string[] {"bus", "buses"},
			new string[] {"status", "statuses"},
			new string[] {"status_code", "status_codes"},
			new string[] {"mouse", "mice"},

			new string[] {"louse", "lice"},
			new string[] {"house", "houses"},
			new string[] {"octopus", "octopi"},
			new string[] {"virus", "viri"},
			new string[] {"alias", "aliases"},
			new string[] {"portfolio", "portfolios"},

			new string[] {"vertex", "vertices"},
			new string[] {"matrix", "matrices"},

			new string[] {"axis", "axes"},
			new string[] {"testis", "testes"},
			new string[] {"crisis", "crises"},

			new string[] {"rice", "rice"},
			new string[] {"shoe", "shoes"},

			new string[] {"horse", "horses"},
			new string[] {"prize", "prizes"},
			new string[] {"edge", "edges"},

			/* Tests added by Bas Jansen */
			new string[] {"goose", "geese"},
			new string[] {"deer", "deer"},
			new string[] {"sheep", "sheep"},
			new string[] {"wolf", "wolves"},
			new string[] {"volcano", "volcanoes"},
			new string[] {"aircraft", "aircraft"},
			new string[] {"alumna", "alumnae"},
			new string[] {"alumnus", "alumni"},
			new string[] {"fungus", "fungi"},
		};
	}
}
