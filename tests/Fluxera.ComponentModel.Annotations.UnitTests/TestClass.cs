namespace Fluxera.ComponentModel.Annotations.UnitTests
{
	using System.Collections.Generic;

	public class TestClass
	{
		public TestClass()
		{
			// Set valid values.
			this.EnforceTrueBoolean = true;

			this.ListLengthMaxList = new List<object>();
			for(int i = 0; i < 5; i++)
			{
				this.ListLengthMaxList.Add(new object());
			}

			this.ListLengthMinMaxList = new List<object>();
			for(int i = 0; i < 5; i++)
			{
				this.ListLengthMinMaxList.Add(new object());
			}

			this.ListMaxLengthList = new List<object>();
			for(int i = 0; i < 5; i++)
			{
				this.ListMaxLengthList.Add(new object());
			}

			this.ListMinLengthList = new List<object>();
			for(int i = 0; i < 5; i++)
			{
				this.ListMinLengthList.Add(new object());
			}

			this.NotEmptyList = new List<object>();
			for(int i = 0; i < 5; i++)
			{
				this.NotEmptyList.Add(new object());
			}

			this.RequiredIfBoolean = true;
			this.RequiredIfBooleanString = "Hallo";

			this.RequiredIfEnum = TestEnum.One;
			this.RequiredIfEnumString = "Hallo";

			this.StartsWithString = "Hallo Welt!";

			this.EndsWithString = "Hallo Welt!";

			this.ContainsString = "Hallo, Welt!";
		}

		[EnforceTrue]
		public bool EnforceTrueBoolean { get; set; }

		[ListLength(10)]
		public IList<object> ListLengthMaxList { get; set; }

		[ListLength(10, MinimumLength = 2)]
		public IList<object> ListLengthMinMaxList { get; set; }

		[ListMaxLength(10)]
		public IList<object> ListMaxLengthList { get; set; }

		[ListMinLength(2)]
		public IList<object> ListMinLengthList { get; set; }

		[NotEmpty]
		public IList<object> NotEmptyList { get; set; }

		[RequiredIf(nameof(RequiredIfBoolean), true)]
		public string RequiredIfBooleanString { get; set; }

		public bool RequiredIfBoolean { get; set; }

		[RequiredIf(nameof(RequiredIfEnum), TestEnum.One, TestEnum.Three)]
		public string RequiredIfEnumString { get; set; }

		public TestEnum RequiredIfEnum { get; set; }

		[StartsWith("Hallo")]
		public string StartsWithString { get; set; }

		[EndsWith("Welt!")]
		public string EndsWithString { get; set; }

		[Contains(",")]
		public string ContainsString { get; set; }
	}
}
