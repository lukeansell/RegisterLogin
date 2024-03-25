using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLogin
{
    public partial class Welcome : Form
    {
        private readonly Form f;
        public Welcome(string user, Form form)
        {
            InitializeComponent();
            f = form;
            lblWelcomeUser.Text = "Welcome " + user;
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Close();
        }


    }
}
