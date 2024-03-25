using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChipeleganiProject
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            List list = new List();
            list.ShowDialog();
        }
        
        private void profile_Load(object sender, EventArgs e)
        {
            fullname.Text = "****Member Full Name****";
            username.Text = "****Member Username****";
            nationalID.Text = "****Member ID****";
            gender.Text = "****Member Gender****";
            dob.Text = "****Member D.O.B****";
            district.Text = "****Member Location****";
            phone.Text = "****Member Phone 1****";
            phone2.Text = "****Member Phone 2****";
            
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You can only edit/change Your details after 65 days.\n\nDo you want to edit your details?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
            if (result == DialogResult.Yes)
            {
                fullname.ReadOnly = false;
                fullname.BackColor = Color.White;
                username.ReadOnly = false;
                username.BackColor = Color.White;
                district.ReadOnly = false;
                district.BackColor = Color.White;
                phone2.ReadOnly = false;
                phone2.BackColor = Color.White;

                MessageBox.Show("You can only edit in the white boxes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult outcome = MessageBox.Show("Cancel editing?", "Qestion",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (outcome == DialogResult.Yes)
            {
                fullname.Text = "****Member Full Name****";
                fullname.ReadOnly = true;
                fullname.BackColor = default;
                username.Text = "****Member Username****";
                username.ReadOnly = true;
                username.BackColor = default;
                district.Text = "****Member Location****";
                district.ReadOnly = true;
                district.BackColor = default;
                phone2.Text = "****Member Phone 2****";
                phone2.ReadOnly = true;
                phone2.BackColor = default;
            }

        }
        
        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently the button is not functioning", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnchangeimage_Click(object sender, EventArgs e)
        {
            //opening file manager
            OpenFileDialog choosefile = new OpenFileDialog();
            //filtering image files
            choosefile.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (choosefile.ShowDialog() == DialogResult.OK)
            {
                String imagepath = choosefile.FileName.ToString();
                profilepic.Image = new Bitmap(choosefile.FileName);
            }
        }

        private void btnrmvImage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Profile picture will be removed\n\nAre you sure you want to remove?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Profile picture removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
