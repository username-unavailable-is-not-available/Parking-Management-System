using System;
using System.Data;
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

        private void UserAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from NewUserTable WHERE SlotID='" + (this.SlotIDBox.Text) + "'; ";
            this.PopulateGridView1(sql);
        }

        private void UserInfoSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please Fill all the information");
                    return;
                }

                var sql = "select * from NewUserTable WHERE SlotID= '" + (this.SlotIDBox.Text) + "'; ";
                var ds = this.dc.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update Info
                    sql = @"update NewUserTable set UserName='" + this.UserNameBox.Text + @"', 
                            VehicleType='" + this.VehicleTypeBox.Text + @"', 
                            LicensePlate='" + this.LicensePlateBox.Text + @"', 
                            RegistrationDate='" + this.RegistrationDateDTP.Text + @"', 
                            PaymentStatus='" + this.PaymentStatusCMB.Text + @"', 
                            Role='" + this.RoleCMB.Text + @"'
                            where SlotID='" + this.SlotIDBox + @"';";

                    var rowCount = this.dc.ExecuteDMLQuery(sql);

                    if (rowCount >= 1)
                    {
                        MessageBox.Show("Data update operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data update operation failed.");
                    }
                }
                else
                {
                    //Insert Info
                    sql = @"insert into NewUserTable values ('" + this.SlotIDBox.Text + @"', '" + this.UserNameBox.Text + @"', '" + this.VehicleTypeBox.Text + @"', 
                                                             '" + this.LicensePlateBox.Text + @"', '" + this.RegistrationDateDTP.Text + @"', '" + this.PaymentStatusCMB.Text + @"', '" + this.RoleCMB.Text + @"')";


                    var rowCount = this.dc.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data insertion operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion operation failed.");
                    }
                }

                //this.RefreshContent();
                this.PopulateGridView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.SlotIDBox.Text = this.dgvUser.CurrentRow.Cells["SlotID"].Value.ToString();
            this.UserNameBox.Text = this.dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
            this.VehicleTypeBox.Text = this.dgvUser.CurrentRow.Cells["VehicleType"].Value.ToString();
            this.LicensePlateBox.Text = this.dgvUser.CurrentRow.Cells["LicensePlate"].Value.ToString();
            this.RegistrationDateDTP.Text = this.dgvUser.CurrentRow.Cells["RegistrationDate"].Value.ToString();
            this.PaymentStatusCMB.Text = this.dgvUser.CurrentRow.Cells["PaymentStatus"].Value.ToString();
            this.RoleCMB.Text = this.dgvUser.CurrentRow.Cells["Role"].Value.ToString();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.SlotIDBox.Text) || String.IsNullOrEmpty(this.UserNameBox.Text) ||
                String.IsNullOrEmpty(this.VehicleTypeBox.Text) || String.IsNullOrEmpty(this.LicensePlateBox.Text) ||
                String.IsNullOrEmpty(this.RegistrationDateDTP.Text) || String.IsNullOrEmpty(this.PaymentStatusCMB.Text) || String.IsNullOrEmpty(this.RoleCMB.Text) ||
                String.IsNullOrEmpty(this.EmployeeNameBox.Text) || String.IsNullOrEmpty(this.EmployeeIDBox.Text) || String.IsNullOrEmpty(this.ShiftCMB.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void AutoId()
        {
            var sql = "select * from NewUserTable order by SlotID desc;";
            DataTable dt = this.dc.ExecuteQueryTable(sql);

            string lastSlotID = dt.Rows[0][0].ToString();
            string[] temp = lastSlotID.Split('-');
            int no = Convert.ToInt32(temp[0]);
            string newSlotID = (++no).ToString();
            this.SlotIDBox.Text = newSlotID;
        }

        private void RefreshContent()
        {
            this.SlotIDBox.Clear();
            this.UserNameBox.Clear();
            this.VehicleTypeBox.SelectedIndex = -1;
            this.LicensePlateBox.Clear();
            this.RegistrationDateDTP.Text = "";
            this.PaymentStatusCMB.SelectedIndex = -1;
            this.RoleCMB.SelectedIndex = -1;
            this.AutoId();

            this.EmployeeNameBox.Clear();
            this.EmployeeIDBox.Clear();
            this.ShiftCMB.SelectedIndex = -1;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void UserInfoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var SlotID = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                var UserName = this.dgvUser.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from NewUserTable where SlotID='" + SlotID + "';";
                var rowCount = this.dc.ExecuteDMLQuery(sql);

                if (rowCount == 1)
                {
                    MessageBox.Show(UserName + " has been deleted from Table.");
                }
                else
                {
                    MessageBox.Show("Data deletion operation failed.");
                }
                this.PopulateGridView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.EmployeeNameBox.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeName"].Value.ToString();
            this.EmployeeIDBox.Text = this.dgvEmployee.CurrentRow.Cells["UserID"].Value.ToString();
            this.ShiftCMB.Text = this.dgvEmployee.CurrentRow.Cells["Shift"].Value.ToString();
        }

        private void EmployeeInfoSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please Fill all the information");
                    return;
                }

                var sql = "select * from NewEmployeeTable WHERE UserID= '" + (this.EmployeeIDBox.Text) + "'; ";
                var ds = this.dc.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update Info
                    sql = @"update NewUserTable set UserName='" + this.UserNameBox.Text + @"', 
                            Shift='" + this.ShiftCMB.Text + @"',
                            where UserID='" + this.EmployeeIDBox.Text + @"';";

                    var rowCount = this.dc.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data update operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data update operation failed.");
                    }
                }
                else
                {
                    //Insert Info
                    sql = "insert into NewEmployeeTable values ('" + this.EmployeeNameBox.Text + "', '" + this.EmployeeIDBox.Text + "', '" + this.ShiftCMB.Text + "')";


                    var rowCount = this.dc.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data insertion operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion operation failed.");
                    }
                }

                this.RefreshContent();
                this.PopulateGridView2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmployeeInfoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployee.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var UserID = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                var EmployeeName = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from NewEmployeeTable where UserID='" + EmployeeIDBox + "';";
                var rowCount = this.dc.ExecuteDMLQuery(sql);

                if (rowCount >= 1)
                {
                    MessageBox.Show(EmployeeName + " has been deleted from Table.");
                }
                else
                {
                    MessageBox.Show("Data deletion operation failed.");
                }
                this.PopulateGridView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmployeeClearButton_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }
    }
}
