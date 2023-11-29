using System;
using System.Windows.Forms;

namespace Parking_Management
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
            dc = new DataConnection();

            PopulateGridView();
            edgvUser.ClearSelection();
        }

        private DataConnection dc { get; }

        private void PopulateGridView(string sql = "select * from NewUserTable;")
        {
            var ds = dc.ExecuteQuery(sql);

            edgvUser.AutoGenerateColumns = false;
            edgvUser.DataSource = ds.Tables[0];
        }

        private void EmployeeDashBoard_Load(object sender, EventArgs e)
        {
        }

        private void eLogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var lp = new LoginPage();
            lp.Show();
        }

        private void GenerateTokenButton_Click(object sender, EventArgs e)
        {
            TokenListBox.Items.Clear();
            var rnd = new Random();
            var tkn1 = "T-";
            var tkn2 = "PMS";
            TokenListBox.Items.Add(tkn1 + rnd.Next(1, 50) + tkn2);
            MessageBox.Show("Successfully Printed Token");
        }

        private void ShowUserButton_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void SeaB_Click(object sender, EventArgs e)
        {
            var sql = "select * from NewUserTable WHERE SlotID like " + SearchBox.Text + "; ";
            PopulateGridView(sql);
        }
    }
}