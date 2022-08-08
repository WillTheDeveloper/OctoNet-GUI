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
    public partial class Repositories : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Repository bbbbb;

        public Repositories()
        {
            InitializeComponent();
        }

        private void Repositories_Load(object sender, EventArgs e)
        {
            foreach (var repo in client.Repository.GetAllForCurrent().Result)
            {
                lb_repositories.Items.Add(repo.Name);
            }
        }

        private void lb_repositories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_loading_state.Visible = true;
            lb_repositories.Enabled = false;
            //Get selected repo
            var selected = lb_repositories.SelectedItem.ToString();
            var selectedRepo = client.Repository.GetAllForCurrent().Result.Where(x => x.Name == selected).First();
            bbbbb = selectedRepo;

            lbl_repo_name.Text = "Name: " + selectedRepo.Name;
            lbl_repo_description.Text = "Description: " + selectedRepo.Description;
            lbl_loading_state.Visible = false;
            lb_repositories.Enabled = true;
        }

        private void bttn_commits_Click(object sender, EventArgs e)
        {
            Form form = new Commits(bbbbb);
            form.Show();
        }

        private void bttn_download_Click(object sender, EventArgs e)
        {
            var download = client.Repository.Content.GetArchive(bbbbb.Owner.Login, bbbbb.Name, ArchiveFormat.Tarball, "master").Result;
        }
    }
}
