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

        }

        private void bttn_authenticate_Click(object sender, EventArgs e)
        {
            var a = new Authenticate();
            a.Show();
        }

        private void bttn_issues_Click(object sender, EventArgs e)
        {
            Form form = new Issues();
            form.Show();
        }

        private void bttn_repositories_Click(object sender, EventArgs e)
        {
            Form form = new Repositories();
            form.Show();
        }

        private void bttn_api_check_Click(object sender, EventArgs e)
        {
            Form form = new ApiStatus();
            form.Show();
        }

        private void bttn_profile_Click(object sender, EventArgs e)
        {
            Form form = new Profile();
            form.Show();
        }
    }
}
