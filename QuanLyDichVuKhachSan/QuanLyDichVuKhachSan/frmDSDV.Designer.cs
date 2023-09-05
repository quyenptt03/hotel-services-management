namespace QuanLyDichVuKhachSan
{
	partial class frmDSDV
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
			System.Windows.Forms.GroupBox gbLocTim;
			System.Windows.Forms.GroupBox gbDSDV;
			this.txtMaTenDV = new System.Windows.Forms.TextBox();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.lblTenMaDV = new System.Windows.Forms.Label();
			this.dgvDSDichVu = new System.Windows.Forms.DataGridView();
			this.rdTen = new System.Windows.Forms.RadioButton();
			this.rdGia = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLammoi = new System.Windows.Forms.Button();
			gbLocTim = new System.Windows.Forms.GroupBox();
			gbDSDV = new System.Windows.Forms.GroupBox();
			gbLocTim.SuspendLayout();
			gbDSDV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbLocTim
			// 
			gbLocTim.Controls.Add(this.btnLammoi);
			gbLocTim.Controls.Add(this.groupBox1);
			gbLocTim.Controls.Add(this.txtMaTenDV);
			gbLocTim.Controls.Add(this.btnCapNhat);
			gbLocTim.Controls.Add(this.btnXoa);
			gbLocTim.Controls.Add(this.btnThem);
			gbLocTim.Controls.Add(this.lblTenMaDV);
			gbLocTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			gbLocTim.Location = new System.Drawing.Point(11, 0);
			gbLocTim.Margin = new System.Windows.Forms.Padding(2);
			gbLocTim.Name = "gbLocTim";
			gbLocTim.Padding = new System.Windows.Forms.Padding(2);
			gbLocTim.Size = new System.Drawing.Size(778, 161);
			gbLocTim.TabIndex = 42;
			gbLocTim.TabStop = false;
			gbLocTim.Text = "Sắp Xếp /Xử lý";
			// 
			// txtMaTenDV
			// 
			this.txtMaTenDV.Location = new System.Drawing.Point(118, 28);
			this.txtMaTenDV.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaTenDV.Name = "txtMaTenDV";
			this.txtMaTenDV.ReadOnly = true;
			this.txtMaTenDV.Size = new System.Drawing.Size(232, 23);
			this.txtMaTenDV.TabIndex = 45;
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(188, 98);
			this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(89, 31);
			this.btnCapNhat.TabIndex = 44;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(335, 101);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(89, 28);
			this.btnXoa.TabIndex = 43;
			this.btnXoa.Text = "Xoá ";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(43, 98);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(89, 27);
			this.btnThem.TabIndex = 42;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// lblTenMaDV
			// 
			this.lblTenMaDV.AutoSize = true;
			this.lblTenMaDV.Location = new System.Drawing.Point(10, 28);
			this.lblTenMaDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTenMaDV.Name = "lblTenMaDV";
			this.lblTenMaDV.Size = new System.Drawing.Size(89, 15);
			this.lblTenMaDV.TabIndex = 38;
			this.lblTenMaDV.Text = "Tên/Mã dịch vụ";
			// 
			// gbDSDV
			// 
			gbDSDV.Controls.Add(this.dgvDSDichVu);
			gbDSDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			gbDSDV.Location = new System.Drawing.Point(11, 176);
			gbDSDV.Margin = new System.Windows.Forms.Padding(2);
			gbDSDV.Name = "gbDSDV";
			gbDSDV.Padding = new System.Windows.Forms.Padding(2);
			gbDSDV.Size = new System.Drawing.Size(778, 318);
			gbDSDV.TabIndex = 43;
			gbDSDV.TabStop = false;
			gbDSDV.Text = "Danh sách dịch vụ";
			// 
			// dgvDSDichVu
			// 
			this.dgvDSDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDSDichVu.BackgroundColor = System.Drawing.Color.White;
			this.dgvDSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSDichVu.GridColor = System.Drawing.Color.DarkGray;
			this.dgvDSDichVu.Location = new System.Drawing.Point(1, 21);
			this.dgvDSDichVu.MultiSelect = false;
			this.dgvDSDichVu.Name = "dgvDSDichVu";
			this.dgvDSDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSDichVu.Size = new System.Drawing.Size(776, 215);
			this.dgvDSDichVu.TabIndex = 17;
			this.dgvDSDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDichVu_CellClick);
			// 
			// rdTen
			// 
			this.rdTen.AutoSize = true;
			this.rdTen.Checked = true;
			this.rdTen.Location = new System.Drawing.Point(15, 26);
			this.rdTen.Name = "rdTen";
			this.rdTen.Size = new System.Drawing.Size(85, 19);
			this.rdTen.TabIndex = 46;
			this.rdTen.TabStop = true;
			this.rdTen.Text = "Tên dịch vụ";
			this.rdTen.UseVisualStyleBackColor = true;
			this.rdTen.CheckedChanged += new System.EventHandler(this.rdTen_CheckedChanged);
			// 
			// rdGia
			// 
			this.rdGia.AutoSize = true;
			this.rdGia.Location = new System.Drawing.Point(15, 59);
			this.rdGia.Name = "rdGia";
			this.rdGia.Size = new System.Drawing.Size(42, 19);
			this.rdGia.TabIndex = 47;
			this.rdGia.Text = "Giá";
			this.rdGia.UseVisualStyleBackColor = true;
			this.rdGia.CheckedChanged += new System.EventHandler(this.rdGia_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTen);
			this.groupBox1.Controls.Add(this.rdGia);
			this.groupBox1.Location = new System.Drawing.Point(523, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sắp xếp";
			// 
			// btnLammoi
			// 
			this.btnLammoi.Location = new System.Drawing.Point(380, 24);
			this.btnLammoi.Margin = new System.Windows.Forms.Padding(2);
			this.btnLammoi.Name = "btnLammoi";
			this.btnLammoi.Size = new System.Drawing.Size(89, 28);
			this.btnLammoi.TabIndex = 49;
			this.btnLammoi.Text = "Tải lại";
			this.btnLammoi.UseVisualStyleBackColor = true;
			this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
			// 
			// frmDSDV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Controls.Add(gbDSDV);
			this.Controls.Add(gbLocTim);
			this.Name = "frmDSDV";
			this.Text = "DanhSachDV";
			this.Load += new System.EventHandler(this.frmDSDV_Load);
			gbLocTim.ResumeLayout(false);
			gbLocTim.PerformLayout();
			gbDSDV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtMaTenDV;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label lblTenMaDV;
		private System.Windows.Forms.DataGridView dgvDSDichVu;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTen;
		private System.Windows.Forms.RadioButton rdGia;
		private System.Windows.Forms.Button btnLammoi;
	}
}