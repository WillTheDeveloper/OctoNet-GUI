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
            if(tb_user_find.Text != null)
            {
                User user = client.User.Get(tb_user_find.Text).Result;

                tb_name.Clear();
                tb_bio.Clear();
                tb_blog.Clear();
                tb_email.Clear();
                tb_company.Clear();
                tb_twitter.Clear();
                tb_followers.Clear();
                tb_following.Clear();
                tb_created_at.Clear();
                tb_updated_at.Clear();
                wb_pfp.Url = null;

                if (user.AvatarUrl != null)
                {
                    wb_pfp.Url = new Uri(user.AvatarUrl.ToString());
                }

                if (user.Name != null)
                {
                    tb_name.Text = user.Name.ToString();
                }

                if (user.Bio != null)
                {
                    tb_bio.Text = user.Bio.ToString();
                }

                if (user.Blog != null)
                {
                    tb_blog.Text = user.Blog.ToString();
                }

                if (user.Email != null)
                {
                    tb_email.Text = user.Email.ToString();
                }

                if (user.Company != null)
                {
                    tb_company.Text = user.Company.ToString();
                }

                /*if (user.TwitterUsername != null)
                {
                    tb_twitter.Text = user.TwitterUsername.ToString();
                }*/

                tb_followers.Text = user.Followers.ToString();
                tb_following.Text = user.Following.ToString();
                tb_created_at.Text = user.CreatedAt.ToString();
                tb_updated_at.Text = user.UpdatedAt.ToString();
            }
        }
    }
}
