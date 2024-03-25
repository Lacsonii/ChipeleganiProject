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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            pupulateusername();
            clearData();
        }

        private void pupulateusername()
        {

            MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; Password=; Database=chipeleganyu");

            connect.Open();

            MySqlDataAdapter mS = new MySqlDataAdapter("SELECT FullName, Username,NationalID,Gender,DateOfBirth,District,Phone1,Phone2 FROM members", connect);
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
                string fllname = selectedRow["FullName"].ToString();
                    string id = selectedRow["NationalID"].ToString();
                        string gn = selectedRow["Gender"].ToString();
                            string dstrct = selectedRow["District"].ToString();
                        string db = selectedRow["DateOfBirth"].ToString();
                    string p1 = selectedRow["Phone1"].ToString();
                string p2 = selectedRow["Phone2"].ToString();

                // Populating all txtboxes
                fullname.Text = fllname;
                    nationalID.Text = id;  
                        gender.Text = gn;
                            district.Text = dstrct;
                                dob.ReadOnly = true;
                            dob.Text = db;
                         dob.BackColor = Color.Gray;
                    phone.Text = p1;
                phone2.Text = p2;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
                Admin admin = new Admin();
                    admin.ShowDialog();
        }
        databaseconnection dbsaconnection = new databaseconnection();
        private bool update()
        {
            dbsaconnection.openconnect();
            try
            {
                MySqlCommand memberpay = new MySqlCommand("UPDATE payments SET FullName = @fullname WHERE Username = @Username", dbsaconnection.getconnection());
                memberpay.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullname.Text;
                memberpay.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username.Text;
                if (memberpay.ExecuteNonQuery() != 1)
                {
                    // Handle the case where the member insertion fails.
                    return true;
                }

                // Update data in the 'payments' table
                MySqlCommand member = new MySqlCommand("UPDATE members SET FullName = @fullname, NationalID = @nationalID, Gender = @gender, District = @district, Phone1 = @phone, Phone2 = @phone2 WHERE Username = @Username", dbsaconnection.getconnection());
                    member.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username.Text;
                        member.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullname.Text;
                            member.Parameters.Add("@nationalID", MySqlDbType.VarChar).Value = nationalID.Text;
                                member.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender.Text;
                            member.Parameters.Add("@district", MySqlDbType.VarChar).Value = district.Text;
                        member.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone.Text;
                member.Parameters.Add("@phone2", MySqlDbType.VarChar).Value = phone2.Text;

                if (member.ExecuteNonQuery() != 1)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable newtable = new DataTable();

            {
                //checks if textboxes are !empty
                if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(fullname.Text) || string.IsNullOrEmpty(nationalID.Text) || string.IsNullOrEmpty(gender.Text) || string.IsNullOrEmpty(district.Text) || string.IsNullOrEmpty(phone.Text) || string.IsNullOrEmpty(phone2.Text))
                {
                    MessageBox.Show("Please fill in all required details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (update() == true)
                    {
                        //confirmation dialog of creating chipeleganyu account
                        DialogResult result = MessageBox.Show("Are you sure you want to edit/change Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Account edited/changed Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear input data
                            clearData();

                        }
                        else
                        {
                            MessageBox.Show("Account edit/change failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            fullname.Text = "";
                    username.Text = "";
                        nationalID.Text = "";
                            gender.Text = "";
                        district.Text = "";
                    phone.Text = "";
                phone2.Text = "";
            dob.Text = "";
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            //prevents the username.text from holding any username
            username.SelectedIndex = -1;
                dob.Text = "";
                    dob.BackColor = default;
            
        }
    }
}
