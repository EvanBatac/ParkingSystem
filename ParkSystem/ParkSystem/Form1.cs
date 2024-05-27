using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;

namespace ParkSystem
{
    public partial class LoginForm : Form
    {
        string conn= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True"); 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
              
            }
            else
            {
                textBox2.PasswordChar = '*';
                
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    string selectData = "SELECT id FROM admin WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show("Logged in successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int userId = Convert.ToInt32(dt.Rows[0]["id"]);
                            UserDetails.Instance.setId(userId);
                            insertLogs(UserDetails.Instance.getId());
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }


        public void insertLogs(int id)
        {
            string query = "INSERT INTO Admin_logs (adminID) VALUES (@AdminID)";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@AdminID", id);

                    connection.Open();

                    // Execute the query to insert the log
                    command.ExecuteNonQuery();
                }
            }
        }










    }
}
