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

namespace ParkSystem
{
    public partial class MainForm : Form
    {
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            adminName.Text = UserDetails.Instance.getName();
            slots.Text = CountAvailableSlots() + "";
            carParked.Text = CountParkedVehicle() + "";
        }

        public int CountAvailableSlots()
        {
            int availableSlotCount = 0;

            string query = "SELECT COUNT(*) FROM V_Slots WHERE s_Availability = 1";

            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Execute the query and get the count
                    availableSlotCount = (int)command.ExecuteScalar();
                }
            }

            // Return the count of available slots
            return availableSlotCount;
        }

        public int CountParkedVehicle()
        {
            int availableSlotCount = 0;

            string query = "SELECT COUNT(*) FROM V_Slots WHERE s_Availability = 0";

            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Execute the query and get the count
                    availableSlotCount = (int)command.ExecuteScalar();
                }
            }

            // Return the count of available slots
            return availableSlotCount;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ParkInBtn_Click(object sender, EventArgs e)
        {
            ParkinForm parkinForm = new ParkinForm();
            parkinForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlotsForm slotsForm = new SlotsForm();
            slotsForm.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
