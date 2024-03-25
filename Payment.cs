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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            Populateusername();
            Populatepaymentmethod();
        }

        private void Populateusername()
        {
            
            MySqlConnection connect = new MySqlConnection("Server=localhost; User ID=root; Password=; Database=chipeleganyu");

            connect.Open();
            
            MySqlDataAdapter mS = new MySqlDataAdapter("SELECT Username FROM members", connect);
            DataTable Dt = new DataTable();
            mS.Fill(Dt);

            

            cBoxusername.DataSource = Dt;
            cBoxusername.DisplayMember = "Username";
            cBoxusername.ValueMember = "Username";

            cBoxusername.AutoCompleteMode = AutoCompleteMode.Suggest;
            cBoxusername.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            connect.Close();
        }
        private void Populatepaymentmethod()
        {
            string[] paymentmethod = { "Tnm Mpamba", "Airtel Money","National Bank", "Standard Bank", "FDH Bank", "NBS Bank" };
            //suggestion when user is inputting network
            txtBoxpymthd.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxpymthd.AutoCompleteSource = AutoCompleteSource.ListItems;
            // Bind the array of networks to the ComboBox.
            txtBoxpymthd.Items.AddRange(paymentmethod);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            List memberlist = new List();
            memberlist.ShowDialog();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            //inputs date in the combobox
            txtBoxdate.Text = dateTime.Value.ToShortDateString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrEmpty(cBoxusername.Text) || string.IsNullOrEmpty(txtBoxPhone.Text) || string.IsNullOrEmpty(txtBoxPhone.Text) || string.IsNullOrEmpty(txtBoxpymthd.Text) || string.IsNullOrEmpty(txtBoxdate.Text))
                {
                    MessageBox.Show("Please fill in all required details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            

            string otp = Microsoft.VisualBasic.Interaction.InputBox("", "OTP", "");
            if (!string.IsNullOrEmpty(otp))
            {
                //otp entered
                MessageBox.Show("Payment Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleareverything();
            }
            else
            {
                MessageBox.Show("Payment failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleareverything();
                
            }
        }

        private void cleareverything()
        {
            cBoxusername.Text = "";
            txtBoxPhone.Text = "";
            txtBoxpymthd.Text = "";
            txtBoxAmount.Text = "";
            txtBoxaccNo.Text = "";
            dateTime.Value = DateTime.Now;
            txtBoxdate.Text = "";
            txtBoxchA.Text = "";

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cleareverything();
        }

        private void txtBoxpymthd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxpymthd.Text))
            {
                if (txtBoxpymthd.Text == "National Bank" || txtBoxpymthd.Text == "Standard Bank" || txtBoxpymthd.Text == "FDH Bank" || txtBoxpymthd.Text == "NBS Bank")
                {
                    txtBoxaccNo.Text = "";
                    txtBoxPhone.ReadOnly = true;
                    txtBoxPhone.Text = "***Disabled***";
                    txtBoxaccNo.ReadOnly = false;
                    txtBoxchA.Text = "150000";
                    txtBoxchA.ReadOnly = true;
                }
                else if (txtBoxpymthd.Text == "Tnm Mpamba" || txtBoxpymthd.Text == "Airtel Money")
                {
                    txtBoxPhone.Text = "";
                    txtBoxaccNo.ReadOnly = true;
                    txtBoxaccNo.Text = "***Disabled***"; 
                    txtBoxPhone.ReadOnly = false;
                    txtBoxchA.Text = "150000";
                    txtBoxchA.ReadOnly = true;
                }
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // Clear ComboBox when the form loads.
            cBoxusername.SelectedIndex = -1;
        }
    }
}

