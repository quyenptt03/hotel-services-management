namespace QuanLyDichVuKhachSan
{
	partial class frmDoiMatKhau
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
			this.btnDeleteAccount = new System.Windows.Forms.Button();
			this.btnEditAccount = new System.Windows.Forms.Button();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
			this.panel28 = new System.Windows.Forms.Panel();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnResetPassword = new System.Windows.Forms.Button();
			this.panel23 = new System.Windows.Forms.Panel();
			this.nmAccountType = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.panel24 = new System.Windows.Forms.Panel();
			this.txtDisplayName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel25 = new System.Windows.Forms.Panel();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
			this.panel28.SuspendLayout();
			this.panel23.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
			this.panel24.SuspendLayout();
			this.panel25.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDeleteAccount
			// 
			this.btnDeleteAccount.Location = new System.Drawing.Point(250, 365);
			this.btnDeleteAccount.Name = "btnDeleteAccount";
			this.btnDeleteAccount.Size = new System.Drawing.Size(75, 32);
			this.btnDeleteAccount.TabIndex = 7;
			this.btnDeleteAccount.Text = "Xóa";
			this.btnDeleteAccount.UseVisualStyleBackColor = true;
			this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
			// 
			// btnEditAccount
			// 
			this.btnEditAccount.Location = new System.Drawing.Point(149, 365);
			this.btnEditAccount.Name = "btnEditAccount";
			this.btnEditAccount.Size = new System.Drawing.Size(75, 32);
			this.btnEditAccount.TabIndex = 6;
			this.btnEditAccount.Text = "Sửa";
			this.btnEditAccount.UseVisualStyleBackColor = true;
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Location = new System.Drawing.Point(47, 365);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(75, 32);
			this.btnAddAccount.TabIndex = 4;
			this.btnAddAccount.Text = "Thêm";
			this.btnAddAccount.UseVisualStyleBackColor = true;
			this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
			// 
			// dgvTaiKhoan
			// 
			this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
			this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTaiKhoan.GridColor = System.Drawing.Color.DarkGray;
			this.dgvTaiKhoan.Location = new System.Drawing.Point(409, 30);
			this.dgvTaiKhoan.MultiSelect = false;
			this.dgvTaiKhoan.Name = "dgvTaiKhoan";
			this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTaiKhoan.Size = new System.Drawing.Size(324, 347);
			this.dgvTaiKhoan.TabIndex = 16;
			this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick_1);
			// 
			// panel28
			// 
			this.panel28.Controls.Add(this.txtMatKhau);
			this.panel28.Controls.Add(this.label13);
			this.panel28.Location = new System.Drawing.Point(12, 79);
			this.panel28.Name = "panel28";
			this.panel28.Size = new System.Drawing.Size(373, 56);
			this.panel28.TabIndex = 18;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(158, 17);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(212, 20);
			this.txtMatKhau.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(3, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(74, 18);
			this.label13.TabIndex = 0;
			this.label13.Text = "Mật Khẩu";
			// 
			// btnResetPassword
			// 
			this.btnResetPassword.Location = new System.Drawing.Point(194, 291);
			this.btnResetPassword.Name = "btnResetPassword";
			this.btnResetPassword.Size = new System.Drawing.Size(191, 32);
			this.btnResetPassword.TabIndex = 21;
			this.btnResetPassword.Text = "Đặt lại mật khẩu";
			this.btnResetPassword.UseVisualStyleBackColor = true;
			this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
			// 
			// panel23
			// 
			this.panel23.Controls.Add(this.nmAccountType);
			this.panel23.Controls.Add(this.label10);
			this.panel23.Location = new System.Drawing.Point(12, 212);
			this.panel23.Name = "panel23";
			this.panel23.Size = new System.Drawing.Size(373, 56);
			this.panel23.TabIndex = 20;
			// 
			// nmAccountType
			// 
			this.nmAccountType.Location = new System.Drawing.Point(158, 18);
			this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmAccountType.Name = "nmAccountType";
			this.nmAccountType.Size = new System.Drawing.Size(55, 20);
			this.nmAccountType.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 18);
			this.label10.TabIndex = 0;
			this.label10.Text = "Loại tài khoản:";
			// 
			// panel24
			// 
			this.panel24.Controls.Add(this.txtDisplayName);
			this.panel24.Controls.Add(this.label11);
			this.panel24.Location = new System.Drawing.Point(12, 150);
			this.panel24.Name = "panel24";
			this.panel24.Size = new System.Drawing.Size(373, 56);
			this.panel24.TabIndex = 19;
			// 
			// txtDisplayName
			// 
			this.txtDisplayName.Location = new System.Drawing.Point(158, 17);
			this.txtDisplayName.Name = "txtDisplayName";
			this.txtDisplayName.Size = new System.Drawing.Size(212, 20);
			this.txtDisplayName.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(3, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(91, 18);
			this.label11.TabIndex = 0;
			this.label11.Text = "Tên hiển thị:";
			// 
			// panel25
			// 
			this.panel25.Controls.Add(this.txtUserName);
			this.panel25.Controls.Add(this.label12);
			this.panel25.Location = new System.Drawing.Point(12, 17);
			this.panel25.Name = "panel25";
			this.panel25.Size = new System.Drawing.Size(373, 56);
			this.panel25.TabIndex = 17;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(158, 17);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(212, 20);
			this.txtUserName.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 18);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(105, 18);
			this.label12.TabIndex = 0;
			this.label12.Text = "Tên tài khoản:";
			// 
			// frmDoiMatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 434);
			this.Controls.Add(this.panel28);
			this.Controls.Add(this.btnResetPassword);
			this.Controls.Add(this.panel23);
			this.Controls.Add(this.panel24);
			this.Controls.Add(this.panel25);
			this.Controls.Add(this.dgvTaiKhoan);
			this.Controls.Add(this.btnDeleteAccount);
			this.Controls.Add(this.btnEditAccount);
			this.Controls.Add(this.btnAddAccount);
			this.Name = "frmDoiMatKhau";
			this.Text = "Đổi mật khẩu";
			this.Load += new System.EventHandler(this.frmDoiMatKhau_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
			this.panel28.ResumeLayout(false);
			this.panel28.PerformLayout();
			this.panel23.ResumeLayout(false);
			this.panel23.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
			this.panel24.ResumeLayout(false);
			this.panel24.PerformLayout();
			this.panel25.ResumeLayout(false);
			this.panel25.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDeleteAccount;
		private System.Windows.Forms.Button btnEditAccount;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.DataGridView dgvTaiKhoan;
		private System.Windows.Forms.Panel panel28;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnResetPassword;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.NumericUpDown nmAccountType;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel24;
		private System.Windows.Forms.TextBox txtDisplayName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel25;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label12;
	}
}