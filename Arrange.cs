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
    public partial class Arrange : Form
    {
        public Arrange()
        {
            InitializeComponent();
            populateusernames();
            populatemonths();
        }

        private void populatemonths()
        {
            string[] months = {"January", "February", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December"
            };

            // Set the AutoCompleteMode and AutoCompleteSource properties.
            month.AutoCompleteMode = AutoCompleteMode.Suggest;
            month.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Bind the array of months to the ComboBox.
            month.Items.AddRange(months);

        }

        private void populateusernames()
        {

            MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; Password=; Database=chipeleganyu");

            connect.Open();

            MySqlDataAdapter mS = new MySqlDataAdapter("SELECT FullName,  Username FROM payments", connect);
            DataTable Dt = new DataTable();
            mS.Fill(Dt);

            username.DataSource = Dt;
            username.DisplayMember = "Username";
            username.ValueMember = "Username";

            username.AutoCompleteMode = AutoCompleteMode.Suggest;
            username.AutoCompleteSource = AutoCompleteSource.ListItems;


            connect.Close();
        }

        private void username_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (username.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)username.SelectedItem;
                string fullname = selectedRow["FullName"].ToString();


                // Populate txtp1 and txtp2 with the phone numbers
                txtBoxfullname.Text = fullname;
                txtBoxfullname.ReadOnly = true;
            }
        }
    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentForm pay = new paymentForm();
            pay.ShowDialog();
        }

        private void Arrange_Load(object sender, EventArgs e)
        {
            username.Text = "";
            txtBoxfullname.Text = "";
        }
        databaseconnection dbsaconnection = new databaseconnection();
        private bool add()
        {
            dbsaconnection.openconnect();
            try
            {
                // Insert data into the 'payments' table
                MySqlCommand olandila = new MySqlCommand("INSERT INTO receivingmember VALUES (@month, @username, @txtBoxfullname)", dbsaconnection.getconnection());
                olandila.Parameters.Add("@month", MySqlDbType.VarChar).Value = month.Text;
                olandila.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.Text;
                olandila.Parameters.Add("@txtBoxfullname", MySqlDbType.VarChar).Value = txtBoxfullname.Text;
                                
                if (olandila.ExecuteNonQuery() != 1)
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable newtable = new DataTable();

            {
                //checks if textboxes are !empty
                if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(txtBoxfullname.Text) || string.IsNullOrEmpty(month.Text))
                {
                    MessageBox.Show("Please fill in all required details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (add() == true)
                    {
                        //confirmation dialog of creating chipeleganyu account
                        DialogResult result = MessageBox.Show("This action can neither be reversed nor updated.\n\nIs the month and member selected agreed by all members?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Member and month Added Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear input data
                            clearData();

                        }
                        else
                        {
                            MessageBox.Show("Member cannot be added is Ignored", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dbsaconnection.openconnect();
                            MySqlCommand dltOl = new MySqlCommand("Delete from receivingmember where month = @month", dbsaconnection.getconnection());
                            dltOl.Parameters.AddWithValue("@month", month.Text);
                            dltOl.ExecuteNonQuery();
                            clearData();

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
            username.Text = "";
            txtBoxfullname.Text = "";
            month.Text = "";
        }
    }
}
