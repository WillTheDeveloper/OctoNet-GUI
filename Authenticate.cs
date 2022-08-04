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
    }
}
