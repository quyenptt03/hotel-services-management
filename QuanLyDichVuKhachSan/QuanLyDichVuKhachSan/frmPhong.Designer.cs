namespace QuanLyDichVuKhachSan
{
	partial class frmPhong
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTenKhachChu = new System.Windows.Forms.TextBox();
			this.txtSoNguoi = new System.Windows.Forms.TextBox();
			this.cbbPhong = new System.Windows.Forms.ComboBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnCapNhap = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPhong = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTenKhachChu);
			this.groupBox1.Controls.Add(this.txtSoNguoi);
			this.groupBox1.Controls.Add(this.cbbPhong);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Controls.Add(this.btnCapNhap);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 178);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin";
			// 
			// txtTenKhachChu
			// 
			this.txtTenKhachChu.Location = new System.Drawing.Point(165, 107);
			this.txtTenKhachChu.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenKhachChu.Name = "txtTenKhachChu";
			this.txtTenKhachChu.Size = new System.Drawing.Size(179, 20);
			this.txtTenKhachChu.TabIndex = 17;
			// 
			// txtSoNguoi
			// 
			this.txtSoNguoi.Location = new System.Drawing.Point(165, 66);
			this.txtSoNguoi.Margin = new System.Windows.Forms.Padding(2);
			this.txtSoNguoi.Name = "txtSoNguoi";
			this.txtSoNguoi.Size = new System.Drawing.Size(179, 20);
			this.txtSoNguoi.TabIndex = 18;
			// 
			// cbbPhong
			// 
			this.cbbPhong.FormattingEnabled = true;
			this.cbbPhong.Items.AddRange(new object[] {
            "Phòng 101",
            "Phòng 102",
            "Phòng 103",
            "Phòng 104",
            "Phòng 201",
            "Phòng 202",
            "Phòng 203",
            "Phòng 204",
            "Phòng V301",
            "Phòng V302",
            "Phòng 303",
            "Phòng 304"});
			this.cbbPhong.Location = new System.Drawing.Point(165, 28);
			this.cbbPhong.Margin = new System.Windows.Forms.Padding(2);
			this.cbbPhong.Name = "cbbPhong";
			this.cbbPhong.Size = new System.Drawing.Size(179, 21);
			this.cbbPhong.TabIndex = 16;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(655, 59);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(86, 33);
			this.btnXoa.TabIndex = 13;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnCapNhap
			// 
			this.btnCapNhap.Location = new System.Drawing.Point(516, 59);
			this.btnCapNhap.Margin = new System.Windows.Forms.Padding(2);
			this.btnCapNhap.Name = "btnCapNhap";
			this.btnCapNhap.Size = new System.Drawing.Size(97, 33);
			this.btnCapNhap.TabIndex = 14;
			this.btnCapNhap.Text = "Cập Nhập";
			this.btnCapNhap.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(388, 59);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(86, 33);
			this.btnThem.TabIndex = 15;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 114);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Tên Khách Chủ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 73);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Số Người";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Số Phòng";
			// 
			// dgvPhong
			// 
			this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
			this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhong.GridColor = System.Drawing.Color.DarkGray;
			this.dgvPhong.Location = new System.Drawing.Point(12, 212);
			this.dgvPhong.MultiSelect = false;
			this.dgvPhong.Name = "dgvPhong";
			this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPhong.Size = new System.Drawing.Size(776, 231);
			this.dgvPhong.TabIndex = 15;
			// 
			// frmPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Controls.Add(this.dgvPhong);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmPhong";
			this.Text = "frmPhong";
			this.Load += new System.EventHandler(this.frmPhong_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTenKhachChu;
		private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.ComboBox cbbPhong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dgvPhong;
	}
}