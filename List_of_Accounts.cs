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
using MySql.Data.Types;

namespace ChipeleganiProject
{
    public partial class List_of_Accounts : Form
    {
        MySqlConnection connection;
        public List_of_Accounts()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = "Server = localhost; userID = root; password=; database = chipeleganyu";

        }

        private void List_of_Accounts_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection("Server = localhost; User ID = root; password =; database = chipeleganyu");
                MySqlDataAdapter MDA = new MySqlDataAdapter("select FullName, Username, NationalID, Gender, DateOfBirth, District, Phone1, Phone2  From members", connect);
                DataTable Dt = new DataTable();
                MDA.Fill(Dt);
                Accounts.DataSource = Dt;
                DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
                Select.HeaderText = "Select";
                Accounts.Columns.Insert(0, Select);

            }
            catch (MySqlConversionException)
            {
                // Handle the exception in a user-friendly way, e.g., displaying a message box
                MessageBox.Show("Error: Unable to convert date/time value to System.DateTime. Please check the data in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You can also log the error or perform other actions here as needed
            }


        }            

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = search.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; password=; database= chipeleganyu");

                try
                {

                    connect.Open();
                    MySqlDataAdapter mAdapter = new MySqlDataAdapter("SELECT * FROM members WHERE Username LIKE '%" + searchText + "%' OR FullName LIKE '%" + searchText + "%' OR Phone1 LIKE '%" + searchText + "%' OR NationalID LIKE '%" + searchText + "%'", connect);
                    DataTable dataTable = new DataTable();
                    mAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Sort the appliances by Energy_consumption in ascending order
                        DataView account = dataTable.DefaultView;
                        dataTable = account.ToTable();
                        Accounts.DataSource = dataTable;

                    }
                    else
                    {
                        MessageBox.Show("Invalid member detail", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        search.Text = "";
                        RefreshData();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter Details to search", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                RefreshData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
            search.Text = "";
            txtBoxrefernumber.Text = "";
        }

        private void RefreshData()
        {
            MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; password=; database = chipeleganyu");

            try
            {
                connect.Open();
                MySqlDataAdapter mS = new MySqlDataAdapter("select FullName, Username, NationalID, Gender, DateOfBirth, District, Phone1, Phone2  From members", connect);
                DataTable Dtt = new DataTable();
                mS.Fill(Dtt);
                Accounts.DataSource = Dtt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error");
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnRiminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request request = new Request();
            request.ShowDialog();
        }

        databaseconnection dbsaconnection = new databaseconnection();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Accounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Member to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBoxrefernumber.Text != "q#*0y7")
            {

                MessageBox.Show("Please click Cancel if you are not sure of deleting.\n\nPlease admin Enter your correct refer Number to proceed", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtBoxrefernumber.Text = "";
                return;
            }

            DialogResult rslt = MessageBox.Show("Member and all their details including payment details will be permanently deleted\n\nAre you sure you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rslt == DialogResult.Yes)
            {
                // Check if there is a selected row in the DataGridView
                if (Accounts.SelectedRows.Count > 0)
                {
                    string username = Accounts.SelectedRows[0].Cells["Username"].Value.ToString();

                    // Delete from the 'members' table
                    using (MySqlConnection connection = new MySqlConnection("Server = localhost; user ID = root; password =; database = chipeleganyu"))
                    {
                        connection.Open();
                        using (MySqlCommand delmember = new MySqlCommand("DELETE FROM members WHERE Username = @Username", connection))
                        {
                            delmember.Parameters.AddWithValue("@Username", username);
                            delmember.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Member Successfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    // Delete from the 'users' table
                    using (MySqlConnection connection = new MySqlConnection("Server = localhost; user ID = root; password =; database = chipeleganyu"))
                    {
                        connection.Open();
                        using (MySqlCommand deluser = new MySqlCommand("DELETE FROM users WHERE Username = @Username", connection))
                        {
                            deluser.Parameters.AddWithValue("@Username", username);
                            deluser.ExecuteNonQuery();
                        }
                    }
                    using (MySqlConnection connection = new MySqlConnection("Server = localhost; user ID = root; password =; database = chipeleganyu"))
                    {
                        connection.Open();
                        using (MySqlCommand delpayment = new MySqlCommand("DELETE FROM payments WHERE Username = @Username", connection))
                        {
                            delpayment.Parameters.AddWithValue("@Username", username);
                            delpayment.ExecuteNonQuery();
                        }
                    }

                    

                    using (MySqlConnection connection = new MySqlConnection("Server = localhost; user ID = root; password =; database = chipeleganyu"))
                    {
                        connection.Open();
                        using (MySqlCommand delrcvngmnth = new MySqlCommand("DELETE FROM receivingmember WHERE Username = @Username", connection))
                        {
                            delrcvngmnth.Parameters.AddWithValue("@Username", username);
                            delrcvngmnth.ExecuteNonQuery();
                        }
                    }
                    // Remove the selected row from the DataGridView
                    Accounts.Rows.Remove(Accounts.SelectedRows[0]);
                    RefreshData();
                    search.Text = "";
                    txtBoxrefernumber.Text = "";
                }
            }
            else
            {
                txtBoxrefernumber.Text = "";
            }
        }
    
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Qestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Show();
            Settings settings = new Settings();
            settings.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.ShowDialog();
        }

        private void Accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}






