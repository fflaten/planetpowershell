using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class FrodeFlaten : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Frode";
		public string LastName => "Flaten";
		public string Pronouns => "he/him";
		public string ShortBioOrTagLine => "PowerShell enthusiast";
		public string StateOrRegion => "Norway";
		public string EmailAddress => string.Empty;
		public string MastodonHandle => string.Empty;
		public string TwitterHandle => "FrodeFlaten";
		public string GravatarHash => "a80e998ecae75c00c97b1d94feb5157c72defe951e19901f950dcf30fae0fe69";
		public string GitHubHandle => "fflaten";
		public GeoPosition Position => new GeoPosition(59.917071, 10.727401);
		public Uri WebSite => new Uri("https://frodeflaten.com/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://frodeflaten.com/rss.xml"); } }
		public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item)
		{
			return item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("powershell")) ?? false;
		}
	}
}