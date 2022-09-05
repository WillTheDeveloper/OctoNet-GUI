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
    public partial class Pulls : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Pulls()
        {
            InitializeComponent();
        }

        private void Pulls_Load(object sender, EventArgs e)
        {
            
        }

        private void lb_pulls_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
