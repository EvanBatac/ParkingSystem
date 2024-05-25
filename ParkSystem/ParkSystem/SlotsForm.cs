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
    public partial class SlotsForm : Form
    {
        public SlotsForm()
        {
            InitializeComponent();
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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void A01_Click(object sender, EventArgs e)
        {

        }

        private void A02_Click(object sender, EventArgs e)
        {

        }

        private void A03_Click(object sender, EventArgs e)
        {

        }

        private void A04_Click(object sender, EventArgs e)
        {

        }

        private void A05_Click(object sender, EventArgs e)
        {

        }

        private void A07_Click(object sender, EventArgs e)
        {

        }

        private void A08_Click(object sender, EventArgs e)
        {

        }

        private void A09_Click(object sender, EventArgs e)
        {

        }

        private void A10_Click(object sender, EventArgs e)
        {

        }

        private void A11_Click(object sender, EventArgs e)
        {

        }

        private void A12_Click(object sender, EventArgs e)
        {

        }

        private void A13_Click(object sender, EventArgs e)
        {

        }

        private void A14_Click(object sender, EventArgs e)
        {

        }

        private void A15_Click(object sender, EventArgs e)
        {

        }

        private void A17_Click(object sender, EventArgs e)
        {

        }

        private void A18_Click(object sender, EventArgs e)
        {

        }

        private void A19_Click(object sender, EventArgs e)
        {

        }

        private void A20_Click(object sender, EventArgs e)
        {

        }

        private void A21_Click(object sender, EventArgs e)
        {

        }

        private void A22_Click(object sender, EventArgs e)
        {

        }

        private void A23_Click(object sender, EventArgs e)
        {

        }

        private void A25_Click(object sender, EventArgs e)
        {

        }

        private void A26_Click(object sender, EventArgs e)
        {

        }

        private void A27_Click(object sender, EventArgs e)
        {

        }

        private void A28_Click(object sender, EventArgs e)
        {

        }

        private void A30_Click(object sender, EventArgs e)
        {

        }

        private void A31_Click(object sender, EventArgs e)
        {

        }

        private void A32_Click(object sender, EventArgs e)
        {

        }

        private void A33_Click(object sender, EventArgs e)
        {

        }

        private void A34_Click(object sender, EventArgs e)
        {

        }

        private void A35_Click(object sender, EventArgs e)
        {

        }

        private void A36_Click(object sender, EventArgs e)
        {

        }
    }
}
