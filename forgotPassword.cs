using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChipeleganiProject
{
    public partial class forgotPassword : Form
    {
        MySqlConnection connection;
        public forgotPassword()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = "Server = localhost; userID = root; password=; database = chipeleganyu";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            string memberusername = txtBoxusername.Text;
            string phone = txtBoxphone.Text;
            if (string.IsNullOrEmpty(memberusername) || string.IsNullOrEmpty(phone))//check if textbox is empty
            {
                MessageBox.Show("Please enter your username and recommended phone number to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "SELECT * FROM members WHERE binary Username = '" + memberusername + "' and binary Phone1 = '" + phone + "' ";
                DataTable usertable = new DataTable();
                MySqlDataAdapter check = new MySqlDataAdapter(query, connection);
                check.Fill(usertable);
                if (usertable.Rows.Count == 1)
                {
                    /*checking usertype*/
                    string Usertype = "SELECT * FROM users WHERE Username = '" + memberusername + "'";
                    DataTable input = new DataTable();
                    MySqlDataAdapter checkuser = new MySqlDataAdapter(Usertype, connection);
                    checkuser.Fill(input);

                    if (input.Rows.Count == 1)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to reset password?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            string otp = Microsoft.VisualBasic.Interaction.InputBox("", "OTP", "");
                            if (!string.IsNullOrEmpty(otp))
                            {
                                //otp entered
                                MessageBox.Show("You can now Add New password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtBoxnewpassword.ReadOnly = false;
                                txtBoxnewpassword.BackColor = Color.White;
                                txtBoxconfirm.ReadOnly = false;
                                txtBoxconfirm.BackColor = Color.White;
                            }
                            else
                            {
                                MessageBox.Show("Password Reset Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBoxusername.Text = "";
                                txtBoxphone.Text = "";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username or phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxusername.Text = "";
                    txtBoxphone.Text = "";
                }

            }
        }
        databaseconnection dbsaconnection = new databaseconnection();
        private bool change()
        {
            dbsaconnection.openconnect();
            try
            {
                // Update data in the 'u' table
                MySqlCommand newpassword = new MySqlCommand("UPDATE users SET Password = @txtBoxnewpassword WHERE Username = @txtBoxusername", dbsaconnection.getconnection());
                newpassword.Parameters.Add("@txtBoxusername", MySqlDbType.VarChar).Value = txtBoxusername.Text;
                newpassword.Parameters.Add("@txtBoxnewpassword", MySqlDbType.VarChar).Value = txtBoxnewpassword.Text;
                
                if (newpassword.ExecuteNonQuery() != 1)
                {
                    // Handle the case where the member insertion fails.
                    return false;
                }
                else
                {
                    // Both users and members were inserted successfully.
                    return true;

                }

            }
            catch (MySqlException ex)
            {
                // Handle the exception here, for example, display an error message or log the exception.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            DataTable newtable = new DataTable();

            {
                //checks if textboxes are !empty
                if (string.IsNullOrEmpty(txtBoxnewpassword.Text) || string.IsNullOrEmpty(txtBoxconfirm.Text))
                {
                    MessageBox.Show("Please fill in new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxnewpassword.Text != txtBoxconfirm.Text)
                {
                    MessageBox.Show("Password and confirmation do not match.", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsPasswordComplex(txtBoxnewpassword.Text))//check password measures
                {
                    MessageBox.Show("Password must contain betweet 8 & 16 characters with uppercase, lowercase, digit, and special symbol.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxnewpassword.Text = "";
                    txtBoxconfirm.Text = "";
                    return;
                }
                try
                {
                    if (change() == true)
                    {
                        //confirmation dialog of creating chipeleganyu account
                        DialogResult result = MessageBox.Show("Are you sure you want to change password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Password succefully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear input data
                            clearData();
                            this.Hide(); Home login = new Home(); login.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Password changing failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //clear input data
                            clearData();
                            return;
                        }
                    }
                }
                catch (MySqlException failedEntry)
                {
                    //if failed addding
                    MessageBox.Show(failedEntry.Message);
                    return;
                }
            }
        }

        private void clearData()
        {
            txtBoxusername.Text = "";
                    txtBoxphone.Text = "";
                    txtBoxnewpassword.Text = "";
            txtBoxconfirm.Text = "";
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


        private void ckBoxshow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxshow.Checked == true)
            {
                txtBoxnewpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxnewpassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBoxshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxshow.Checked == true)
            {
                txtBoxconfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxconfirm.UseSystemPasswordChar = true;
            }
        }
    }
    
}
