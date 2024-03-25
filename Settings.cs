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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to chipeleganyu terms & conditions.\n\nBelow are the terms and conditions please read before you accept to the terms.\n" +
                "1. You should have Malawian National Identification card.\n" +
                "2. Should be above 20 years of age.\n" +
                "3. If found breaking rules you will be charged by the group's implemented rules which were agreed upon.\n" +
                "4. Failure to comply Local authorities will be involved to solve the matter.\n" +
                "5. All members must not question where/how their fellow obtain the money to pay for the chipeleganyu.", "Terms & Conditions", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void radioBtndark_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            labelsettings.ForeColor = Color.White;
            pictureBox1.BackColor = Color.White;
            labelcb.ForeColor = Color.White;
            labelpassword.ForeColor = Color.White;
            labelconfirmpa.ForeColor = Color.White;
            labelusername.ForeColor = Color.White;
            labeltb.ForeColor = Color.White;
            labelnewpassword.ForeColor = Color.White;
            checkBoxshow.ForeColor = Color.White;
            checkBoxsh.ForeColor = Color.White;
            btnBack.BackColor = Color.White;
            labelmwk.ForeColor = Color.White;
            radioBtndark.ForeColor = Color.White;
            radioBtnlight.ForeColor = Color.White;
            btncancel.ForeColor = Color.White;
            btnSave.ForeColor = Color.White;

        }

        private void radioBtnlight_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.White;
            labelsettings.ForeColor = default; 
            pictureBox1.BackColor = default;
            labelcb.ForeColor = default;
            labelpassword.ForeColor = default;
            labelconfirmpa.ForeColor = default;
            labelusername.ForeColor = default;
            labeltb.ForeColor = default;
            labelnewpassword.ForeColor = default;
            checkBoxshow.ForeColor = default;
            checkBoxsh.ForeColor = default;
            btnBack.BackColor = default;
            labelmwk.ForeColor = default;
            radioBtndark.ForeColor = default;
            radioBtnlight.ForeColor = default;
            btncancel.ForeColor = default;
            btnSave.ForeColor = default;
        }

    }
}
