using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctoNet_GUI
{
    public partial class Issues : Form
    {
        Form1 form = new Form1();
        readonly Authenticate Authenticated = new Authenticate();

        public Issues()
        {
            InitializeComponent();
        }

        private void Issues_Load(object sender, EventArgs e)
        {
            /*var ls = form.client.Issue.GetAllForCurrent().Result;*/

            lb_issues.Items.Add(Authenticated.auth.Name);

            /*foreach (var aaaa in ls)
            {
                Console.WriteLine(aaaa.Title);
            }

            foreach (var issue in ls)
            {
                lb_issues.Items.Add(issue.Title);
            }*/

        }

        private void lb_issues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
