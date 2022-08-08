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

            var commits = client.Repository.Commit.GetAll(repo.Owner.Login, repo.Name).Result;

            var selectedCommit = commits.Where(x => x.Commit.Message.ToString() == lb_commit_list.SelectedItem.ToString()).First();

            lbl_commit_message.Text = selectedCommit.Commit.Message.ToString();
            lbl_comitter.Text = selectedCommit.Commit.Committer.Name.ToString();

            lbl_additions.Text = "++" + selectedCommit.Stats.Additions;
            lbl_deletions.Text = "--" + selectedCommit.Stats.Deletions;

            var files = selectedCommit.Files;

            if(files.Count() > 0)
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

            lbl_loading_state.Visible = false;
            lb_commit_list.Enabled = true;
        }
    }
}
