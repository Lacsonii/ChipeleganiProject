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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
            populateFullnames();
        }

        private void populateFullnames()
        {

            MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; Password=; Database=chipeleganyu");

            connect.Open();

            MySqlDataAdapter mS = new MySqlDataAdapter("SELECT Username, Phone1, Phone2 FROM members", connect);
            DataTable Dt = new DataTable();
            mS.Fill(Dt);

            cbbusername.DataSource = Dt;
            cbbusername.DisplayMember = "Username";
            cbbusername.ValueMember = "Username";

            cbbusername.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbusername.AutoCompleteSource = AutoCompleteSource.ListItems;


            connect.Close();
        }

        private void cbbfullname_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbusername.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)cbbusername.SelectedItem;
                string phone1 = selectedRow["Phone1"].ToString();
                string phone2 = selectedRow["Phone2"].ToString();

                // Populate txtp1 and txtp2 with the phone numbers
                txtBoxphone.Text = phone1;
                txtBoxphone.ReadOnly = true;
                txtBoxphone2.Text = phone2;
                txtBoxphone2.ReadOnly = true;
            }
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_of_Accounts list = new List_of_Accounts();
            list.ShowDialog();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            cbbusername.SelectedIndex = -1;
            txtBoxphone.Text = "";
            txtBoxphone2.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbbusername.Text = "";
            txtBoxphone.Text = "";
            txtBoxphone2.Text = "";
        }
        //bool click = true;
        private void btnSend_Click(object sender, EventArgs e)
        {
            //if (click)
            {
                MessageBox.Show("Currently the button is not functioning", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
                //click = false;
            }
        }

        private void clean()
        {
            cbbusername.Text = "";
            txtBoxphone.Text = "";
            txtBoxphone2.Text = "";
        }

        private void btnsendch_Click(object sender, EventArgs e)
        {
            //if (click)
            {
                MessageBox.Show("Currently the button is not functioning", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
                //click = false;
            }
        }
    }
}
