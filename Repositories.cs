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
            //Get selected repo
            var selected = lb_repositories.SelectedItem.ToString();
            var selectedRepo = client.Repository.GetAllForCurrent().Result.Where(x => x.Name == selected).First();

            lbl_repo_name.Text = selectedRepo.Name;
            lbl_repo_description.Text = selectedRepo.Description;
        }
    }
}
