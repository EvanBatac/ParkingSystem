using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkSystem
{
    public partial class Transactions : Form
    {
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";

        public Transactions()
        {
            InitializeComponent();
            LoadTransactions();



        }




      
        private void LoadTransactions()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT plateNumber, vType, vBrand, parkedSlot, id FROM Parkin WHERE vStatus = @Status";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", "CLEARED");

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string plateNumber = reader.GetString(0);
                            string type = reader.GetString(1);
                            string brand = reader.GetString(2);
                            string slot = reader.GetString(3);
                            int id = reader.GetInt32(4); // Read ID

                            // Get vehicle data
                            string[] vehicleData = { plateNumber, type, brand, slot };

                            // Instantiate historyList for each vehicle
                            historyList list = new historyList();

                            // Get transaction data
                            string[] transaction = getTransactionsData(id);
                            if (transaction.Length > 0)
                            {
                                string[] transactionDetails = transaction[0].Split(',');
                                string parkInDateTime = transactionDetails[3]; // Extract parkInDateTime
                                string parkOutDateTime = transactionDetails[4]; // Extract parkOutDateTime
                                string amt = transactionDetails[6]; // Extract amount

                                // Update labels in historyList
                                list.updateLabel(vehicleData[0], vehicleData[1], vehicleData[2], vehicleData[3], parkInDateTime, parkOutDateTime, amt);
                            }

                            // Add historyList to FlowLayoutPanel
                            TrasactionFlowpanel.Controls.Add(list);
                        }
                    }
                }
            }
        }

        public string[] getTransactionsData(int id)
        {
            List<string> transactionsData = new List<string>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT admin_id, v_id, s_id, parkInDateTime, parkOutDateTime, hours, amount FROM Transactions WHERE v_id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int adminId = reader.GetInt32(0);
                            int vehicleId = reader.GetInt32(1);
                            int slotId = reader.GetInt32(2);
                            string parkInDateTime = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            string parkOutDateTime = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            double hours = reader.IsDBNull(5) ? 0.0 : reader.GetDouble(5);
                            double amount = reader.IsDBNull(6) ? 0.0 : reader.GetDouble(6);

                            string transactionData = $"{adminId},{vehicleId},{slotId},{parkInDateTime},{parkOutDateTime},{hours},{amount}";
                            transactionsData.Add(transactionData);
                        }
                    }
                }
            }

            return transactionsData.ToArray();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            SlotsForm slotsForm = new SlotsForm();
            slotsForm.Show();
            this.Close();
        }

        private void ParkInBtn_Click(object sender, EventArgs e)
        {
            ParkinForm parkinForm = new ParkinForm();
            parkinForm.Show();
            this.Close();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }
    }
}

