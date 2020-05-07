using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleRSS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetRSS();
        }

        string rssLink = "https://www.wired.com/feed/category/science/latest/rss";

        private void GetRSS()
        {
            BuildRSS RN = new BuildRSS(rssLink);
            RN.GenerateRSS();
            foreach (string title in BuildRSS.titles)
            {
                rssList.Items.Add(title);
            }
        }

        private void rssList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            e.Graphics.DrawLine(Pens.Black, e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom);
        }

        private void rssList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = rssList.FocusedItem.Index;
            TxtSummary.Text = "Title: " + BuildRSS.titles[i] + Environment.NewLine;
            TxtSummary.Text += Environment.NewLine + "Summary: " + BuildRSS.summaries[i] + Environment.NewLine;
            TxtSummary.Text += Environment.NewLine + "Published: " + BuildRSS.published[i] + Environment.NewLine;
            TxtSummary.Text += Environment.NewLine + "ID: " + BuildRSS.id[i];
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            GetRSS();
        }
    }
}