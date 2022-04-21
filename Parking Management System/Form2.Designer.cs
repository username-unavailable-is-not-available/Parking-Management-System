namespace Parking_Management_System
{
    partial class EmployeePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.eLogoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edgvUser = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TokenListBox = new System.Windows.Forms.ListBox();
            this.GenerateTokenButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WorkShift = new System.Windows.Forms.TextBox();
            this.eSlotIDBox = new System.Windows.Forms.TextBox();
            this.ShowUserButton = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicencePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgvUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE PAGE";
            // 
            // eLogoutButton
            // 
            this.eLogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLogoutButton.Location = new System.Drawing.Point(602, 3);
            this.eLogoutButton.Name = "eLogoutButton";
            this.eLogoutButton.Size = new System.Drawing.Size(96, 23);
            this.eLogoutButton.TabIndex = 4;
            this.eLogoutButton.Text = "Log Out";
            this.eLogoutButton.UseVisualStyleBackColor = true;
            this.eLogoutButton.Click += new System.EventHandler(this.eLogoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.ShowUserButton);
            this.panel1.Controls.Add(this.eSlotIDBox);
            this.panel1.Controls.Add(this.edgvUser);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(10, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 201);
            this.panel1.TabIndex = 5;
            // 
            // edgvUser
            // 
            this.edgvUser.AllowUserToAddRows = false;
            this.edgvUser.AllowUserToDeleteRows = false;
            this.edgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.LicencePlate,
            this.PaymentStatus,
            this.Role});
            this.edgvUser.Location = new System.Drawing.Point(3, 72);
            this.edgvUser.Name = "edgvUser";
            this.edgvUser.ReadOnly = true;
            this.edgvUser.Size = new System.Drawing.Size(396, 129);
            this.edgvUser.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(137, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Search By SlotID";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(252, 13);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(147, 20);
            this.SearchBox.TabIndex = 9;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "USER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(421, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 201);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TokenListBox);
            this.panel3.Controls.Add(this.GenerateTokenButton);
            this.panel3.Location = new System.Drawing.Point(7, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 115);
            this.panel3.TabIndex = 10;
            // 
            // TokenListBox
            // 
            this.TokenListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenListBox.FormattingEnabled = true;
            this.TokenListBox.ItemHeight = 25;
            this.TokenListBox.Location = new System.Drawing.Point(54, 83);
            this.TokenListBox.Name = "TokenListBox";
            this.TokenListBox.Size = new System.Drawing.Size(154, 29);
            this.TokenListBox.TabIndex = 14;
            // 
            // GenerateTokenButton
            // 
            this.GenerateTokenButton.Location = new System.Drawing.Point(3, 9);
            this.GenerateTokenButton.Name = "GenerateTokenButton";
            this.GenerateTokenButton.Size = new System.Drawing.Size(254, 68);
            this.GenerateTokenButton.TabIndex = 14;
            this.GenerateTokenButton.Text = "Generate Token";
            this.GenerateTokenButton.UseVisualStyleBackColor = true;
            this.GenerateTokenButton.Click += new System.EventHandler(this.GenerateTokenButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "GUEST";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.WorkShift);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.eLogoutButton);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 303);
            this.panel4.TabIndex = 7;
            // 
            // WorkShift
            // 
            this.WorkShift.Location = new System.Drawing.Point(10, 70);
            this.WorkShift.Name = "WorkShift";
            this.WorkShift.Size = new System.Drawing.Size(101, 20);
            this.WorkShift.TabIndex = 13;
            this.WorkShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eSlotIDBox
            // 
            this.eSlotIDBox.Enabled = false;
            this.eSlotIDBox.Location = new System.Drawing.Point(3, 46);
            this.eSlotIDBox.Name = "eSlotIDBox";
            this.eSlotIDBox.Size = new System.Drawing.Size(100, 20);
            this.eSlotIDBox.TabIndex = 20;
            // 
            // ShowUserButton
            // 
            this.ShowUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUserButton.Location = new System.Drawing.Point(305, 46);
            this.ShowUserButton.Name = "ShowUserButton";
            this.ShowUserButton.Size = new System.Drawing.Size(94, 23);
            this.ShowUserButton.TabIndex = 25;
            this.ShowUserButton.Text = "Show User";
            this.ShowUserButton.UseVisualStyleBackColor = true;
            this.ShowUserButton.Click += new System.EventHandler(this.ShowUserButton_Click);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User-Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // LicencePlate
            // 
            this.LicencePlate.DataPropertyName = "LicensePlate";
            this.LicencePlate.HeaderText = "License Plate";
            this.LicencePlate.Name = "LicencePlate";
            this.LicencePlate.ReadOnly = true;
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
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 326);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Page";
            this.Load += new System.EventHandler(this.EmployeeDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgvUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eLogoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button GenerateTokenButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox WorkShift;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox TokenListBox;
        private System.Windows.Forms.DataGridView edgvUser;
        private System.Windows.Forms.TextBox eSlotIDBox;
        private System.Windows.Forms.Button ShowUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicencePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}