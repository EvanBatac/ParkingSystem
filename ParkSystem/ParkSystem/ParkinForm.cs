using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ParkSystem
{
    public partial class ParkinForm : Form
    {
        // Define your connection string here
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";

        public ParkinForm()
        {
            InitializeComponent();

            // Add vehicle types to the first ComboBox
            VTypecomboBox.Items.AddRange(new string[] { "Car", "Truck", "Motorcycle" });

            // Add parking slots to the SlotsComboBox
            AddParkingSlots();

            // Attach event handler for selected index change
            VTypecomboBox.SelectedIndexChanged += VTypecomboBox_SelectedIndexChanged;
        }

        private void AddParkingSlots()
        {
            for (int i = 1; i <= 36; i++)
            {
                string slot = $"A{i:D2}";
                SlotscomboBox.Items.Add(slot);
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void ParkInBtn_Click(object sender, EventArgs e)
        {
            // Handle ParkIn button click event
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlotsForm slotsForm = new SlotsForm();
            slotsForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            // Handle label4 click event
        }

        private void VTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected item is not null
            if (VTypecomboBox.SelectedItem != null)
            {
                // Clear the brand ComboBox items
                VBrandcomboBox.Items.Clear();

                // Populate the brand ComboBox based on selected vehicle type
                switch (VTypecomboBox.SelectedItem.ToString())
                {
                    case "Car":
                        VBrandcomboBox.Items.AddRange(new string[] { "Toyota", "Honda", "Ford" });
                        break;
                    case "Truck":
                        VBrandcomboBox.Items.AddRange(new string[] { "Volvo", "Scania", "MAN" });
                        break;
                    case "Motorcycle":
                        VBrandcomboBox.Items.AddRange(new string[] { "Harley-Davidson", "Yamaha", "Suzuki" });
                        break;
                }
            }
        }

        private void VBrandcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle vehicle brand ComboBox selected index change event
        }

        private void PNumberTxtbox_TextChanged(object sender, EventArgs e)
        {
            // Handle plate number text box text change event
        }

        private void SlotscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle slots combo box selected index change event
        }

        private void parkinButton_Click(object sender, EventArgs e)
        {
            // Handle ParkIn button click event
            InsertDataIntoParkinTable();
        }

        private void InsertDataIntoParkinTable()
        {
            // Collect data from form fields
            string plateNumber = PNumberTxtbox.Text;
            string vType = VTypecomboBox.SelectedItem.ToString();
            string vBrand = VBrandcomboBox.SelectedItem.ToString();
            string parkedSlot = SlotscomboBox.SelectedItem.ToString();
            DateTime parkedDate = DateTime.Now.Date;
            TimeSpan parkedInHour = DateTime.Now.TimeOfDay;

            try
            {
                // Establish the SQL connection
                using (SqlConnection connection = new SqlConnection(con))
                {
                    // Create and open the SQL connection
                    connection.Open();

                    // Check if the plate number is already parked
                    string checkPlateNumberQuery = "SELECT COUNT(*) FROM Parkin WHERE plateNumber = @PlateNumber AND vStatus = 'PARKED'";
                    using (SqlCommand checkPlateNumberCommand = new SqlCommand(checkPlateNumberQuery, connection))
                    {
                        checkPlateNumberCommand.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        int count = (int)checkPlateNumberCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            // If the plate number is already parked, show a message and return
                            MessageBox.Show("This vehicle is already parked.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Check if the parking slot is already in use
                    string checkSlotQuery = "SELECT COUNT(*) FROM Parkin WHERE parkedSlot = @ParkedSlot AND vStatus = 'PARKED'";
                    using (SqlCommand checkSlotCommand = new SqlCommand(checkSlotQuery, connection))
                    {
                        checkSlotCommand.Parameters.AddWithValue("@ParkedSlot", parkedSlot);
                        int count = (int)checkSlotCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            // If the parking slot is already in use, show a message and return
                            MessageBox.Show("This slot is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Define the SQL query
                    string query = @"INSERT INTO Parkin (plateNumber, vType, vBrand, parkedDate, parkedInHour, parkedSlot, vStatus)
                                     VALUES (@PlateNumber, @VType, @VBrand, @ParkedDate, @ParkedInHour, @ParkedSlot, @vStatus)";

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        command.Parameters.AddWithValue("@VType", vType);
                        command.Parameters.AddWithValue("@VBrand", vBrand);
                        command.Parameters.AddWithValue("@ParkedDate", parkedDate);
                        command.Parameters.AddWithValue("@ParkedInHour", parkedInHour);
                        command.Parameters.AddWithValue("@ParkedSlot", parkedSlot);
                        command.Parameters.AddWithValue("@vStatus", "PARKED");

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }

                // Optionally, you can clear the form fields after insertion
                ClearFormFields();

                // Show success message
                MessageBox.Show("Vehicle parked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            // Clear all form fields after insertion
            PNumberTxtbox.Text = "";
            VTypecomboBox.SelectedIndex = -1;
            VBrandcomboBox.SelectedIndex = -1;
            SlotscomboBox.SelectedIndex = -1;
        }
    }
}

