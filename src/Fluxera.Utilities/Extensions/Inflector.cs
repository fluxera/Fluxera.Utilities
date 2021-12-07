namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using System.Text.RegularExpressions;
	using JetBrains.Annotations;

	/// <summary>
	///		A utility class based on https://github.com/srkirkland/Inflector for manipulating text.
	/// </summary>
	/// <remarks>
	/// See: https://github.com/srkirkland/Inflector
	/// </remarks>
	[PublicAPI]
	internal static class Inflector
	{
		private static readonly List<Rule> plurals = new List<Rule>();
		private static readonly List<Rule> singulars = new List<Rule>();
		private static readonly List<string> uncountables = new List<string>();

		static Inflector()
		{
			// ReSharper disable StringLiteralTypo
			AddPlural("$", "s");
			AddPlural("s$", "s");
			AddPlural("(ax|test)is$", "$1es");
			AddPlural("(octop|vir|alumn|fung)us$", "$1i");
			AddPlural("(alias|status)$", "$1es");
			AddPlural("(bu)s$", "$1ses");
			AddPlural("(buffal|tomat|volcan)o$", "$1oes");
			AddPlural("([ti])um$", "$1a");
			AddPlural("sis$", "ses");
			AddPlural("(?:([^f])fe|([lr])f)$", "$1$2ves");
			AddPlural("(hive)$", "$1s");
			AddPlural("([^aeiouy]|qu)y$", "$1ies");
			AddPlural("(x|ch|ss|sh)$", "$1es");
			AddPlural("(matr|vert|ind)ix|ex$", "$1ices");
			AddPlural("([m|l])ouse$", "$1ice");
			AddPlural("^(ox)$", "$1en");
			AddPlural("(quiz)$", "$1zes");

			AddSingular("s$", "");
			AddSingular("(n)ews$", "$1ews");
			AddSingular("([ti])a$", "$1um");
			AddSingular("((a)naly|(b)a|(d)iagno|(p)arenthe|(p)rogno|(s)ynop|(t)he)ses$", "$1$2sis");
			AddSingular("(^analy)ses$", "$1sis");
			AddSingular("([^f])ves$", "$1fe");
			AddSingular("(hive)s$", "$1");
			AddSingular("(tive)s$", "$1");
			AddSingular("([lr])ves$", "$1f");
			AddSingular("([^aeiouy]|qu)ies$", "$1y");
			AddSingular("(s)eries$", "$1eries");
			AddSingular("(m)ovies$", "$1ovie");
			AddSingular("(x|ch|ss|sh)es$", "$1");
			AddSingular("([m|l])ice$", "$1ouse");
			AddSingular("(bus)es$", "$1");
			AddSingular("(o)es$", "$1");
			AddSingular("(shoe)s$", "$1");
			AddSingular("(cris|ax|test)es$", "$1is");
			AddSingular("(octop|vir|alumn|fung)i$", "$1us");
			AddSingular("(alias|status)es$", "$1");
			AddSingular("^(ox)en", "$1");
			AddSingular("(vert|ind)ices$", "$1ex");
			AddSingular("(matr)ices$", "$1ix");
			AddSingular("(quiz)zes$", "$1");

			AddIrregular("person", "people");
			AddIrregular("man", "men");
			AddIrregular("child", "children");
			AddIrregular("sex", "sexes");
			AddIrregular("move", "moves");
			AddIrregular("goose", "geese");
			AddIrregular("alumna", "alumnae");

			AddUncountable("equipment");
			AddUncountable("information");
			AddUncountable("rice");
			AddUncountable("money");
			AddUncountable("species");
			AddUncountable("series");
			AddUncountable("fish");
			AddUncountable("sheep");
			AddUncountable("deer");
			AddUncountable("aircraft");
			// ReSharper restore StringLiteralTypo
		}

		private static void AddIrregular(string singular, string plural)
		{
			AddPlural("(" + singular[0] + ")" + singular.Substring(1) + "$", "$1" + plural.Substring(1));
			AddSingular("(" + plural[0] + ")" + plural.Substring(1) + "$", "$1" + singular.Substring(1));
		}

		private static void AddUncountable(string word)
		{
			uncountables.Add(word.ToLower());
		}

		private static void AddPlural(string rule, string replacement)
		{
			plurals.Add(new Rule(rule, replacement));
		}

		private static void AddSingular(string rule, string replacement)
		{
			singulars.Add(new Rule(rule, replacement));
		}

		internal static string Pluralize(string word)
		{
			return ApplyRules(plurals, word);
		}

		internal static string Singularize(string word)
		{
			return ApplyRules(singulars, word);
		}

		private static string ApplyRules(IReadOnlyList<Rule> rules, string word)
		{
			string result = word;

			if (!uncountables.Contains(word.ToLower()))
			{
				for (int i = rules.Count - 1; i >= 0; i--)
				{
					if ((result = rules[i].Apply(word)) != null)
					{
						break;
					}
				}
			}

			return result;
		}

		internal static string Titleize(string word)
		{
			return Regex.Replace(Humanize(Underscore(word)), @"\b([a-z])",
				match => match.Captures[0].Value.ToUpper());
		}

		internal static string Humanize(string lowercaseAndUnderscoredWord)
		{
			return Capitalize(Regex.Replace(lowercaseAndUnderscoredWord, @"_", " "));
		}

		internal static string Pascalize(string lowercaseAndUnderscoredWord)
		{
			return Regex.Replace(lowercaseAndUnderscoredWord, "(?:^|_)(.)", match => match.Groups[1].Value.ToUpper());
		}

		internal static string Camelize(string lowercaseAndUnderscoredWord)
		{
			return Uncapitalize(Pascalize(lowercaseAndUnderscoredWord));
		}

		internal static string Underscore(string pascalCasedWord)
		{
			return Regex.Replace(
				Regex.Replace(
					Regex.Replace(pascalCasedWord, @"([A-Z]+)([A-Z][a-z])", "$1_$2"), @"([a-z\d])([A-Z])",
					"$1_$2"), @"[-\s]", "_").ToLower();
		}

		internal static string Capitalize(string word)
		{
			return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
		}

		internal static string Uncapitalize(string word)
		{
			return word.Substring(0, 1).ToLower() + word.Substring(1);
		}

		internal static string Ordinalize(string numberString)
		{
			return Ordanize(long.Parse(numberString), numberString);
		}

		internal static string Ordinalize(long number)
		{
			return Ordanize(number, number.ToString());
		}

		internal static string Ordinalize(ulong number)
		{
			return Ordanize(number, number.ToString());
		}

		private static string Ordanize(long number, string numberString)
		{
			return Ordanize((ulong)number, numberString);
		}

		private static string Ordanize(ulong number, string numberString)
		{
			ulong nMod100 = number % 100;

			if (nMod100 >= 11 && nMod100 <= 13)
			{
				return numberString + "th";
			}

			switch (number % 10)
			{
				case 1:
					return numberString + "st";
				case 2:
					return numberString + "nd";
				case 3:
					return numberString + "rd";
				default:
					return numberString + "th";
			}
		}

		internal static string Dasherize(string underscoredWord)
		{
			return underscoredWord.Replace('_', '-');
		}

		private class Rule
		{
			private readonly Regex regex;
			private readonly string replacement;

			public Rule(string pattern, string replacement)
			{
				this.regex = new Regex(pattern, RegexOptions.IgnoreCase);
				this.replacement = replacement;
			}

			public string Apply(string word)
			{
				if (!this.regex.IsMatch(word))
				{
					return null;
				}

				return this.regex.Replace(word, this.replacement);
			}
		}
	}
}
