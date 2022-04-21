using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parking_Management_System
{
    public partial class LoginPage : Form
    {
        DataConnection db = new DataConnection();

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
                    SqlCommand cmd = new SqlCommand("sp_role_login", db.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uid", LoginIDBox.Text);
                    cmd.Parameters.AddWithValue("@upass", LoginPasswordBox.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[3].ToString() == "Admin")
                        {
                            this.Hide();
                            AdminPage ap = new AdminPage();
                            ap.Show();
                        }
                        else if (rd[3].ToString() == "Employee")
                        {
                            this.Hide();
                            EmployeePage ep = new EmployeePage();
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
