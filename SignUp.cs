using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChipeleganiProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            PopulateDistricts();
            PopulateGender(); 
        }
        //populating gender
        private void PopulateGender()
        {
            string[] membergender = { "Male", "Female"};

            //suggestion when user is inputting gender
            txtBoxgender.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxgender.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Bind the array of gender to the ComboBox.
            txtBoxgender.Items.AddRange(membergender);
        }
        //populating districts
        private void PopulateDistricts()
        {
            // Creating an array of Malawian districts (you can load this data from a database).
            string[] malawianDistricts = { "Balaka", "Blantyre", "Chikwawa", "Chiradzulu", "Chitipa", "Dedza", "Dowa", "Karonga",
                "Kasungu", "Likoma", "Lilongwe", "Machinga", "Mangochi", "Mchinji", "Mulanje", "Mwanza",
                    "Mzimba", "Neno", "Nkhata Bay", "Nkhotakota", "Nsanje", "Ntcheu", "Ntchisi", "Phalombe",
                        "Rumphi", "Salima", "Thyolo", "Zomba" 
            };

                    //suggestion when user is inputting name of a district
                txtBoxdistrict.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxdistrict.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtBoxdistrict.Items.AddRange(malawianDistricts);// Bind the array of districts to the ComboBox.
        }
        //exit populating
        //signup
        databaseconnection dbsaconnection = new databaseconnection();
        private bool signUp()
        {
            dbsaconnection.openconnect();
            try
            {
                // Insert data into the 'users' table
                MySqlCommand newuser = new MySqlCommand("INSERT INTO users VALUES (@txtBoxusername, @newPassword, '2')", dbsaconnection.getconnection());
                    newuser.Parameters.Add("@txtBoxusername", MySqlDbType.VarChar).Value = txtBoxusername.Text;
                        newuser.Parameters.Add("@newPassword", MySqlDbType.VarChar).Value = newPassword.Text;
                

                if (newuser.ExecuteNonQuery() != 1)
                {
                    // Handle the case where the user insertion fails.
                    return false;
                }

                // Insert data into the 'members' table
                MySqlCommand newmember = new MySqlCommand("INSERT INTO members (FullName, Username, NationalID, Gender, DateOfBirth, District, Phone1, Phone2, GroupID,Image) VALUES (@txtBoxfullname, @txtBoxusername, @txtBoxId, @txtBoxgender, @txtBoxDOB, @txtBoxdistrict, @txtBoxphone, @txtBoxphone2, @txtBoxgroupID, @member_image)", dbsaconnection.getconnection());
                                                newmember.Parameters.Add("@txtBoxfullname", MySqlDbType.VarChar).Value = txtBoxfullname.Text;
                                            newmember.Parameters.Add("@txtBoxId", MySqlDbType.VarChar).Value = txtBoxId.Text;
                                        newmember.Parameters.Add("@txtBoxgender", MySqlDbType.VarChar).Value = txtBoxgender.Text;
                                    newmember.Parameters.Add("@txtBoxDOB", MySqlDbType.Date).Value = DateTime.Parse(txtBoxDOB.Text);
                                newmember.Parameters.Add("@txtBoxdistrict", MySqlDbType.VarChar).Value = txtBoxdistrict.Text;
                            newmember.Parameters.Add("@txtBoxphone", MySqlDbType.VarChar).Value = txtBoxphone.Text;
                        newmember.Parameters.Add("@txtBoxphone2", MySqlDbType.VarChar).Value = txtBoxphone2.Text;
                    newmember.Parameters.Add("@txtBoxusername", MySqlDbType.VarChar).Value = txtBoxusername.Text;
                newmember.Parameters.Add("@txtBoxgroupID", MySqlDbType.VarChar).Value = txtBoxgroupID.Text;
                newmember.Parameters.Add("@member_image", MySqlDbType.Blob).Value = member_image.Image;

                if (newmember.ExecuteNonQuery() != 1)
                {
                    // Handle the case where the member insertion fails.
                    return false;
                }

                // Both users and members were inserted successfully.
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle the exception here, for example, display an error message or log the exception.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // You may choose to return false in the case of an error.
            }
        }
        DataTable newtable = new DataTable();
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            //checks if textboxes are !empty
            if (string.IsNullOrEmpty(txtBoxfullname.Text) || string.IsNullOrEmpty(txtBoxusername.Text) || string.IsNullOrEmpty(txtBoxId.Text) || string.IsNullOrEmpty(txtBoxDOB.Text) || string.IsNullOrEmpty(txtBoxdistrict.Text) || string.IsNullOrEmpty(txtBoxphone.Text) || string.IsNullOrEmpty(txtBoxgender.Text) || string.IsNullOrEmpty("member_image.Image == null"))
            {
                MessageBox.Show("Please fill in all required details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                                    //checks if password and confirmed passwords are similar 
                                    if (newPassword.Text != confirmpassword.Text)
                                    {
                                        MessageBox.Show("Password and confirmation do not match.", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                    if (txtBoxphone.Text == txtBoxphone2.Text)//check number similarity
                    {
                        MessageBox.Show("Phone numbers must be different.", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBoxphone2.Text = "";
                        return;
                    }
                    else if(txtBoxphone.Text.Length <= 8 || txtBoxphone.Text.Length >= 11 || txtBoxphone2.Text.Length <= 8 || txtBoxphone2.Text.Length >= 11)
            {
                MessageBox.Show("Phone number '1 or 2' entered does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsPasswordComplex(newPassword.Text))//check password measures
            {
                MessageBox.Show("Password must contain betweet 8 & 16 characters with uppercase, lowercase, digit, and special symbol.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newPassword.Text = "";
                confirmpassword.Text = "";
                return;
            }
            if (txtBoxusername.Text.Length < 5 || txtBoxusername.Text.Length > 8)//check username measures
            {
                labelusercnd.Text = "Between 5 and 8 characters";
                labelusercnd.ForeColor = Color.Red;
                //MessageBox.Show("Username must be between 5 and 8 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the user's age is 20 or older based on the date of birth in txtBoxDOB.
            if (DateTime.TryParse(txtBoxDOB.Text, out DateTime dateOfBirth))
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - dateOfBirth.Year;

                if (currentDate < dateOfBirth.AddYears(age))
                {
                    age--; // The birthday hasn't occurred this year yet.
                }

                if (age < 20)
                {
                    MessageBox.Show("Only aged 20 or older can sign up for chipeleganyu.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            
            if (txtBoxId.Text.Length <= 5)
            {
                MessageBox.Show("Identification number cannot have less than 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*if (member_image.Image == null)
            {
                MessageBox.Show("Please insert your image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbsaconnection.openconnect();
                MySqlCommand dltuser = new MySqlCommand("Delete from users where Username = @Username", dbsaconnection.getconnection());
                dltuser.Parameters.AddWithValue("@Username", txtBoxusername.Text);
                dltuser.ExecuteNonQuery();
            }*/

            try
            {
                if (signUp() == true)
                {
                    //confirmation dialog of creating chipeleganyu account
                    DialogResult result = MessageBox.Show("Are you sure you want to create Chipeleganyu account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Welcome to Chipeleganyu Platform\n\nYou have Successfully Created Account.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //displays login form
                        this.Hide();
                        Home login = new Home();
                        login.ShowDialog();
                    }
                    else
                    {
                        DialogResult resul = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resul == DialogResult.Yes)
                        {
                            //emptying the textbox values if creation of account failed
                            txtBoxfullname.Text = "";
                                    txtBoxusername.Text = "";
                                        txtBoxId.Text = "";
                                            confirmpassword.Text = "";
                                                newPassword.Text = "";
                                                    txtBoxDOB.Text = "";
                                                        txtBoxgender.Text = "";
                                                            txtBoxdistrict.Text = "";
                                                            txtBoxphone.Text = "";
                                                        txtBoxphone2.Text = "";
                                                    txtBoxpath.Text = "";
                                                member_image.Image = null;
                                            dateTime.Value = DateTime.Now; //current date
                                        txtBoxDOB.Text = "";
                                     MessageBox.Show("Account creation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (MySqlException failedEntry)
            {
                //if failed creation the user should be removed in the users table
                MessageBox.Show(failedEntry.Message);
                return;
            }
        }

        

        private void clearinputdata()
        {
            txtBoxfullname.Text = string.Empty;
            txtBoxusername.Text = string.Empty; 
            txtBoxId.Text = string.Empty; 
            confirmpassword.Text = string.Empty; 
            newPassword.Text = string.Empty; 
            txtBoxDOB.Text = string.Empty; 
            txtBoxgender.Text = string.Empty; 
            txtBoxdistrict.Text = string.Empty; 
            txtBoxphone.Text = string.Empty; 
            txtBoxphone2.Text = string.Empty; 
            txtBoxpath.Text = string.Empty; 
            member_image.Image = null;
            dateTime.Value = DateTime.Now; //current date
            txtBoxDOB.Text = string.Empty;
            labelcharacter.Text = string.Empty;
            labelusercnd.Text = string.Empty;

        }

        private bool IsPasswordComplex(string password)
        {
            // Define your password complexity requirements here
            bool hasUppercase = false;
                bool hasLowercase = false;
                    bool hasDigit = false;
                        bool hasSpecialSymbol = false;

            if (password.Length >= 8 && password.Length <= 16)
                foreach (char c in password)
                {
                     if (char.IsUpper(c))
                        hasUppercase = true;
                            else if (char.IsLower(c))
                                hasLowercase = true;
                                    else if (char.IsDigit(c))
                                        hasDigit = true;
                                            else if (!char.IsLetterOrDigit(c))
                                                hasSpecialSymbol = true;
                }

            return hasUppercase && hasLowercase && hasDigit && hasSpecialSymbol;
        }


        //exit signup
        private void btnBack_Click(object sender, EventArgs e)
        {
            //displays login form
                this.Hide(); 
                    Home login = new Home(); 
                        login.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                        //displays login form
                    this.Hide(); 
                Home login = new Home(); 
            login.ShowDialog();
        }
        private void btnfile_Click(object sender, EventArgs e)
        {
            //opening file manager
                OpenFileDialog choosefile = new OpenFileDialog();
                    //filtering image files
                        choosefile.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (choosefile.ShowDialog() == DialogResult.OK)
            {
                String imagepath = choosefile.FileName.ToString();
                        txtBoxpath.Text = imagepath;
                            member_image.Image = new Bitmap(choosefile.FileName);
            }
        }
        private void checkBoxshow_CheckedChanged(object sender, EventArgs e)
        {
            //shows what is the textbox when checked 
            if (checkBoxshow.Checked == true)
            {
                newPassword.UseSystemPasswordChar = false;
            }
            else
            {
                newPassword.UseSystemPasswordChar = true;
            }
        }

        private void confirm_CheckedChanged(object sender, EventArgs e)
        {
            //shows what is the textbox when checked
            if (confirm.Checked == true)
            {
                confirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
               confirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            //inputs date in the combobox
            txtBoxDOB.Text = dateTime.Value.ToShortDateString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearinputdata();            
        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            passwordchecker();
        }

        private void passwordchecker()
        {
            if (newPassword.TextLength <= 7)
            {
                labelcharacter.Text = "Weak Password";
                labelcharacter.ForeColor = Color.Red;
            }
            else if (newPassword.TextLength == 8)
            {
                labelcharacter.Text = "Moderate Password";
                labelcharacter.ForeColor = Color.Green;
            }
            else
            {
                 labelcharacter.Text = "Strong Password";
                 labelcharacter.ForeColor = Color.Green;
            }
        }
    }
        
}
