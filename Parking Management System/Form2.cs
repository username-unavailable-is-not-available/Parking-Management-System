using System;
using System.Data;
using System.Windows.Forms;

namespace Parking_Management_System
{
    public partial class EmployeePage : Form
    {
        private DataConnection dc { get; set; }

        public EmployeePage()
        {
            InitializeComponent();
            this.dc = new DataConnection();

            this.PopulateGridView();
            this.edgvUser.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from NewUserTable;")
        {
            var ds = this.dc.ExecuteQuery(sql);

            this.edgvUser.AutoGenerateColumns = false;
            this.edgvUser.DataSource = ds.Tables[0];
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
            string tkn1 = "T-";
            string tkn2 = "PMS";
            TokenListBox.Items.Add(tkn1 + rnd.Next(1, 50) + tkn2);
            MessageBox.Show("Successfully Printed Token");

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from NewUserTable WHERE SlotID='" + (this.eSlotIDBox.Text) + "'; ";
            this.PopulateGridView(sql);
        }

        private void ShowUserButton_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }
    }
}
