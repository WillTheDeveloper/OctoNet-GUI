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
        Form1 form = new Form1();

        public Authenticate()
        {
            InitializeComponent();
        }

        private void Authenticate_Load(object sender, EventArgs e)
        {
            tb_auth_key.Text = form.auth;
        }

        private void tb_auth_key_TextChanged(object sender, EventArgs e)
        {

        }

        private async void bttn_login_Click(object sender, EventArgs e)
        {
            var tokenAuth = new Credentials(tb_auth_key.Text);
            form.client.Credentials = tokenAuth;
            User user = await form.client.User.Current();
            var name = user.Login;
            lbl_status.Text = name.ToString();
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }
    }
}
