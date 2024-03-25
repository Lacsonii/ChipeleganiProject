using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChipeleganiProject
{
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();
            populateusernames();
        }

        private void populateusernames()
        {
            
            MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; Password=; Database=chipeleganyu");

            connect.Open();

            MySqlDataAdapter mS = new MySqlDataAdapter("SELECT FullName,  Username FROM members", connect);
            DataTable Dt = new DataTable();
            mS.Fill(Dt);

            memberUsername.DataSource = Dt;
            memberUsername.DisplayMember = "Username";
            memberUsername.ValueMember = "Username";

            memberUsername.AutoCompleteMode = AutoCompleteMode.Suggest;
            memberUsername.AutoCompleteSource = AutoCompleteSource.ListItems;


            connect.Close();
        }

        private void memberUsername_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (memberUsername.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)memberUsername.SelectedItem;
                string fullname = selectedRow["FullName"].ToString();


                // Populate txtp1 and txtp2 with the phone numbers
                txtBoxfullname.Text = fullname;
                txtBoxfullname.ReadOnly = true;
                txtBoxchA.Text = "150000";
                txtBoxchA.ReadOnly = true;
            }
        } 
            
        
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        databaseconnection dbsaconnection = new databaseconnection();
        private bool add()
        {
            dbsaconnection.openconnect();
            try
            {
                // Insert data into the 'payments' table
                MySqlCommand payment = new MySqlCommand("INSERT INTO payments VALUES (@memberUsername, @txtBoxfullname, @txtBoxchA, @txtBoxpaidAmount,@txtBoxReference, @txtBoxBalance)", dbsaconnection.getconnection());
                payment.Parameters.Add("@memberUsername", MySqlDbType.VarChar).Value = memberUsername.Text;
                payment.Parameters.Add("@txtBoxfullname", MySqlDbType.VarChar).Value = txtBoxfullname.Text;
                payment.Parameters.Add("@txtBoxchA", MySqlDbType.VarChar).Value = txtBoxchA.Text;
                payment.Parameters.Add("@txtBoxpaidAmount", MySqlDbType.VarChar).Value = txtBoxpaidAmount.Text;
                payment.Parameters.Add("@txtBoxReference", MySqlDbType.VarChar).Value = txtBoxReference.Text;
                payment.Parameters.Add("@txtBoxBalance", MySqlDbType.VarChar).Value = txtBoxBalance.Text;

                if (payment.ExecuteNonQuery() != 1)
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
        private void btnaddpayment_Click(object sender, EventArgs e)
        {
            DataTable newtable = new DataTable();

            {
                //checks if textboxes are !empty
                if (string.IsNullOrEmpty(memberUsername.Text) || string.IsNullOrEmpty(txtBoxfullname.Text) || string.IsNullOrEmpty(txtBoxpaidAmount.Text) || string.IsNullOrEmpty(txtBoxReference.Text) || string.IsNullOrEmpty(txtBoxBalance.Text) || string.IsNullOrEmpty(txtBoxchA.Text))
                {
                    MessageBox.Show("Please fill in all required details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (add() == true)
                    {
                        //confirmation dialog of creating chipeleganyu account
                        DialogResult result = MessageBox.Show("Are you sure you want to add member payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Payment Added Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear input data
                            clearData();

                        }
                        else
                        {
                            MessageBox.Show("Payment cannot be added it's Ignored", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dbsaconnection.openconnect();
                            MySqlCommand dltpaymnt = new MySqlCommand("Delete from payments where Username = @Username", dbsaconnection.getconnection());
                            dltpaymnt.Parameters.AddWithValue("@Username", memberUsername.Text);
                            dltpaymnt.ExecuteNonQuery();
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
            memberUsername.Text = "";
            txtBoxfullname.Text = "";
            txtBoxpaidAmount.Text = "";
            txtBoxReference.Text = "";
            txtBoxBalance.Text = "";
            txtBoxchA.Text = "";
        }

        private void paymentForm_Load(object sender, EventArgs e)
        {
            //clear combobox
            memberUsername.SelectedIndex = -1;
            txtBoxfullname.Text = "";
            txtBoxchA.Text = "";

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearData();    
        }
        private bool update()
        {
            dbsaconnection.openconnect();
            try
            {
                // Update data in the 'payments' table
                MySqlCommand payment = new MySqlCommand("UPDATE payments SET FullName = @txtBoxfullname, Chipeleganyu_Amount = @txtBoxchA, AmountPaid_MWK = @txtBoxpaidAmount, Reference = @txtBoxReference, Balance_MWK = @txtBoxBalance WHERE Username = @memberUsername", dbsaconnection.getconnection());
                payment.Parameters.Add("@memberUsername", MySqlDbType.VarChar).Value = memberUsername.Text;
                payment.Parameters.Add("@txtBoxfullname", MySqlDbType.VarChar).Value = txtBoxfullname.Text;
                payment.Parameters.Add("@txtBoxchA", MySqlDbType.VarChar).Value = txtBoxchA.Text;
                payment.Parameters.Add("@txtBoxpaidAmount", MySqlDbType.VarChar).Value = txtBoxpaidAmount.Text;
                payment.Parameters.Add("@txtBoxReference", MySqlDbType.VarChar).Value = txtBoxReference.Text;
                payment.Parameters.Add("@txtBoxBalance", MySqlDbType.VarChar).Value = txtBoxBalance.Text;

                if (payment.ExecuteNonQuery() != 1)
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
        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataTable newtable = new DataTable();

            {
                //checks if textboxes are !empty
                if (string.IsNullOrEmpty(memberUsername.Text) || string.IsNullOrEmpty(txtBoxfullname.Text) || string.IsNullOrEmpty(txtBoxpaidAmount.Text) || string.IsNullOrEmpty(txtBoxReference.Text) || string.IsNullOrEmpty(txtBoxBalance.Text) || string.IsNullOrEmpty(txtBoxchA.Text))
                {
                    MessageBox.Show("Please fill in all required details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (update() == true)
                    {
                        //confirmation dialog of creating chipeleganyu account
                        DialogResult result = MessageBox.Show("Are you sure you want to update payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Payment updated Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear input data
                            clearData();

                        }
                        else
                        {
                            MessageBox.Show("Payment update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRiminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Arrange arrange = new Arrange();
            arrange.ShowDialog();
        }
    }
}