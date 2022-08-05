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
            lb_issues.Enabled = false;
            lbl_loading_state.Visible = true;
            var ls = client.Issue.GetAllForCurrent().Result;

            foreach (var issue in ls)
            {
                lb_issues.Items.Add(issue.Title);
            }
            lb_issues.Enabled = true;
            lbl_loading_state.Visible = false;
        }

        private void lb_issues_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_loading_state.Visible = true;
            lb_issues.Enabled = false;
            
            var selectedRepo = lb_issues.SelectedItem.ToString();
            var selectedIssue = client.Issue.GetAllForCurrent().Result.Where(x => x.Title == selectedRepo).First();
            
            lbl_issue_name.Text = selectedIssue.Title;
            lbl_issue_body.Text = selectedIssue.Body;
            
            lb_issues.Enabled = true;
            lbl_loading_state.Visible = false;
        }
    }
}
