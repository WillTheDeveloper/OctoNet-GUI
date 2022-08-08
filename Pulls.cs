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
        public static string auth;
        public static GitHubClient client = new GitHubClient(new ProductHeaderValue("Octonet-Gui"));
        public static User user;

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
