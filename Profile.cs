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
            bttn_save_changes.Enabled = true;
            tb_name_on_profile.Enabled = true;
            tb_bio.Enabled = true;
            tb_location.Enabled = true;
            tb_website.Enabled = true;
            tb_company.Enabled = true;
            bttn_enable_edit.Enabled = false;

            bttn_save_changes.Enabled = true;
            bttn_save_changes.Visible = true;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            tb_name_on_profile.Enabled = false;
            tb_bio.Enabled = false;
            tb_location.Enabled = false;
            tb_website.Enabled = false;
            tb_company.Enabled = false;

            bttn_save_changes.Enabled = false;
            bttn_save_changes.Visible = false;
            tb_name_on_profile.Text = user.Name.ToString();
            tb_bio.Text = user.Bio.ToString();
            web_pfp.Url = new Uri(user.AvatarUrl.ToString());
            tb_location.Text = user.Location.ToString();
            tb_website.Text = user.Blog.ToString();
            tb_company.Text = user.Company.ToString();

        }

        private void UpdateName()
        {
            var name = new UserUpdate
            {
                Name = tb_name_on_profile.Text
            };
            client.User.Update(name);
        }

        private void UpdateBio()
        {
            var bio = new UserUpdate
            {
                Bio = tb_bio.Text
            };
            client.User.Update(bio);
        }

        private void UpdateLocation()
        {
            var location = new UserUpdate
            {
                Location = tb_location.Text
            };
            client.User.Update(location);
        }

        private void UpdateWebsite()
        {
            var website = new UserUpdate
            {
                Blog = tb_website.Text
            };
            client.User.Update(website);
        }

        private void UpdateCompany()
        {
            var company = new UserUpdate
            {
                Company = tb_company.Text
            };
            client.User.Update(company);
        }

        private void web_pfp_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void bttn_save_changes_Click(object sender, EventArgs e)
        {
            if (tb_name_on_profile.Text != user.Name.ToString())
            {
                UpdateName();
            }
            if (tb_bio.Text != user.Bio.ToString())
            {
                UpdateBio();
            }
            if (tb_location.Text != user.Location.ToString())
            {
                UpdateLocation();
            }
            if (tb_website.Text != user.Blog.ToString())
            {
                UpdateWebsite();
            }
            if (tb_company.Text != user.Company.ToString())
            {
                UpdateCompany();
            }

            tb_name_on_profile.Text = user.Name.ToString();
            tb_bio.Text = user.Bio.ToString();
            web_pfp.Url = new Uri(user.AvatarUrl.ToString());
            tb_location.Text = user.Location.ToString();
            tb_website.Text = user.Blog.ToString();
            tb_company.Text = user.Company.ToString();
        }

        private void tb_website_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_location_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
