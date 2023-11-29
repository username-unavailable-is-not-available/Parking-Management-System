using System;
using System.Windows.Forms;

namespace Parking_Management
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            Dc = new DataConnection();

            PopulateGridView1();
            PopulateGridView2();
            dgvUser.ClearSelection();
            dgvEmployee.ClearSelection();
        }

        private DataConnection Dc { get; }

        private void PopulateGridView1(string sql = "select * from NewUserTable;")
        {
            var ds = Dc.ExecuteQuery(sql);

            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = ds.Tables[0];
        }

        private void PopulateGridView2(string sql = "select * from NewEmployeeTable;")
        {
            var ds = Dc.ExecuteQuery(sql);

            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = ds.Tables[0];
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
        }

        private void aLogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var lp = new LoginPage();
            lp.Show();
        }

        private void ShowUserButton_Click(object sender, EventArgs e)
        {
            PopulateGridView1();
        }

        private void ShowEmployeeButton_Click(object sender, EventArgs e)
        {
            PopulateGridView2();
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

                var sql = "select * from NewUserTable WHERE SlotID= '" + SlotIDBox.Text + "'; ";
                var ds = Dc.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update Info
                    sql = @"update NewUserTable set UserName='" + UserNameBox.Text + @"', 
                            VehicleType='" + VehicleTypeBox.Text + @"', 
                            LicensePlate='" + LicensePlateBox.Text + @"', 
                            RegistrationDate='" + RegistrationDateDTP.Text + @"', 
                            PaymentStatus='" + PaymentStatusCMB.Text + @"', 
                            Role='" + RoleCMB.Text + @"'
                            where SlotID='" + SlotIDBox + @"';";

                    var rowCount = Dc.ExecuteDMLQuery(sql);

                    if (rowCount == 0)
                        MessageBox.Show("Data update operation completed.");
                    else
                        MessageBox.Show("Data update operation failed.");
                }
                else
                {
                    //Insert Info
                    sql = @"insert into NewUserTable values ('" + SlotIDBox.Text + @"', '" + UserNameBox.Text +
                          @"', '" + VehicleTypeBox.Text + @"', 
                                                             '" + LicensePlateBox.Text + @"', '" +
                          RegistrationDateDTP.Text + @"', '" + PaymentStatusCMB.Text + @"', '" + RoleCMB.Text + @"')";


                    var rowCount = Dc.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                        MessageBox.Show("Data insertion operation completed.");
                    else
                        MessageBox.Show("Data insertion operation failed.");
                }

                //this.RefreshContent();
                PopulateGridView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            SlotIDBox.Text = dgvUser.CurrentRow.Cells["SlotID"].Value.ToString();
            UserNameBox.Text = dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
            VehicleTypeBox.Text = dgvUser.CurrentRow.Cells["VehicleType"].Value.ToString();
            LicensePlateBox.Text = dgvUser.CurrentRow.Cells["LicensePlate"].Value.ToString();
            RegistrationDateDTP.Text = dgvUser.CurrentRow.Cells["RegistrationDate"].Value.ToString();
            PaymentStatusCMB.Text = dgvUser.CurrentRow.Cells["PaymentStatus"].Value.ToString();
            RoleCMB.Text = dgvUser.CurrentRow.Cells["Role"].Value.ToString();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(SlotIDBox.Text) || string.IsNullOrEmpty(UserNameBox.Text) ||
                string.IsNullOrEmpty(VehicleTypeBox.Text) || string.IsNullOrEmpty(LicensePlateBox.Text) ||
                string.IsNullOrEmpty(RegistrationDateDTP.Text) || string.IsNullOrEmpty(PaymentStatusCMB.Text) ||
                string.IsNullOrEmpty(RoleCMB.Text) ||
                string.IsNullOrEmpty(EmployeeNameBox.Text) || string.IsNullOrEmpty(UserIDBox.Text) ||
                string.IsNullOrEmpty(ShiftCMB.Text))
                return false;
            return true;
        }

        private void AutoId()
        {
            var sql = "select * from NewUserTable order by SlotID desc;";
            var dt = Dc.ExecuteQueryTable(sql);

            var lastSlotID = dt.Rows[0][0].ToString();
            var temp = lastSlotID.Split('-');
            var no = Convert.ToInt32(temp[0]);
            var newSlotID = (++no).ToString();
            SlotIDBox.Text = newSlotID;
        }

        private void RefreshContent()
        {
            SlotIDBox.Clear();
            UserNameBox.Clear();
            VehicleTypeBox.SelectedIndex = -1;
            LicensePlateBox.Clear();
            RegistrationDateDTP.Text = "";
            PaymentStatusCMB.SelectedIndex = -1;
            RoleCMB.SelectedIndex = -1;
            AutoId();

            EmployeeNameBox.Clear();
            UserIDBox.Clear();
            ShiftCMB.SelectedIndex = -1;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void UserInfoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                    return;
                }

                var SlotID = dgvUser.CurrentRow.Cells[0].Value.ToString();
                var UserName = dgvUser.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from NewUserTable where SlotID='" + SlotID + "';";
                var rowCount = Dc.ExecuteDMLQuery(sql);

                if (rowCount == 1)
                    MessageBox.Show(UserName + " has been deleted from Table.");
                else
                    MessageBox.Show("Data deletion operation failed.");
                PopulateGridView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            EmployeeNameBox.Text = dgvEmployee.CurrentRow.Cells["EmployeeName"].Value.ToString();
            UserIDBox.Text = dgvEmployee.CurrentRow.Cells["UserID"].Value.ToString();
            ShiftCMB.Text = dgvEmployee.CurrentRow.Cells["Shift"].Value.ToString();
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

                var sql = "select * from NewEmployeeTable where UserID= '" + UserIDBox.Text + "'; ";
                var ds = Dc.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update Info
                    sql = "update NewUserTable set EmployeeName='" + EmployeeNameBox.Text + "', UserID='" +
                          UserIDBox.Text + "', Shift='" + ShiftCMB.Text + "', where UserID='" + UserIDBox.Text + "'";

                    var rowCount = Dc.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                        MessageBox.Show("Data update operation completed.");
                    else
                        MessageBox.Show("Data update operation failed.");
                }
                else
                {
                    //Insert Info
                    sql = "insert into NewEmployeeTable values ('" + UserIDBox.Text + "', '" + EmployeeNameBox.Text +
                          "', '" + ShiftCMB.Text + "')";


                    var rowCount = Dc.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                        MessageBox.Show("Data insertion operation completed.");
                    else
                        MessageBox.Show("Data insertion operation failed.");
                }

                RefreshContent();
                PopulateGridView2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmployeeClearButton_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void SlotIDBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var sql = "select * from NewUserTable WHERE SlotID like " + UserAutoSearch.Text + "; ";
            PopulateGridView1(sql);
        }

        private void EmployeeInfoDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                    return;
                }

                var UserID = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                var EmployeeName = dgvEmployee.CurrentRow.Cells[2].Value.ToString();

                var sql = "delete from NewUserTable where UserID like '" + UserID + "'; ";
                var rowCount = Dc.ExecuteDMLQuery(sql);

                if (rowCount == 1)
                    MessageBox.Show(EmployeeName + " has been deleted from Table.");
                else
                    MessageBox.Show("Data deletion operation failed.");
                PopulateGridView2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}