using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parking_Management
{
    public partial class LoginPage : Form
    {
        private readonly DataConnection db = new DataConnection();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (db.connection)
                {
                    var cmd = new SqlCommand("sp_role_login", db.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", LoginIDBox.Text);
                    cmd.Parameters.AddWithValue("@upass", LoginPasswordBox.Text);
                    var rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[4].ToString() == "Admin")
                        {
                            Hide();
                            var ap = new AdminPage();
                            ap.Show();
                        }
                        else if (rd[4].ToString() == "Employee")
                        {
                            Hide();
                            var ep = new EmployeePage();
                            ep.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Login");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}