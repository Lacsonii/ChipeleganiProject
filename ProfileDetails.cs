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
    public partial class ProfileDetails : Form
    {
        
        public ProfileDetails()
        {
            InitializeComponent();
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
                        this.Hide();
                    Admin admin = new Admin();
            admin.ShowDialog();
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("You can only edit/change your details after 30 days.\n\nDo you want to edit your details?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                fullname.ReadOnly = false;
                    fullname.BackColor = Color.White;
                        username.ReadOnly = false;
                            username.BackColor = Color.White;
                                nationalID.ReadOnly = false;
                                     nationalID.BackColor = Color.White;
                                         gender.ReadOnly = false;
                                         gender.BackColor = Color.White;
                                         district.ReadOnly = false;
                                         district.BackColor = Color.White;
                                         dob.ReadOnly = false;
                                         dob.BackColor = Color.White;
                                     phone.ReadOnly = false;
                                 phone.BackColor = Color.White;
                             phone2.ReadOnly = false;
                phone2.BackColor = Color.White;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently the button is not functioning", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void ProfileDetails_Load(object sender, EventArgs e)
        {
            // Populate textboxes with member details when acc form loads
            fullname.Text = "****Admin Full Name****";
                        username.Text = "****Admin Username****";
                            nationalID.Text = "****Admin ID****";
                                    gender.Text = "****Admin Gender****";
                                         dob.Text = "****Admin D.O.B****";
                                    district.Text = "****Admin Location****";
                            phone.Text = "****Admin Phone 1****";
            phone2.Text = "****Admin Phone 2****";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult outcome = MessageBox.Show("Cancel editing?", "Qestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (outcome == DialogResult.Yes)
            {

                fullname.Text = "****Admin Full Name****";
                fullname.ReadOnly = true;
                fullname.BackColor = default;
                username.Text = "****Admin Username****";
                username.ReadOnly = true;
                username.BackColor = default;
                nationalID.Text = "****Admin ID****";
                nationalID.ReadOnly = true;
                nationalID.BackColor = default;
                gender.Text = "****Admin Gender****";
                gender.ReadOnly = true;
                gender.BackColor = default;
                dob.Text = "****Admin D.O.B****";
                dob.ReadOnly = true;
                dob.BackColor = default;
                district.Text = "****Admin Location****";
                district.ReadOnly = true;
                district.BackColor = default;
                phone.Text = "****Admin Phone 1****";
                phone.ReadOnly = true;
                phone.BackColor = default;
                phone2.Text = "****Admin Phone 2****";
                phone2.ReadOnly = true;
                phone2.BackColor = default;
            }
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
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Profile picture removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
