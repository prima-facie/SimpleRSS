using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace SimpleRSS
{
    class BuildRSS
    {
        private string rssLink;
        public static List<string> summaries = new List<string>();
        public static List<string> titles = new List<string>();
        public static List<string> published = new List<string>();
        public static List<string> id = new List<string>();
        Rss20FeedFormatter rssFormatter;

        public BuildRSS(string rssLink)
        {
            this.rssLink = rssLink;
        }

        public void GenerateRSS()
        {
            try
            {
                using (var xmlReader = XmlReader.Create(rssLink))
                {
                    rssFormatter = new Rss20FeedFormatter();
                    rssFormatter.ReadFrom(xmlReader);
                }

                foreach (var item in rssFormatter.Feed.Items)
                {
                    titles.Add(item.Title.Text);
                    summaries.Add(item.Summary.Text);
                    published.Add(item.PublishDate.DateTime.ToString());
                    id.Add(item.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured (Please check your internet connection). " +  ex.Message);
            }
        }
    }
}