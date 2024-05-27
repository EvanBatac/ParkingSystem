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
        public partial class historyList : UserControl
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";

            public historyList()
            {
                InitializeComponent();
          /*  string[] vehicleData = getVehicle();
            if (vehicleData.Length > 0)
            {
                string[] vehicleDetails = vehicleData[0].Split(',');
                string parkDateTime = ""; // Initialize with empty string
                string parkoutDateTime = ""; // Initialize with empty string
                string amt = ""; // Initialize with empty string

                int id;
                if (int.TryParse(vehicleData[4], out id))
                {
                    string[] transaction = getTransactionsData(id);
                    if (transaction.Length > 0)
                    {
                        string[] transactionDetails = transaction[0].Split(',');
                        parkDateTime = transactionDetails[3]; // Extract parkInDateTime
                        parkoutDateTime = transactionDetails[4]; // Extract parkOutDateTime
                        amt = transactionDetails[6]; // Extract amount
                    }
                }
                else
                {
                    // Handle case when vehicle ID cannot be parsed
                }

                updateLabel(vehicleDetails[0], vehicleDetails[1], vehicleDetails[2], vehicleDetails[3], parkDateTime, parkoutDateTime, amt);
            }
            else
            {
                // Handle case when no vehicles are found
            }
*/





            //TrasactionFlowpanel 
            
        }

        public void updateLabel(string platenum, string vType, string vbrand, string slot, string parkDateTime, string parkoutDateTime, string amt)
        {
            PlateNum.Text = platenum;
            Type.Text = vType;
            Brand.Text = vbrand;
            Sloc.Text = slot;
            ParkDateTime.Text = parkDateTime;
            ParkoutDateTime.Text = parkoutDateTime;
            Amount.Text = amt;
        }

      
    


             private void label5_Click(object sender, EventArgs e)
            {

            }

            private void label6_Click(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }
        }
    }
