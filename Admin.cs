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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            PopulateMonths();
        }

        private void PopulateMonths()
        {
                        string[] months = {"January", "February", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December"};

                            // Set the AutoCompleteMode and AutoCompleteSource properties.
                                cbbmonths.AutoCompleteMode = AutoCompleteMode.Suggest;
                                    cbbmonths.AutoCompleteSource = AutoCompleteSource.ListItems;

                     // Bind the array of months to the ComboBox.
                 cbbmonths.Items.AddRange(months);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Qestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                        Home home = new Home();
                                home.ShowDialog();
            }
        }

        private void addpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
                    paymentForm paymentForm = new paymentForm();
                            paymentForm.Show();
        }

       

        private void btnmList_Click(object sender, EventArgs e)
        {
            this.Hide();
                    List_of_Accounts accounts = new List_of_Accounts();
                        accounts.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server = localhost; User ID = root; password =; database = chipeleganyu");
                MySqlDataAdapter mS = new MySqlDataAdapter("select * From payments", connect);
                    DataTable Dt = new DataTable();
                        mS.Fill(Dt);
                            Admingv.DataSource = Dt;
                                DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
                                    Select.HeaderText = "Select";
                                        Admingv.Columns.Insert(0, Select);

            MySqlConnection con = new MySqlConnection("Server = localhost; User ID = root; password =; database = chipeleganyu");
                MySqlDataAdapter mySd = new MySqlDataAdapter("select FullName From members", con);
                    DataTable Dtt = new DataTable();
                        mySd.Fill(Dtt);
                            memberlist.DataSource = Dtt;
                                DataGridViewTextBoxColumn pickColumn = new DataGridViewTextBoxColumn();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = search.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; password=; database = chipeleganyu");

                try
                {
                    connect.Open();
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("SELECT * FROM payments WHERE Username LIKE '%" + searchText + "%' OR fullName LIKE '%" + searchText + "%' OR Reference LIKE '%" + searchText + "%'", connect);
                            DataTable dataTable = new DataTable();
                                mAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataView view = dataTable.DefaultView;
                            dataTable = view.ToTable();
                                Admingv.DataSource = dataTable;

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
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshData();
                search.Text = "";
                    cbbmonths.Text = "";
                        txtBoxactual.Text = "";
                    txtBoxtotalAmount.Text = "";
                mRcvng.Text = "";
            userName.Text = "";

        }



        private void RefreshData()
        {
            MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; password=; database = chipeleganyu");

            try
            {
                connect.Open();
                    MySqlDataAdapter mS = new MySqlDataAdapter("SELECT * FROM payments", connect);
                        DataTable Dt = new DataTable();
                            mS.Fill(Dt);
                                Admingv.DataSource = Dt;
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
        //databaseconnection connection = new databaseconnection();
        private void cbbmonths_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            if (cbbmonths.Text != "")
            {
                double actualAmount = 0;
                    double totalAmount = 0;

                // Get the selected month from the ComboBox.
                string selectedMonth = cbbmonths.Text;

                // Iterate through the DataGridView to calculate both amounts.
                foreach (DataGridViewRow row in Admingv.Rows)
                {
                    if (row.Cells["AmountPaid_MWK"].Value != null)
                    {
                        double amountPaid;
                        if (double.TryParse(row.Cells["AmountPaid_MWK"].Value.ToString(), out amountPaid))
                        {
                            actualAmount += amountPaid;
                        }
                    }

                    if (row.Cells["Chipeleganyu_Amount"].Value != null)
                    {
                        double chipeleganyuAmount;
                        if (double.TryParse(row.Cells["Chipeleganyu_Amount"].Value.ToString(), out chipeleganyuAmount))
                        {
                            totalAmount += chipeleganyuAmount;
                        }
                    }
                }

                // Update the "actual amount" and "total amount" TextBoxes.
                txtBoxactual.Text = actualAmount.ToString();
                    txtBoxtotalAmount.Text = totalAmount.ToString();
                //filtering data from receivingmember table
                using (MySqlConnection connection = new MySqlConnection("Server = localhost; user ID = root; password =; database = chipeleganyu"))
                {
                    connection.Open();

                    string query = "SELECT Username, FullName FROM receivingmember WHERE Month = @cbbmonths";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cbbmonths", cbbmonths.Text); //cbbmonths is a textBox

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                mRcvng.Text = reader["FullName"].ToString();//inserting fullname from receivingmember table 
                                userName.Text = reader["Username"].ToString();//inserting username from receivingmember table
                            }
                            else
                            {
                                mRcvng.Text = "***No matching records found***";
                                userName.Text = "***No matching records found***";
                            }
                        }
                    }
                }


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

        private void btnAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
                ProfileDetails pd = new ProfileDetails();
                    pd.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Show();
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
    
}
