using System;
using System.Data;
using System.Windows.Forms;

namespace Parking_Management_System
{
    public partial class AdminPage : Form
    {
        private DataConnection Dc { get; set; }

        public AdminPage()
        {
            InitializeComponent();
            this.Dc = new DataConnection();

            this.PopulateGridView1();
            this.PopulateGridView2();
            this.dgvUser.ClearSelection();
            this.dgvEmployee.ClearSelection();
        }

        private void PopulateGridView1(string sql = "select * from NewUserTable;")
        {
            var ds = this.Dc.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];
        }

        private void PopulateGridView2(string sql = "select * from NewEmployeeTable;")
        {
            var ds = this.Dc.ExecuteQuery(sql);

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

        private void UserInfoSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidToSave())
                {
                    MessageBox.Show("Please Fill all the information");
                    return;
                }

                var sql = "select * from NewUserTable WHERE SlotID= '" + (this.SlotIDBox.Text) + "'; ";
                var ds = this.Dc.ExecuteQuery(sql);
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

                    var rowCount = this.Dc.ExecuteDMLQuery(sql);

                    if (rowCount == 0)
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


                    var rowCount = this.Dc.ExecuteDMLQuery(sql);

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

                String.IsNullOrEmpty(this.EmployeeNameBox.Text) || String.IsNullOrEmpty(this.UserIDBox.Text) || String.IsNullOrEmpty(this.ShiftCMB.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void AutoId()
        {
            var sql = "select * from NewUserTable order by SlotID desc;";
            DataTable dt = this.Dc.ExecuteQueryTable(sql);

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
            this.UserIDBox.Clear();
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
                var rowCount = this.Dc.ExecuteDMLQuery(sql);

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
            this.UserIDBox.Text = this.dgvEmployee.CurrentRow.Cells["UserID"].Value.ToString();
            this.ShiftCMB.Text = this.dgvEmployee.CurrentRow.Cells["Shift"].Value.ToString();
        }

        private void EmployeeInfoSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidToSave())
                {
                    MessageBox.Show("Please Fill all the information");
                    return;
                }

                var sql = "select * from NewEmployeeTable where UserID= '" + (this.UserIDBox.Text) + "'; ";
                var ds = this.Dc.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update Info
                    sql = "update NewUserTable set EmployeeName='" + this.EmployeeNameBox.Text + "', UserID='" + this.UserIDBox.Text + "', Shift='" + this.ShiftCMB.Text + "', where UserID='" + this.UserIDBox.Text + "'";

                    var rowCount = this.Dc.ExecuteDMLQuery(sql);

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
                    sql = "insert into NewEmployeeTable values ('" + this.UserIDBox.Text + "', '" + this.EmployeeNameBox.Text + "', '" + this.ShiftCMB.Text + "')";


                    var rowCount = this.Dc.ExecuteDMLQuery(sql);

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

        private void EmployeeClearButton_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void SlotIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var sql = "select * from NewUserTable WHERE SlotID like " + this.UserAutoSearch.Text + "; ";
            this.PopulateGridView1(sql);
        }

        private void EmployeeInfoDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var UserID = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                var EmployeeName = this.dgvEmployee.CurrentRow.Cells[2].Value.ToString();

                var sql = "delete from NewUserTable where UserID like '" + UserID + "'; ";
                var rowCount = this.Dc.ExecuteDMLQuery(sql);

                if (rowCount == 1)
                {
                    MessageBox.Show(EmployeeName + " has been deleted from Table.");
                }
                else
                {
                    MessageBox.Show("Data deletion operation failed.");
                }
                this.PopulateGridView2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
