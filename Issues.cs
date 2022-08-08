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

        public Issue select;

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
            bttn_assignees.Enabled = false;
            bttn_comments.Enabled = false;
            bttn_labels.Enabled = false;

            var selectedRepo = lb_issues.SelectedItem.ToString();
            var selectedIssue = client.Issue.GetAllForCurrent().Result.Where(x => x.Title == selectedRepo).First();

            select = selectedIssue;

            lbl_issue_name.Text = selectedIssue.Title;
            lbl_issue_body.Text = selectedIssue.Body;

            if (lb_issues.SelectedIndex != -1)
            {
                bttn_assignees.Enabled = true;
                bttn_comments.Enabled = true;
                bttn_labels.Enabled = true;
            }
            else
            {
                bttn_assignees.Enabled = false;
                bttn_comments.Enabled = false;
                bttn_labels.Enabled = false;
            }

            lb_issues.Enabled = true;
            lbl_loading_state.Visible = false;
        }

        private void bttn_assignees_Click(object sender, EventArgs e)
        {
            lb_whatever.Items.Clear();

            foreach (var assignee in select.Assignees)
            {
                lb_whatever.Items.Add(assignee.Login);
            }
        }

        private void bttn_labels_Click(object sender, EventArgs e)
        {
            lb_whatever.Items.Clear();

            foreach (var label in select.Labels)
            {
                lb_whatever.Items.Add(label.Name);
            }
        }

        private void bttn_comments_Click(object sender, EventArgs e)
        {
            lb_whatever.Items.Clear();
        }
    }
}
