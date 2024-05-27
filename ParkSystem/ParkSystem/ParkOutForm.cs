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
    public partial class ParkOutForm : Form
    {
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";
        public event EventHandler ParkoutHandler;

        public ParkOutForm(string slot)
        {
            InitializeComponent();
            UpdateLabels(slot);
        }

        public string[] getVehiclFromSlot(string slot)
        {
            List<string> vehiclesData = new List<string>();

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "SELECT plateNumber, vType, vBrand, parkedDate, parkedInHour FROM Parkin WHERE parkedSlot = @Slot AND vStatus = @Status";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Slot", slot);
                    command.Parameters.AddWithValue("@Status", "PARKED");

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string plateNumber = reader.GetString(0);
                            string type = reader.GetString(1);
                            string brand = reader.GetString(2);
                            DateTime parkedDate = reader.GetDateTime(3);
                            TimeSpan parkedInHour = reader.GetTimeSpan(4);

                            // Format the parked time as "h:mm:ss tt" (e.g., 5:3:34 PM)
                            string formattedTime = parkedDate.Add(parkedInHour).ToString("h:mm:ss tt");

                            string vehicleData = $"Plate Number: {plateNumber}, Type: {type}, Brand: {brand}, Parked Date: {parkedDate.ToShortDateString()},{formattedTime}";
                            vehiclesData.Add(vehicleData);
                        }
                    }
                }
            }

            return vehiclesData.ToArray();
        }

        public void UpdateLabels(string slot)
        {
            string[] vehicleData = getVehiclFromSlot(slot);

            if (vehicleData.Length > 0)
            {
                string[] vehicleInfo = vehicleData[0].Split(',');
                string plateNumber = vehicleInfo[0].Split(':')[1].Trim();
                string type = vehicleInfo[1].Split(':')[1].Trim();
                string brand = vehicleInfo[2].Split(':')[1].Trim();
                string parkedDate = vehicleInfo[3].Split(':')[1].Trim();
                string parkedTime = vehicleInfo[4];

                pNumber.Text = plateNumber;
                vType.Text = type;
                vBrand.Text = brand;
                vSlot.Text = slot;
                parkinDate.Text = parkedDate;
                parkinTime.Text = parkedTime;



            }
            else

            {
                MessageBox.Show("No vehicles found in the specified slot.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void parkoutButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(totalAmount.Text);
            if (number != 0.0) {
            insertToTransaction(pNumber.Text);
                updateSlot(vSlot.Text);
                clearVehicle(pNumber.Text);
                
                this.Close();
                ParkoutHandler?.Invoke(this, EventArgs.Empty);

                pNumber.Text = "";
        }else
                MessageBox.Show($"Please press Set button first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

    public void insertToTransaction(string platenum)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                             
                     DateTime parkOutDateTime = DateTime.Now;
                    int admin_id = UserDetails.Instance.getId();
                    int slotId = GetSlotId(vSlot.Text); // Implement this function to get slot ID based on slot name

                    // Insert into Transactions table
                    string insertQuery = @"INSERT INTO Transactions (admin_id, v_id, s_id, parkInDateTime, parkOutDateTime, hours, amount)
                                   VALUES (@AdminID, @VID, @SID, @ParkInDateTime, @ParkOutDateTime, @Hours, @Amount)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@AdminID", admin_id);
                        insertCmd.Parameters.AddWithValue("@VID", getId(platenum)+"");
                        insertCmd.Parameters.AddWithValue("@SID", slotId);
                        insertCmd.Parameters.AddWithValue("@ParkInDateTime", DateTime.Parse(parkinDate.Text + " " + parkinTime.Text).ToString("yyyy-MM-dd HH:mm:ss"));
                        insertCmd.Parameters.AddWithValue("@ParkOutDateTime", parkOutDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        insertCmd.Parameters.AddWithValue("@Hours", Duration.Text); // Assuming Duration.Text contains the total hours as a string
                        insertCmd.Parameters.AddWithValue("@Amount", totalAmount.Text); // Assuming totalAmount.Text contains the total amount as a string

                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int getId(string plateNum)
        {
            int v_id = 0;
            string query = "SELECT id FROM Parkin WHERE plateNumber = @PlateNumber AND vStatus = 'PARKED'";

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PlateNumber", plateNum);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            v_id = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Vehicle not found or already cleared.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return v_id;
        }




        private int GetSlotId(string slot)
        {
            // Implement this method to get the slot ID based on slot name
            int slotId = 0;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                string query = "SELECT s_id FROM V_Slots WHERE s_loc = @Slot";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Slot", slot);

                    slotId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return slotId;
        }

        public void updateSlot(string selectedSlot)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    string query = "UPDATE V_Slots SET s_Availability = 1 WHERE s_loc = @SelectedSlot";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SelectedSlot", selectedSlot);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void clearVehicle(string plateNum) {

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    string query = "UPDATE Parkin SET vStatus = 'CLEARED' WHERE plateNumber = @PlateNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PlateNumber", plateNum);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string arrivalDateTime = parkinDate.Text + " " + parkinTime.Text;
            DateTime parkin = DateTime.Parse(arrivalDateTime);

            DateTime selectedDateTime = parkOutDate.Value.Date + parkOutTime.Value.TimeOfDay;

             TimeSpan duration = selectedDateTime - parkin;

            Duration.Text = ((int)duration.TotalHours).ToString();


            double flagdownCharge = 0;
            double additionalChargePerHour = 0;


            switch (vType.Text)
            {
                case "MOTORBIKE":
                    flagdownCharge = 20;
                    additionalChargePerHour = 5;
                    break;
                case "SUV":
                case "VAN":
                    flagdownCharge = 40;
                    additionalChargePerHour = 20;
                    break;
                case "SEDAN":
                    flagdownCharge = 30;
                    additionalChargePerHour = 15;
                    break;
                default:
                    // Handle unknown car type
                    MessageBox.Show("Unknown car type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


            double amt = 0;
            if (duration.TotalHours > 0)    
            {
                amt = flagdownCharge + ((int)duration.TotalHours * additionalChargePerHour);
            }
            else
            {
                // Compute only flagdown charge if duration is zero
                amt = flagdownCharge;
            }


            totalAmount.Text = amt.ToString("0.00");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
