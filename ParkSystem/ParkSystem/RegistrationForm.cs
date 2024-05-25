using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Threading;

namespace ParkSystem
{
    public partial class RegistrationForm : Form
    {        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True");

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    String checkUsername = "SELECT * FROM admin WHERE username = '"
                        + textBox1.Text.Trim() + "' ";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(textBox1.Text + "already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else {
                            if (textBox2.Text != textBox3.Text)
                            {
                                MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            string insertData = "INSERT INTO admin (username, password, date_created )" +
                                "VALUES(@username, @password, @date)";

                            DateTime date = DateTime.Now;

                            using (SqlCommand cmd = new SqlCommand(insertData, con)) {
                                cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    con.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }
    }
}
