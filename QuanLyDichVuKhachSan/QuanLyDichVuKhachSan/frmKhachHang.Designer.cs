namespace QuanLyDichVuKhachSan
{
	partial class frmKhachHang
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
			this.gbTim_CapNhat = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnLammoi = new System.Windows.Forms.Button();
			this.txtLoai = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mtxtCMND = new System.Windows.Forms.MaskedTextBox();
			this.txtDiaChiKH = new System.Windows.Forms.TextBox();
			this.mtxtSDTKH = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSuaKH = new System.Windows.Forms.Button();
			this.btnXoaKH = new System.Windows.Forms.Button();
			this.btnThemKH = new System.Windows.Forms.Button();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.cbbPhong = new System.Windows.Forms.ComboBox();
			this.gbTim_CapNhat.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			this.SuspendLayout();
			// 
			// gbTim_CapNhat
			// 
			this.gbTim_CapNhat.Controls.Add(this.cbbPhong);
			this.gbTim_CapNhat.Controls.Add(this.label7);
			this.gbTim_CapNhat.Controls.Add(this.btnLammoi);
			this.gbTim_CapNhat.Controls.Add(this.txtLoai);
			this.gbTim_CapNhat.Controls.Add(this.label4);
			this.gbTim_CapNhat.Controls.Add(this.mtxtCMND);
			this.gbTim_CapNhat.Controls.Add(this.txtDiaChiKH);
			this.gbTim_CapNhat.Controls.Add(this.mtxtSDTKH);
			this.gbTim_CapNhat.Controls.Add(this.label5);
			this.gbTim_CapNhat.Controls.Add(this.label6);
			this.gbTim_CapNhat.Controls.Add(this.btnSuaKH);
			this.gbTim_CapNhat.Controls.Add(this.btnXoaKH);
			this.gbTim_CapNhat.Controls.Add(this.btnThemKH);
			this.gbTim_CapNhat.Controls.Add(this.txtTenKH);
			this.gbTim_CapNhat.Controls.Add(this.txtMaKH);
			this.gbTim_CapNhat.Controls.Add(this.label3);
			this.gbTim_CapNhat.Controls.Add(this.label2);
			this.gbTim_CapNhat.Controls.Add(this.label1);
			this.gbTim_CapNhat.Location = new System.Drawing.Point(12, 19);
			this.gbTim_CapNhat.Name = "gbTim_CapNhat";
			this.gbTim_CapNhat.Size = new System.Drawing.Size(776, 200);
			this.gbTim_CapNhat.TabIndex = 2;
			this.gbTim_CapNhat.TabStop = false;
			this.gbTim_CapNhat.Text = "Tìm kiếm và cập nhật";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(446, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "Phòng";
			// 
			// btnLammoi
			// 
			this.btnLammoi.Location = new System.Drawing.Point(178, 153);
			this.btnLammoi.Name = "btnLammoi";
			this.btnLammoi.Size = new System.Drawing.Size(98, 34);
			this.btnLammoi.TabIndex = 24;
			this.btnLammoi.Text = "Làm mới";
			this.btnLammoi.UseVisualStyleBackColor = true;
			this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
			// 
			// txtLoai
			// 
			this.txtLoai.Location = new System.Drawing.Point(505, 90);
			this.txtLoai.Margin = new System.Windows.Forms.Padding(2);
			this.txtLoai.Name = "txtLoai";
			this.txtLoai.Size = new System.Drawing.Size(173, 20);
			this.txtLoai.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(446, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "LoaiKH";
			// 
			// mtxtCMND
			// 
			this.mtxtCMND.Location = new System.Drawing.Point(132, 109);
			this.mtxtCMND.Margin = new System.Windows.Forms.Padding(2);
			this.mtxtCMND.Mask = "000000000000";
			this.mtxtCMND.Name = "mtxtCMND";
			this.mtxtCMND.Size = new System.Drawing.Size(173, 20);
			this.mtxtCMND.TabIndex = 21;
			// 
			// txtDiaChiKH
			// 
			this.txtDiaChiKH.Location = new System.Drawing.Point(505, 14);
			this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(2);
			this.txtDiaChiKH.Name = "txtDiaChiKH";
			this.txtDiaChiKH.Size = new System.Drawing.Size(173, 20);
			this.txtDiaChiKH.TabIndex = 19;
			// 
			// mtxtSDTKH
			// 
			this.mtxtSDTKH.Location = new System.Drawing.Point(505, 57);
			this.mtxtSDTKH.Margin = new System.Windows.Forms.Padding(2);
			this.mtxtSDTKH.Mask = "0000.000.000";
			this.mtxtSDTKH.Name = "mtxtSDTKH";
			this.mtxtSDTKH.Size = new System.Drawing.Size(173, 20);
			this.mtxtSDTKH.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(446, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "SĐT";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(446, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Địa chỉ";
			// 
			// btnSuaKH
			// 
			this.btnSuaKH.Location = new System.Drawing.Point(601, 155);
			this.btnSuaKH.Name = "btnSuaKH";
			this.btnSuaKH.Size = new System.Drawing.Size(94, 34);
			this.btnSuaKH.TabIndex = 9;
			this.btnSuaKH.Text = "Sửa";
			this.btnSuaKH.UseVisualStyleBackColor = true;
			this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
			// 
			// btnXoaKH
			// 
			this.btnXoaKH.Location = new System.Drawing.Point(449, 155);
			this.btnXoaKH.Name = "btnXoaKH";
			this.btnXoaKH.Size = new System.Drawing.Size(98, 34);
			this.btnXoaKH.TabIndex = 8;
			this.btnXoaKH.Text = "Xóa";
			this.btnXoaKH.UseVisualStyleBackColor = true;
			this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
			// 
			// btnThemKH
			// 
			this.btnThemKH.Location = new System.Drawing.Point(307, 153);
			this.btnThemKH.Name = "btnThemKH";
			this.btnThemKH.Size = new System.Drawing.Size(98, 36);
			this.btnThemKH.TabIndex = 6;
			this.btnThemKH.Text = "Thêm";
			this.btnThemKH.UseVisualStyleBackColor = true;
			this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(132, 69);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(173, 20);
			this.txtTenKH.TabIndex = 4;
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(132, 30);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.ReadOnly = true;
			this.txtMaKH.Size = new System.Drawing.Size(173, 20);
			this.txtMaKH.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "CMND/CCCD:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên khách hàng:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khách hàng:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvKhachHang);
			this.groupBox2.Controls.Add(this.gbTim_CapNhat);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(800, 561);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.GridColor = System.Drawing.Color.DarkGray;
			this.dgvKhachHang.Location = new System.Drawing.Point(12, 225);
			this.dgvKhachHang.MultiSelect = false;
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKhachHang.Size = new System.Drawing.Size(776, 171);
			this.dgvKhachHang.TabIndex = 16;
			this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
			this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
			// 
			// cbbPhong
			// 
			this.cbbPhong.FormattingEnabled = true;
			this.cbbPhong.Location = new System.Drawing.Point(505, 125);
			this.cbbPhong.Margin = new System.Windows.Forms.Padding(2);
			this.cbbPhong.Name = "cbbPhong";
			this.cbbPhong.Size = new System.Drawing.Size(173, 21);
			this.cbbPhong.TabIndex = 27;
			// 
			// frmKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmKhachHang";
			this.Text = "Khách hàng";
			this.Load += new System.EventHandler(this.frmKhachHang_Load);
			this.gbTim_CapNhat.ResumeLayout(false);
			this.gbTim_CapNhat.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox gbTim_CapNhat;
		private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
		private System.Windows.Forms.TextBox txtTenKH;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDiaChiKH;
		private System.Windows.Forms.MaskedTextBox mtxtSDTKH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mtxtCMND;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemKH;
		private System.Windows.Forms.DataGridView dgvKhachHang;
		private System.Windows.Forms.TextBox txtLoai;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLammoi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbbPhong;
	}
}