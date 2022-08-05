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
    public partial class Profile : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Profile()
        {
            InitializeComponent();
        }

        private void tb_name_on_profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_bio_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_enable_edit_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            tb_name_on_profile.Text = user.Name.ToString();
            tb_bio.Text = user.Bio.ToString();
            web_pfp.Url = new Uri(user.AvatarUrl.ToString());
        }

        private void web_pfp_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
