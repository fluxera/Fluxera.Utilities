namespace Fluxera.Utilities.UnitTests.Extensions.DateTime
{
	using System.Globalization;
	using NUnit.Framework;

	[TestFixture]
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}
	}
}