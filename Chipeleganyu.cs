using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChipeleganiProject
{
    public partial class Chipeleganyu : Form
    {
        public Chipeleganyu()
        {
            InitializeComponent();
        }
        private void btngroup_Click(object sender, EventArgs e)
        {
            this.Hide();
            group grp = new group();
            grp.ShowDialog();
        }

        private void logIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
