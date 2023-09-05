namespace QuanLyDichVuKhachSan
{
	partial class frmDoanhThu
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
			this.gbChonTG = new System.Windows.Forms.GroupBox();
			this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
			this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
			this.btnThongKeDay = new System.Windows.Forms.Button();
			this.btnXem = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
			this.btnLoad = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
			this.dtpNgay = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.gbChonTG.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
			this.SuspendLayout();
			// 
			// gbChonTG
			// 
			this.gbChonTG.Controls.Add(this.dtpNgay);
			this.gbChonTG.Controls.Add(this.label3);
			this.gbChonTG.Controls.Add(this.dtpDenNgay);
			this.gbChonTG.Controls.Add(this.dtpTuNgay);
			this.gbChonTG.Controls.Add(this.label2);
			this.gbChonTG.Controls.Add(this.label1);
			this.gbChonTG.Location = new System.Drawing.Point(32, 12);
			this.gbChonTG.Name = "gbChonTG";
			this.gbChonTG.Size = new System.Drawing.Size(304, 170);
			this.gbChonTG.TabIndex = 2;
			this.gbChonTG.TabStop = false;
			this.gbChonTG.Text = "Chọn khoảng thời gian";
			// 
			// dtpDenNgay
			// 
			this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
			this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDenNgay.Location = new System.Drawing.Point(86, 73);
			this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
			this.dtpDenNgay.Name = "dtpDenNgay";
			this.dtpDenNgay.Size = new System.Drawing.Size(184, 20);
			this.dtpDenNgay.TabIndex = 7;
			// 
			// dtpTuNgay
			// 
			this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
			this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTuNgay.Location = new System.Drawing.Point(86, 34);
			this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(2);
			this.dtpTuNgay.Name = "dtpTuNgay";
			this.dtpTuNgay.Size = new System.Drawing.Size(184, 20);
			this.dtpTuNgay.TabIndex = 6;
			// 
			// btnThongKeDay
			// 
			this.btnThongKeDay.Location = new System.Drawing.Point(356, 99);
			this.btnThongKeDay.Name = "btnThongKeDay";
			this.btnThongKeDay.Size = new System.Drawing.Size(103, 23);
			this.btnThongKeDay.TabIndex = 5;
			this.btnThongKeDay.Text = "Thống kê ngày";
			this.btnThongKeDay.UseVisualStyleBackColor = true;
			this.btnThongKeDay.Click += new System.EventHandler(this.btnThongKeDay_Click);
			// 
			// btnXem
			// 
			this.btnXem.Location = new System.Drawing.Point(356, 46);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(103, 23);
			this.btnXem.TabIndex = 2;
			this.btnXem.Text = "Thống kê";
			this.btnXem.UseVisualStyleBackColor = true;
			this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Đến ngày:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày:";
			// 
			// dgvDoanhThu
			// 
			this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
			this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDoanhThu.GridColor = System.Drawing.Color.DarkGray;
			this.dgvDoanhThu.Location = new System.Drawing.Point(32, 201);
			this.dgvDoanhThu.MultiSelect = false;
			this.dgvDoanhThu.Name = "dgvDoanhThu";
			this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDoanhThu.Size = new System.Drawing.Size(731, 381);
			this.dgvDoanhThu.TabIndex = 17;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(356, 159);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(103, 23);
			this.btnLoad.TabIndex = 18;
			this.btnLoad.Text = "Tải lại";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(523, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(140, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "Tổng doanh thu:";
			// 
			// txtTongDoanhThu
			// 
			this.txtTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongDoanhThu.Location = new System.Drawing.Point(508, 99);
			this.txtTongDoanhThu.Name = "txtTongDoanhThu";
			this.txtTongDoanhThu.ReadOnly = true;
			this.txtTongDoanhThu.Size = new System.Drawing.Size(169, 26);
			this.txtTongDoanhThu.TabIndex = 7;
			this.txtTongDoanhThu.TextChanged += new System.EventHandler(this.txtTongDoanhThu_TextChanged);
			// 
			// dtpNgay
			// 
			this.dtpNgay.CustomFormat = "dd/MM/yyyy";
			this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgay.Location = new System.Drawing.Point(86, 112);
			this.dtpNgay.Margin = new System.Windows.Forms.Padding(2);
			this.dtpNgay.Name = "dtpNgay";
			this.dtpNgay.Size = new System.Drawing.Size(184, 20);
			this.dtpNgay.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Chọn ngày";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// frmDoanhThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(866, 594);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txtTongDoanhThu);
			this.Controls.Add(this.btnXem);
			this.Controls.Add(this.btnThongKeDay);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dgvDoanhThu);
			this.Controls.Add(this.gbChonTG);
			this.Name = "frmDoanhThu";
			this.Text = "Báo cáo doanh thu";
			this.Load += new System.EventHandler(this.frmDoanhThu_Load);
			this.gbChonTG.ResumeLayout(false);
			this.gbChonTG.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gbChonTG;
		private System.Windows.Forms.Button btnThongKeDay;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpDenNgay;
		private System.Windows.Forms.DateTimePicker dtpTuNgay;
		private System.Windows.Forms.DataGridView dgvDoanhThu;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTongDoanhThu;
		private System.Windows.Forms.DateTimePicker dtpNgay;
		private System.Windows.Forms.Label label3;
	}
}