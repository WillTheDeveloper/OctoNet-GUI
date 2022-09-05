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
            var activity = client.Activity.Events.GetAll().Result;
            foreach (var item in activity)
            {
                lb_github_feed.Items.Add(item.Repo.Name + " - " + item.Type);
            }
        }

        private void duringTransaction()
        {
            this.Text = "LOADING...";
            bttn_api_check.Enabled = false;
            bttn_authenticate.Enabled = false;
            bttn_followers.Enabled = false;
            bttn_following.Enabled = false;
            bttn_gists.Enabled = false;
            bttn_issues.Enabled = false;
            bttn_milestones.Enabled = false;
            bttn_profile.Enabled = false;
            bttn_pull_requests.Enabled = false;
            bttn_releases.Enabled = false;
            bttn_repositories.Enabled = false;
            bttn_users.Enabled = false;
        }

        private void completedTransaction()
        {
            this.Text = "Octonet GUI";
            bttn_api_check.Enabled = true;
            bttn_authenticate.Enabled = true;
            bttn_followers.Enabled = true;
            bttn_following.Enabled = true;
            bttn_gists.Enabled = true;
            bttn_issues.Enabled = true;
            bttn_milestones.Enabled = true;
            bttn_profile.Enabled = true;
            bttn_pull_requests.Enabled = true;
            bttn_releases.Enabled = true;
            bttn_repositories.Enabled = true;
            bttn_users.Enabled = true;
        }

        private void bttn_authenticate_Click(object sender, EventArgs e)
        {
            var a = new Authenticate();
            duringTransaction();
            a.Show();
            completedTransaction();
        }

        private void bttn_issues_Click(object sender, EventArgs e)
        {
            Form form = new Issues();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_repositories_Click(object sender, EventArgs e)
        {
            Form form = new Repositories();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_api_check_Click(object sender, EventArgs e)
        {
            Form form = new ApiStatus();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_profile_Click(object sender, EventArgs e)
        {
            Form form = new Profile();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_releases_Click(object sender, EventArgs e)
        {
            Form form = new Releases();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_milestones_Click(object sender, EventArgs e)
        {
            Form form = new Milestones();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_users_Click(object sender, EventArgs e)
        {
            Form form = new Users();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_gists_Click(object sender, EventArgs e)
        {
            Form form= new Gists();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void bttn_pull_requests_Click(object sender, EventArgs e)
        {
            Form form = new Pulls();
            duringTransaction();
            form.Show();
            completedTransaction();
        }

        private void lb_github_feed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
