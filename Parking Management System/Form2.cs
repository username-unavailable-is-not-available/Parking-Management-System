using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Management_System
{
    public partial class EmployeePage : Form
    {
        Random rnd = new Random();

        public EmployeePage()
        {
            InitializeComponent();
        }

        private void EmployeeDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void eLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.Show();
        }

        private void GenerateTokenButton_Click(object sender, EventArgs e)
        {
            TokenListBox.Items.Clear();
            Random rnd = new Random();
            TokenListBox.Items.Add(rnd.Next(1, 50));
            
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            TokenListBox.Items.Clear();
            MessageBox.Show("Print Successful");
        }
    }
}
