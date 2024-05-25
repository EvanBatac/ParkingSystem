using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
