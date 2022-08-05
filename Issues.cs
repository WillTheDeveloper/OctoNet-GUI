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
    public partial class Issues : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Issues()
        {
            InitializeComponent();
            
        }

        private void Issues_Load(object sender, EventArgs e)
        {
            var ls = client.Issue.GetAllForCurrent().Result;

            foreach (var issue in ls)
            {
                lb_issues.Items.Add(issue.Title);
            }

        }

        private void lb_issues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
