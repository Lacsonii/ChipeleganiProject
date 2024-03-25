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
    public partial class List : Form
    {
        public List()
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

        private void makepayment_Click(object sender, EventArgs e)
        {
            this.Hide(); Payment pay = new Payment(); pay.ShowDialog();
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

        private void List_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server = localhost; User ID = root; password =; database = chipeleganyu");
            MySqlDataAdapter mS = new MySqlDataAdapter("select * From payments", connect);
            DataTable Dt = new DataTable();
            mS.Fill(Dt);
            listView.DataSource = Dt;
            DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
            Select.HeaderText = "Select";
            listView.Columns.Insert(0, Select);


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
                        // Sort the appliances by Energy_consumption in ascending order
                        DataView lv = dataTable.DefaultView;
                        dataTable = lv.ToTable();
                        listView.DataSource = dataTable;

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
            cbbmonths.Text = "";
            txtBoxactual.Text = "";
            txtBoxtotalAmount.Text = "";
            txtBoxmrcvng.Text = "";
            txtBoxusername.Text = "";

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
                listView.DataSource = Dt;
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

        private void cbbmonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmonths.Text != "")
            {
                double actualAmount = 0;
                double totalAmount = 0;

                // Get the selected month from the ComboBox.
                string selectedMonth = cbbmonths.Text;

                // Iterate through the DataGridView to calculate both amounts.
                foreach (DataGridViewRow row in listView.Rows)
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
                using (MySqlConnection connection = new MySqlConnection("Server = localhost; user ID = root; password =; database = chipeleganyu"))
                {
                    connection.Open();

                    string query = "SELECT Username, FullName FROM receivingmember WHERE Month = @cbbmonths";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cbbmonths", cbbmonths.Text); // Assuming txtboxmonth is a TextBox control

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBoxmrcvng.Text = reader["FullName"].ToString();
                                txtBoxusername.Text = reader["Username"].ToString();
                            }
                            else
                            {
                                txtBoxmrcvng.Text = "***No matching records found***";
                                txtBoxusername.Text = "***No matching records found***";
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
            profile profile = new profile();
            profile.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Show();
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}

