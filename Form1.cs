using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace OctoNet_GUI
{
    public partial class Form1 : Form
    {
        public static string auth;
        public static GitHubClient client = new GitHubClient(new ProductHeaderValue("Octonet-Gui"));
        public static User user;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*//Get a list from the feed
            var feed = new Feed();
            var list = feed;
            //Add the list to the listbox
            foreach (var item in list.TimelineUrl)
            {
                lb_github_feed.Items.Add(item);
            }*/
        }

        private void bttn_authenticate_Click(object sender, EventArgs e)
        {
            var a = new Authenticate();
            a.Show();
        }

        private void bttn_issues_Click(object sender, EventArgs e)
        {
            Form form = new Issues();
            form.Show();
        }

        private void bttn_repositories_Click(object sender, EventArgs e)
        {
            Form form = new Repositories();
            form.Show();
        }

        private void bttn_api_check_Click(object sender, EventArgs e)
        {
            Form form = new ApiStatus();
            form.Show();
        }

        private void bttn_profile_Click(object sender, EventArgs e)
        {
            Form form = new Profile();
            form.Show();
        }

        private void bttn_releases_Click(object sender, EventArgs e)
        {
            Form form = new Releases();
            form.Show();
        }

        private void bttn_milestones_Click(object sender, EventArgs e)
        {
            Form form = new Milestones();
            form.Show();
        }

        private void bttn_users_Click(object sender, EventArgs e)
        {
            Form form = new Users();
            form.Show();
        }

        private void bttn_gists_Click(object sender, EventArgs e)
        {
            Form form= new Gists();
            form.Show();
        }

        private void bttn_pull_requests_Click(object sender, EventArgs e)
        {
            Form form = new Pulls();
            form.Show();
        }
    }
}
