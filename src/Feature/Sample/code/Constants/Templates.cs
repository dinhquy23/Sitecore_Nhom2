using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockProject.Feature.Sample.Constants
{
    public class Templates
    {
		public static class Advertisement
		{
			public const string TemplateId = "{A7965570-0D13-45B9-8EB2-02581041E97A}";
			public static class Fields
			{
				public const string Items = "{D649033A-D715-4A14-9179-C44EA17EF6B3}";
				public const string Time = "{EEE0E408-4FDD-4E0F-A1B5-9ADF7D3C2822}";
			}

		}
		public static class AdvertisementImage
		{
			public const string TemplateId = "{67EB969F-9865-4E12-9AE6-726D8DD7F0A2}";
			public static class Fields
			{
				public const string Image = "{00DA2E82-BC53-4F41-B633-F9E5A2F1F48A}";
				public const string Link = "{AA235530-DF44-45A9-87F7-FB6154126EA6}";
			}

		}


		public static class Header
		{
			public const string TemplateId = "{8DA0D35F-FE1E-4387-B8BD-44BEF6C85D31}";
			public static class Fields
			{
				public const string Logo = "{86CACD96-629D-4B59-884D-BC5262B4B27A}";
				public const string NameNavigation = "{D36544C7-EC3E-4427-8EC0-DEA4C1BF3687}";
				public const string Date = "{E5743A7E-2326-4BF6-8F10-B621054D5821}";
				public const string Link = "{F4887AA1-773D-4990-A684-E33CB335C81C}";
			}

		}
		public static class HeaderNavigation
		{
			public const string TemplateId = "{6D650215-5866-40CD-99AC-CE2194198EAC}";
			public static class Fields
			{
				public const string Title = "{472F2ABB-7667-4AF1-9F08-2DC726DF54CA}";
				public const string Link = "{DEA7FB83-2C8F-4233-A67C-952A76D4D874}";
			}

		}

		public static class Navigation
		{
			public const string TemplateId = "{9865B897-A8B0-481B-9794-F7F6FA62A379}";
			public static class Fields
			{
				public const string Items = "{6E522CB6-DF6E-484C-ABF5-47E4B78B013E}";
			}

		}

	}
}