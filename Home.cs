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
    public partial class Home : Form
    {
        MySqlConnection connection;
        public Home()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = "Server = localhost; userID = root; password=; database = chipeleganyu";
            PopulateLanguage();
        }
        //populating gender
        private void PopulateLanguage()
        {
            string[] Language = { "English(US)", "Chichewa"};

            language.AutoCompleteMode = AutoCompleteMode.Suggest;
            language.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Bind the array of gender to the ComboBox.
            language.Items.AddRange(Language);

        }
        private void signup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Welcome to chipeleganyu platform\nBelow are the terms and conditions please read before you accept to the terms.\n\n" +
                "1. You should have Malawian National Identification card.\n" +
                "2. Should be above 20 years of age.\n" +
                "3. If found breaking rules you will be charged by the group's implemented rules which were agreed upon.\n" +
                "4. Failure to comply Local authorities will be involved to solve the matter.\n" +
                "5. All members must not question where/how their fellow obtain the money to pay for the chipeleganyu.\n\n\n" +
                "Please click 'Yes' if you agree to the terms and conditions.", "Terms & Conditions", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                SignUp newaccount = new SignUp();
                newaccount.Show();
            }
        }

        private void showpassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
            {
                textBoxpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxpassword.UseSystemPasswordChar = true;
            }
        }
        //logIn button
        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            string txtboxusername = textBoxusername.Text;
            string txtboxpassword = textBoxpassword.Text;
            string txtboxgroupID = txtBoxgroupID.Text;
            if (string.IsNullOrEmpty(txtboxusername))//check if textbox is empty
            {

                usernameLable.Text = "Username Required";
                usernameLable.ForeColor = Color.Red;
                //MessageBox.Show("Please enter Username and Password or Group ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clearinputdata();
                //RefreshTextbox();

                if (string.IsNullOrEmpty(txtboxpassword))
                {
                    Passwordlabel.Text = "Password required";
                    Passwordlabel.ForeColor = Color.Red;
                }
                
            }
            if (string.IsNullOrEmpty(txtboxgroupID))
            {
                grouplabel.Text = "Can't be Empty";
                grouplabel.ForeColor = Color.Red;
            }
            else
            {
                string query = "SELECT * FROM users WHERE binary Username = '" + txtboxusername + "' and binary Password = '" + txtboxpassword + "' ";
                DataTable usertable = new DataTable();
                MySqlDataAdapter check = new MySqlDataAdapter(query, connection);
                check.Fill(usertable);
                if (usertable.Rows.Count == 1)
                {
                    /*checking usertype*/
                    string Usertype = "SELECT * FROM users WHERE Username = '" + txtboxusername + "' and UsertypeID = '1' ";
                    DataTable input = new DataTable();
                    MySqlDataAdapter checkuser = new MySqlDataAdapter(Usertype, connection);
                    checkuser.Fill(input);

                    if (input.Rows.Count == 1)
                    {

                        this.Hide();
                        Admin Adminform = new Admin();
                        Adminform.Show();
                    }
                    else
                    {
                        this.Hide();
                        List memberform = new List();
                        memberform.Show();
                    }
                }
                else
                {
                     
                    usernameLable.Text = "Username Does Not exist";
                    usernameLable.ForeColor = Color.Red;
                    Passwordlabel.Text = "Wrong password";
                    Passwordlabel.ForeColor = Color.Red;
                    grouplabel.Text = "Wrong Group ID";
                    grouplabel.ForeColor = Color.Red;
                    //MessageBox.Show("Incorrect Username or Password and GroupID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearinputdata();
                    RefreshTextbox();
                }
            }
            
        }

        private void RefreshTextbox()
        {
            textBoxusername.Focus();
        }

        private void clearinputdata()
        {
            //clearing input data
            textBoxusername.Text = string.Empty;
            textBoxpassword.Text = string.Empty;
            txtBoxgroupID.Text = string.Empty;
        }

        private void forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forgotPassword forgot = new forgotPassword();
            forgot.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You will close the Application if you click 'Yes'.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                clearinputdata();
                RefreshTextbox();
            }
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            language.Text = "English(US)"; 
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(language.Text == "Chichewa" || language.Text == "Yao" || language.Text == "Tumbuka")
            {
                MessageBox.Show("We are sorry the language package selected is not available until next Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                language.Text = "English";
                RefreshTextbox();
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255),random.Next(0, 255));        
        }

        private void textBoxusername_TextChanged(object sender, EventArgs e)
        {
            usernameLable.Text = string.Empty;
        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {
            Passwordlabel.Text = string.Empty;
        }

        private void txtBoxgroupID_TextChanged(object sender, EventArgs e)
        {
            grouplabel.Text = string.Empty;
        }
    }
}
