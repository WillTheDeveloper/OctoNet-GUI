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
    public partial class Authenticate : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public User auth { get; set; }

        public Authenticate()
        {
            InitializeComponent();
        }

        private void Authenticate_Load(object sender, EventArgs e)
        {
            tb_auth_key.Text = authToken;
        }

        private void tb_auth_key_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            AttemptAuthentication();
        }

        public async void AttemptAuthentication()
        {
            var tokenAuth = new Credentials(tb_auth_key.Text);
            client.Credentials = tokenAuth;
            user = await client.User.Current();
            Console.WriteLine(user.Login);
            var name = user.Login;
            lbl_status.Text = name.ToString();
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }
    }
}
