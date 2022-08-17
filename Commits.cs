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
    public partial class Commits : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Repository repo;
        
        public Commits(Repository repository)
        {
            InitializeComponent();

            repo = repository;

            var commits = client.Repository.Commit.GetAll(repository.Owner.Login, repository.Name).Result;

            foreach (var commit in commits)
            {
                lb_commit_list.Items.Add(commit.Commit.Message.ToString());
            }
        }

        private void Commits_Load(object sender, EventArgs e)
        {

        }

        private void lb_commit_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_loading_state.Visible = true;
            lb_commit_list.Enabled = false;
            pb_bar.Visible = true;
            pb_bar.Value = 0;

            var commits = client.Repository.Commit.GetAll(repo.Owner.Login, repo.Name).Result;
            pb_bar.Value = 5;

            var selectedCommit = commits.Where(x => x.Commit.Message.ToString() == lb_commit_list.SelectedItem.ToString()).First();
            pb_bar.Value = 20;

            lbl_commit_message.Text = selectedCommit.Commit.Message.ToString();
            lbl_comitter.Text = selectedCommit.Commit.Committer.Name.ToString();
            pb_bar.Value = 30;

            if(selectedCommit.Stats != null)
            {
                lbl_additions.Text = "++" + selectedCommit.Stats.Additions;
                lbl_deletions.Text = "--" + selectedCommit.Stats.Deletions;
            }

            pb_bar.Value = 40;

            var files = selectedCommit.Files;

            if(files.Count() != 0 & files.Count() > 0)
            {
                foreach (var f in files)
                {
                    lb_files.Items.Add(f.Filename);
                }
            }
            else if (files.Count() == 0)
            {
                lb_files.Items.Add("No files found");
            }

            pb_bar.Visible = false;
            lbl_loading_state.Visible = false;
            lb_commit_list.Enabled = true;
        }

        private void pb_bar_Click(object sender, EventArgs e)
        {

        }
    }
}
