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
    public partial class Releases : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Releases()
        {
            InitializeComponent();
        }

        private void lb_repositories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = lb_repositories.SelectedItem.ToString();
            var selectedRepo = client.Repository.GetAllForCurrent().Result.Where(x => x.Name == selected).First();


            //Check if something has been selected
            if (lb_repositories.SelectedItem != null)
            {
                //Get the releases of the selected repository
                var releases = client.Repository.Release.GetAll(selectedRepo.Owner.Login, selectedRepo.Name).Result;
                //Clear the listbox
                lb_releases.Items.Clear();
                //Add the releases to the listbox
                foreach (var release in releases)
                {
                    lb_releases.Items.Add(release.TagName.ToString());
                }
            }
        }

        private void lb_releases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Releases_Load(object sender, EventArgs e)
        {
            foreach (var repo in client.Repository.GetAllForCurrent().Result)
            {
                lb_repositories.Items.Add(repo.Name);
            }
        }
    }
}
