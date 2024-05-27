using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkSystem
{
    public partial class SlotsForm : Form
    {

        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";
        ParkOutForm parkOutForm;

        public SlotsForm()
        {
            InitializeComponent();
            DisplayParkedVichicle();
        }



        private void ParkInBtn_Click(object sender, EventArgs e)
        {
            ParkinForm parkinForm = new ParkinForm();
            parkinForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Close();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlotsForm slotsForm = new SlotsForm();
            slotsForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();    
            loginForm.Show();
            this.Close();
        }



            public void DisplayParkedVichicle() {


                string[] btnName = { "A01", "A02", "A03", "A04", "A05", "A06", "A07", "A08", "A09", "A10",
                         "A11", "A12", "A13", "A14", "A15", "A16", "A17", "A18", "A19", "A20",
                         "A21", "A22", "A23", "A24", "A25", "A26", "A27", "A28", "A29", "A30",
                         "A31", "A32", "A33", "A34", "A35", "A36" };

                Button[] btn = { A01, A02, A03, A04, A05, A06, A07, A08, A09, A10,
                     A11, A12, A13, A14, A15, A16, A17, A18, A19, A20,
                     A21, A22, A23, A24, A25, A26, A27, A28, A29, A30,
                     A31, A32, A33, A34, A35, A36 };

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        string query = "SELECT * FROM Parkin";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string parkedSlot = reader.GetString(6);
                                    string vStatus = reader.IsDBNull(8) ? null : reader.GetString(8);

                                     if (btnName.Contains(parkedSlot) && vStatus != null && vStatus.Equals("PARKED"))
                                    {
                                         int index = Array.IndexOf(btnName, parkedSlot);
                                        Image car = Image.FromFile(@"C:\Users\KARLOWEN\Source\Repos\ParkingSystem4\ParkSystem\ParkSystem\Resources\parkIcon11.png");
                                        Image car1 = Image.FromFile(@"C:\Users\KARLOWEN\Source\Repos\ParkingSystem4\ParkSystem\ParkSystem\Resources\parkIcon2.png");

                                btn[index].BackgroundImage = index < 12 ? car : car1;
                                    }
                                }
                            }
                        }
            }
            }

        public void refreshParking() {
            Button[] btn = { A01, A02, A03, A04, A05, A06, A07, A08, A09, A10,
                     A11, A12, A13, A14, A15, A16, A17, A18, A19, A20,
                     A21, A22, A23, A24, A25, A26, A27, A28, A29, A30,
                     A31, A32, A33, A34, A35, A36 };

            for (int i = 0; i < btn.Length; i++) {
                btn[i].BackgroundImage = null;
                btn[i].BackColor = Color.FromArgb(96, 93, 104);
            }

        }


        private void ParkingRecordAddedHandler(object sender, EventArgs e)
        {
            refreshParking();
            DisplayParkedVichicle();
        }



        public bool isOccupied(string slot)
        {
            bool occupied = false;
            string query = "SELECT s_Availability FROM V_Slots WHERE s_loc = @Slot";

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Slot", slot);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int availability = Convert.ToInt32(result);
                            if (availability == 1)
                            {
                                occupied = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return occupied;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A06")) {
                parkOutForm = new ParkOutForm("A06");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A16"))
            {
                parkOutForm = new ParkOutForm("A16");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A24"))
            {
                parkOutForm = new ParkOutForm("A24");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A29"))
            {
                parkOutForm = new ParkOutForm("A29");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
            
            }
        }

        private void A01_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A01"))
            {
                parkOutForm = new ParkOutForm("A01");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();

            }
        }

        private void A02_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A02"))
            {
                parkOutForm = new ParkOutForm("A02");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void A03_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A03"))
            {
                parkOutForm = new ParkOutForm("A03");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void A04_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A04"))
            {
                parkOutForm = new ParkOutForm("A04");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void A05_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A05"))
            {
                parkOutForm = new ParkOutForm("A05");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
         
            }
        }

        private void A07_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A07"))
            {
                parkOutForm = new ParkOutForm("A07");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void A08_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A08"))
            {
                parkOutForm = new ParkOutForm("A08");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
            
            }
        }

        private void A09_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A09"))
            {
                parkOutForm = new ParkOutForm("A09");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A10_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A10"))
            {
                parkOutForm = new ParkOutForm("A10");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A11_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A11"))
            {
                parkOutForm = new ParkOutForm("A11");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A12_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A12"))
            {
                parkOutForm = new ParkOutForm("A12");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A13_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A13"))
            {
                parkOutForm = new ParkOutForm("A13");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A14_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A14"))
            {
                parkOutForm = new ParkOutForm("A14");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
              
            }
        }

        private void A15_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A15"))
            {
                parkOutForm = new ParkOutForm("A15");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
           
            }
        }

        private void A17_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A17"))
            {
                parkOutForm = new ParkOutForm("A17");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A18_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A18"))
            {
                parkOutForm = new ParkOutForm("A18");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
             
            }
        }

        private void A19_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A19"))
            {
                parkOutForm = new ParkOutForm("A19");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A20_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A20"))
            {

                parkOutForm = new ParkOutForm("A20");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A21_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A21"))
            {
                parkOutForm = new ParkOutForm("A21");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A22_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A22"))
            {
                parkOutForm = new ParkOutForm("A22");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
             
            }
        }

        private void A23_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A23"))
            {
                parkOutForm = new ParkOutForm("A23");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A25_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A25"))
            {
                parkOutForm = new ParkOutForm("A25");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A26_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A26"))
            {
                parkOutForm = new ParkOutForm("A26");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A27_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A27"))
            {
                parkOutForm = new ParkOutForm("A27");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A28_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A28"))
            {
                parkOutForm = new ParkOutForm("A28");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void A30_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A30"))
            {
                parkOutForm = new ParkOutForm("A30");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A31_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A31"))
            {
                parkOutForm = new ParkOutForm("A31");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A32_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A32"))
            {
                parkOutForm = new ParkOutForm("A32");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
            }
        }

        private void A33_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A33"))
            {
                parkOutForm = new ParkOutForm("A33");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A34_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A34"))
            {
                parkOutForm = new ParkOutForm("A34");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void A35_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A35"))
            {
                parkOutForm = new ParkOutForm("A35");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
                
            }
        }

        private void A36_Click(object sender, EventArgs e)
        {
            if (!isOccupied("A36"))
            {
                parkOutForm = new ParkOutForm("A36");
                parkOutForm.ParkoutHandler += ParkingRecordAddedHandler;
                parkOutForm.ShowDialog();
               
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
