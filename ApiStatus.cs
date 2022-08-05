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
    public partial class ApiStatus : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public ApiStatus()
        {
            InitializeComponent();
        }

        private void ApiStatus_Load(object sender, EventArgs e)
        {
            // Get the user's rate limit status
            var rateLimit = client.Miscellaneous.GetRateLimits();
            var remaining = rateLimit.Result;
            var limit = remaining.Resources.Core.Remaining;

            lbl_requests_remaining.Text = "API requests remaining: " + limit.ToString();
        }

        private void lbl_requests_remaining_Click(object sender, EventArgs e)
        {

        }
    }
}
