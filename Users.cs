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
    public partial class Users : Form
    {
        public string authToken = Form1.auth;
        public GitHubClient client = Form1.client;
        public User user = Form1.user;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            
        }

        private void bttn_get_user_Click(object sender, EventArgs e)
        {
            string user = tb_user_find.Text;

            if(user == "")
            {
                bttn_get_user.ForeColor = Color.Red;
            }
            else if (user != "")
            {
                bttn_get_user.ForeColor = Color.Black;

                User data = client.User.Get(user).Result;

                if (data.Email.ToString() != null)
                {
                    lbl_email.Text = data.Email.ToString();
                }

                if (data.Blog.ToString() != null)
                {
                    lbl_blog.Text = data.Blog.ToString();
                }
            }
        }
    }
}
