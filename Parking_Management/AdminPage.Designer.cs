namespace Parking_Management
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.SlotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowUserButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VehicleTypeBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PaymentStatusCMB = new System.Windows.Forms.ComboBox();
            this.RoleCMB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RegistrationDateDTP = new System.Windows.Forms.DateTimePicker();
            this.LicensePlateBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.SlotIDBox = new System.Windows.Forms.TextBox();
            this.UserInfoDelete = new System.Windows.Forms.Button();
            this.UserClearButton = new System.Windows.Forms.Button();
            this.UserInfoSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserAutoSearch = new System.Windows.Forms.TextBox();
            this.aLogoutButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ShiftCMB = new System.Windows.Forms.ComboBox();
            this.EmployeeClearButton = new System.Windows.Forms.Button();
            this.EmployeeNameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeInfoSave = new System.Windows.Forms.Button();
            this.EmployeeInfoDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ShowEmployeeButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.aLogoutButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 477);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 39);
            this.label11.TabIndex = 19;
            this.label11.Text = "Admin Page";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Controls.Add(this.dgvUser);
            this.panel2.Controls.Add(this.ShowUserButton);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.UserAutoSearch);
            this.panel2.Location = new System.Drawing.Point(322, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 430);
            this.panel2.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(195, 188);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(49, 23);
            this.SearchBtn.TabIndex = 27;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlotID,
            this.UserName,
            this.VehicleType,
            this.LicensePlate,
            this.RegistrationDate,
            this.PaymentStatus,
            this.Role});
            this.dgvUser.Location = new System.Drawing.Point(3, 214);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(411, 213);
            this.dgvUser.TabIndex = 25;
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // SlotID
            // 
            this.SlotID.DataPropertyName = "SlotID";
            this.SlotID.HeaderText = "Slot ID";
            this.SlotID.Name = "SlotID";
            this.SlotID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User-Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // LicensePlate
            // 
            this.LicensePlate.DataPropertyName = "LicensePlate";
            this.LicensePlate.HeaderText = "License Plate";
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.ReadOnly = true;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.HeaderText = "Registration Date";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "Payment Status";
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // ShowUserButton
            // 
            this.ShowUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUserButton.Location = new System.Drawing.Point(320, 188);
            this.ShowUserButton.Name = "ShowUserButton";
            this.ShowUserButton.Size = new System.Drawing.Size(94, 23);
            this.ShowUserButton.TabIndex = 24;
            this.ShowUserButton.Text = "Show User";
            this.ShowUserButton.UseVisualStyleBackColor = true;
            this.ShowUserButton.Click += new System.EventHandler(this.ShowUserButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Search By SlotID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.VehicleTypeBox);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.PaymentStatusCMB);
            this.panel4.Controls.Add(this.RoleCMB);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.RegistrationDateDTP);
            this.panel4.Controls.Add(this.LicensePlateBox);
            this.panel4.Controls.Add(this.UserNameBox);
            this.panel4.Controls.Add(this.SlotIDBox);
            this.panel4.Controls.Add(this.UserInfoDelete);
            this.panel4.Controls.Add(this.UserClearButton);
            this.panel4.Controls.Add(this.UserInfoSave);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 148);
            this.panel4.TabIndex = 18;
            // 
            // VehicleTypeBox
            // 
            this.VehicleTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleTypeBox.FormattingEnabled = true;
            this.VehicleTypeBox.Items.AddRange(new object[] {
            "Car",
            "Bike",
            "Micro"});
            this.VehicleTypeBox.Location = new System.Drawing.Point(339, 7);
            this.VehicleTypeBox.Name = "VehicleTypeBox";
            this.VehicleTypeBox.Size = new System.Drawing.Size(57, 21);
            this.VehicleTypeBox.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(237, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Role";
            // 
            // PaymentStatusCMB
            // 
            this.PaymentStatusCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentStatusCMB.FormattingEnabled = true;
            this.PaymentStatusCMB.Items.AddRange(new object[] {
            "Paid",
            "Due"});
            this.PaymentStatusCMB.Location = new System.Drawing.Point(112, 111);
            this.PaymentStatusCMB.Name = "PaymentStatusCMB";
            this.PaymentStatusCMB.Size = new System.Drawing.Size(100, 21);
            this.PaymentStatusCMB.TabIndex = 20;
            // 
            // RoleCMB
            // 
            this.RoleCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleCMB.FormattingEnabled = true;
            this.RoleCMB.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.RoleCMB.Location = new System.Drawing.Point(315, 34);
            this.RoleCMB.Name = "RoleCMB";
            this.RoleCMB.Size = new System.Drawing.Size(81, 21);
            this.RoleCMB.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(237, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Vehicle Type";
            // 
            // RegistrationDateDTP
            // 
            this.RegistrationDateDTP.CustomFormat = "yyyy-MM-dd";
            this.RegistrationDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RegistrationDateDTP.Location = new System.Drawing.Point(112, 85);
            this.RegistrationDateDTP.Name = "RegistrationDateDTP";
            this.RegistrationDateDTP.Size = new System.Drawing.Size(100, 20);
            this.RegistrationDateDTP.TabIndex = 17;
            // 
            // LicensePlateBox
            // 
            this.LicensePlateBox.Location = new System.Drawing.Point(112, 59);
            this.LicensePlateBox.Name = "LicensePlateBox";
            this.LicensePlateBox.Size = new System.Drawing.Size(100, 20);
            this.LicensePlateBox.TabIndex = 11;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(112, 33);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameBox.TabIndex = 10;
            // 
            // SlotIDBox
            // 
            this.SlotIDBox.Enabled = false;
            this.SlotIDBox.Location = new System.Drawing.Point(112, 7);
            this.SlotIDBox.Name = "SlotIDBox";
            this.SlotIDBox.Size = new System.Drawing.Size(100, 20);
            this.SlotIDBox.TabIndex = 9;
            this.SlotIDBox.TextChanged += new System.EventHandler(this.SlotIDBox_TextChanged);
            // 
            // UserInfoDelete
            // 
            this.UserInfoDelete.Location = new System.Drawing.Point(317, 76);
            this.UserInfoDelete.Name = "UserInfoDelete";
            this.UserInfoDelete.Size = new System.Drawing.Size(79, 25);
            this.UserInfoDelete.TabIndex = 15;
            this.UserInfoDelete.Text = "Delete";
            this.UserInfoDelete.UseVisualStyleBackColor = true;
            this.UserInfoDelete.Click += new System.EventHandler(this.UserInfoDelete_Click);
            // 
            // UserClearButton
            // 
            this.UserClearButton.Location = new System.Drawing.Point(240, 107);
            this.UserClearButton.Name = "UserClearButton";
            this.UserClearButton.Size = new System.Drawing.Size(156, 25);
            this.UserClearButton.TabIndex = 16;
            this.UserClearButton.Text = "Clear";
            this.UserClearButton.UseVisualStyleBackColor = true;
            this.UserClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UserInfoSave
            // 
            this.UserInfoSave.Location = new System.Drawing.Point(240, 76);
            this.UserInfoSave.Name = "UserInfoSave";
            this.UserInfoSave.Size = new System.Drawing.Size(75, 25);
            this.UserInfoSave.TabIndex = 14;
            this.UserInfoSave.Text = "Save";
            this.UserInfoSave.UseVisualStyleBackColor = true;
            this.UserInfoSave.Click += new System.EventHandler(this.UserInfoSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Registration Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Payment Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SlotID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "License Plate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Info";
            // 
            // UserAutoSearch
            // 
            this.UserAutoSearch.Location = new System.Drawing.Point(124, 188);
            this.UserAutoSearch.Name = "UserAutoSearch";
            this.UserAutoSearch.Size = new System.Drawing.Size(65, 20);
            this.UserAutoSearch.TabIndex = 1;
            this.UserAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aLogoutButton
            // 
            this.aLogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLogoutButton.Location = new System.Drawing.Point(640, 3);
            this.aLogoutButton.Name = "aLogoutButton";
            this.aLogoutButton.Size = new System.Drawing.Size(96, 23);
            this.aLogoutButton.TabIndex = 0;
            this.aLogoutButton.Text = "Log Out";
            this.aLogoutButton.UseVisualStyleBackColor = true;
            this.aLogoutButton.Click += new System.EventHandler(this.aLogoutButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.dgvEmployee);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.EmployeeInfoSave);
            this.panel3.Controls.Add(this.EmployeeInfoDelete);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.ShowEmployeeButton);
            this.panel3.Location = new System.Drawing.Point(3, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 333);
            this.panel3.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserID,
            this.EmployeeName,
            this.Shift});
            this.dgvEmployee.Location = new System.Drawing.Point(3, 177);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(307, 153);
            this.dgvEmployee.TabIndex = 26;
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ShiftCMB);
            this.panel5.Controls.Add(this.EmployeeClearButton);
            this.panel5.Controls.Add(this.EmployeeNameBox);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.UserIDBox);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(3, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 100);
            this.panel5.TabIndex = 23;
            // 
            // ShiftCMB
            // 
            this.ShiftCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCMB.FormattingEnabled = true;
            this.ShiftCMB.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.ShiftCMB.Location = new System.Drawing.Point(97, 68);
            this.ShiftCMB.Name = "ShiftCMB";
            this.ShiftCMB.Size = new System.Drawing.Size(100, 21);
            this.ShiftCMB.TabIndex = 23;
            // 
            // EmployeeClearButton
            // 
            this.EmployeeClearButton.Location = new System.Drawing.Point(201, 25);
            this.EmployeeClearButton.Name = "EmployeeClearButton";
            this.EmployeeClearButton.Size = new System.Drawing.Size(103, 53);
            this.EmployeeClearButton.TabIndex = 27;
            this.EmployeeClearButton.Text = "Clear";
            this.EmployeeClearButton.UseVisualStyleBackColor = true;
            this.EmployeeClearButton.Click += new System.EventHandler(this.EmployeeClearButton_Click);
            // 
            // EmployeeNameBox
            // 
            this.EmployeeNameBox.Location = new System.Drawing.Point(97, 39);
            this.EmployeeNameBox.Name = "EmployeeNameBox";
            this.EmployeeNameBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Shift";
            // 
            // UserIDBox
            // 
            this.UserIDBox.Location = new System.Drawing.Point(97, 12);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(100, 20);
            this.UserIDBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name";
            // 
            // EmployeeInfoSave
            // 
            this.EmployeeInfoSave.Location = new System.Drawing.Point(3, 148);
            this.EmployeeInfoSave.Name = "EmployeeInfoSave";
            this.EmployeeInfoSave.Size = new System.Drawing.Size(75, 23);
            this.EmployeeInfoSave.TabIndex = 3;
            this.EmployeeInfoSave.Text = "Save";
            this.EmployeeInfoSave.UseVisualStyleBackColor = true;
            this.EmployeeInfoSave.Click += new System.EventHandler(this.EmployeeInfoSave_Click);
            // 
            // EmployeeInfoDelete
            // 
            this.EmployeeInfoDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeInfoDelete.Location = new System.Drawing.Point(84, 148);
            this.EmployeeInfoDelete.Name = "EmployeeInfoDelete";
            this.EmployeeInfoDelete.Size = new System.Drawing.Size(75, 23);
            this.EmployeeInfoDelete.TabIndex = 2;
            this.EmployeeInfoDelete.Text = "Delete";
            this.EmployeeInfoDelete.UseVisualStyleBackColor = true;
            this.EmployeeInfoDelete.Click += new System.EventHandler(this.EmployeeInfoDelete_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Employee Info";
            // 
            // ShowEmployeeButton
            // 
            this.ShowEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEmployeeButton.Location = new System.Drawing.Point(169, 148);
            this.ShowEmployeeButton.Name = "ShowEmployeeButton";
            this.ShowEmployeeButton.Size = new System.Drawing.Size(141, 23);
            this.ShowEmployeeButton.TabIndex = 0;
            this.ShowEmployeeButton.Text = "Show Employee";
            this.ShowEmployeeButton.UseVisualStyleBackColor = true;
            this.ShowEmployeeButton.Click += new System.EventHandler(this.ShowEmployeeButton_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee-Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Shift
            // 
            this.Shift.DataPropertyName = "Shift";
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 501);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aLogoutButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EmployeeInfoSave;
        private System.Windows.Forms.Button EmployeeInfoDelete;
        private System.Windows.Forms.Button ShowEmployeeButton;
        private System.Windows.Forms.TextBox UserAutoSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UserClearButton;
        private System.Windows.Forms.Button UserInfoDelete;
        private System.Windows.Forms.Button UserInfoSave;
        private System.Windows.Forms.TextBox LicensePlateBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox SlotIDBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmployeeNameBox;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ShowUserButton;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.ComboBox PaymentStatusCMB;
        private System.Windows.Forms.ComboBox RoleCMB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker RegistrationDateDTP;
        private System.Windows.Forms.ComboBox VehicleTypeBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button EmployeeClearButton;
        private System.Windows.Forms.ComboBox ShiftCMB;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
    }
}