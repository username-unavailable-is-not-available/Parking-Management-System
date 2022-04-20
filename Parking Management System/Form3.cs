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
    public partial class AdminPage : Form
    {
        private DataConnection dc { get; set; }

        public AdminPage()
        {
            InitializeComponent();
            this.dc = new DataConnection();

            this.PopulateGridView1();
            this.PopulateGridView2();
            this.dgvUser.ClearSelection();
            this.dgvEmployee.ClearSelection();
        }

        private void PopulateGridView1(string sql = "select * from NewUserTable;")
        {
            var ds = this.dc.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];
        }

        private void PopulateGridView2(string sql = "select * from NewEmployeeTable;")
        {
            var ds = this.dc.ExecuteQuery(sql);

            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void aLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.Show();
        }

        private void ShowUserButton_Click(object sender, EventArgs e)
        {
            this.PopulateGridView1();
        }

        private void ShowEmployeeButton_Click(object sender, EventArgs e)
        {
            this.PopulateGridView2();
        }
    }
}
