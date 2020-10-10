using InstaTool.DataAccess.DbModels;
using InstaTool.MainScripts.DriverHelpers;
using InstaTool.MainScripts.Strategies;
using InstaTool.UIApp.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaTool.UIApp.ScrapeUsersForms
{
    public partial class ScrapeUsersByMinFolMaxFol : Form
    {
        private InstagramAccount _accountInUse = null;
        private ICollection<ScrapedUser> _scrapedUsers = null;

        public ScrapeUsersByMinFolMaxFol(InstagramAccount accInUse)
        {
            InitializeComponent();

            _accountInUse = accInUse;
        }

        private void ScrapeUsersByMinFolMaxFol_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void minFollowersTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadScrapingResultsInListView(ICollection<ScrapedUser> list)
        {
            foreach (var acc in list)
            {
                ListViewItem lvi = new ListViewItem(acc.UserURL);
                listResultsOfScrapingListview.Items.Add(lvi);
            }
        }

        private void LoadLogsToListView()
        {
            string res = string.Empty;
            var df = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            var fi = df.GetFiles("*LogMessage_*");
            res = File.ReadAllText(fi.Last().FullName);
            var listOfLogs = res.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            foreach (var log in listOfLogs)
            {
                ListViewItem lvi = new ListViewItem(log);
                listOfLogsListview.Items.Add(lvi);
            }
        }
        
        private async void startScraper_Click(object sender, EventArgs e)
        {
            backToFeatures.Enabled = false;
            statusLabel.ForeColor = Color.Green;
            await Task.Factory.StartNew(() => StartScrape(SetFollowSpecs()));
            LoadLogsToListView();
            LoadScrapingResultsInListView(_scrapedUsers);
        }

        private FollowSpecifications SetFollowSpecs()
        {
            return new FollowSpecifications()
            {
                MinFollowers = int.Parse(minFollowersTextbox.Text),
                MaxFollowers = int.Parse(maxFollowersTextbox.Text),
                MinFollowing = int.Parse(minFollowingTextbox.Text),
                MaxFollowing = int.Parse(maxFollowingTextbox.Text),
            };
        }

        private void StartScrape(FollowSpecifications fSpecs)
        {
            if (UrlIsValid())
            {
                if (FollowersFollowingValuesAreCorrect())
                {
                    ThreadHelperClass.SetText(this, statusLabel, "Running...");
                    var ig = new InstaTool.MainScripts.InstagramPages.Login();
                    var homepage = ig.PerformLogin(_accountInUse.EmailPhone);
                    ThreadHelperClass.SetText(this, statusLabel, "Logged in...");
                    var userProfile = homepage.GoToUserProfile(instagramTargetUrl.Text, true);
                    ThreadHelperClass.SetText(this, statusLabel, "Started scraping...be patient");
                    _scrapedUsers = userProfile.ScrapeUsersByStrategy(1, new ScrapeByNumberOfFollowers(fSpecs));
                    ThreadHelperClass.SetText(this, statusLabel, "Scraping done!!");
                }
            }
        }

        public bool UrlIsValid()
        {
            return instagramTargetUrl.Text.Contains("https://www.instagram.com/");
        }

        public bool FollowersFollowingValuesAreCorrect()
        {
            int minFollowers = 0;
            int maxFollowings = 0;
            try
            {
                minFollowers = int.Parse(minFollowersTextbox.Text);
            }
            catch (Exception ex) { }

            try
            {
                maxFollowings = int.Parse(maxFollowingTextbox.Text);
            }
            catch (Exception ex) { }

            return minFollowers != 0 && maxFollowings != 0;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(openFileDialog1.FileName))
                {
                    foreach (var user in _scrapedUsers)
                    {
                        sw.WriteLine("Format: URL***DESCRIPTION***ISPRIVATE");
                        sw.WriteLine($"{ user.UserURL}***{user.Description}***{user.IsPrivate}");
                    }
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void backToInstaToolFeatures_Click(object sender, EventArgs e)
        {
            InstaToolFeatures itf = new InstaToolFeatures(_accountInUse);
            this.Hide();
            itf.Show();
        }

        private void statusLabel_click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
