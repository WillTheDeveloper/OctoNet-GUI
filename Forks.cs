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
    public partial class Forks : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Repository asset;

        public Forks(Repository repository)
        {
            InitializeComponent();
            asset = repository;
        }

        private void Forks_Load(object sender, EventArgs e)
        {
            var forks = client.Repository.Forks.GetAll(asset.Id).Result;

            foreach (var b in forks)
            {
                lb_forks.Items.Add(b.ToString());
            }
        }
    }
}
