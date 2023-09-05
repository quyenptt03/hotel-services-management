using BussinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyDichVuKhachSan
{
	public partial class frmKhachHang : Form
	{

		List<KhachHang> listKH = new List<KhachHang>();
		KhachHang khachhangCurrent = new KhachHang();
		List<Phong> ListPhong = new List<Phong>();
		PhongBL phongBL = new PhongBL();

		public frmKhachHang()
		{
			InitializeComponent();
		}

		private void btnChiTietKH_Click(object sender, EventArgs e)
		{

		}
		private void InitValues()
		{

			DataTable dt_dv = new DataTable();
			dt_dv = phongBL.XemIPPhong();
			cbbPhong.DataSource = dt_dv;
			cbbPhong.DisplayMember = "ID";
			cbbPhong.ValueMember = "ID";

		}
		private void frmKhachHang_Load(object sender, EventArgs e)
		{
			LoadKhachHangDataToListView();
			this.InitValues();
		}
		public void LoadKhachHangDataToListView()
		{

			KhachHangBL khBL = new KhachHangBL();
			listKH = khBL.GetAll();		
			dgvKhachHang.DataSource = listKH;
			dgvKhachHang.Refresh();
			
			
		}

		private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dgvKhachHang.Rows[e.RowIndex];
				txtMaKH.Text = selectedRow.Cells["id"].Value.ToString();
				txtTenKH.Text = selectedRow.Cells["TenKH"].Value.ToString();
				mtxtCMND.Text = selectedRow.Cells["CMND_CCCD"].Value.ToString();
				txtDiaChiKH.Text = selectedRow.Cells["DiaChi"].Value.ToString();
				mtxtSDTKH.Text = selectedRow.Cells["SDT"].Value.ToString();
				txtLoai.Text = selectedRow.Cells["LoaiKH"].Value.ToString();
				cbbPhong.Text = selectedRow.Cells["MaPhong"].Value.ToString();

			}
		}

		private void btnLammoi_Click(object sender, EventArgs e)
		{
			txtMaKH.Text = "";
			txtTenKH.Text = "";
			mtxtCMND.Text = "";
			txtDiaChiKH.Text = "";
			mtxtSDTKH.Text = "";
			txtLoai.Text = "";
			cbbPhong.Text ="";
		}
		public int InsertKhachHang()
		{
			KhachHang khachhang = new KhachHang();
			khachhang.ID = 0;
			if (txtTenKH.Text == "" ||mtxtCMND.Text == "" ||mtxtSDTKH.Text == "" ||txtLoai.Text == "" )
			{

				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			}
			else
			{
				khachhang.TenKH = txtTenKH.Text;
				khachhang.CMND_CCCD = mtxtCMND.Text;
				khachhang.DiaChi = txtDiaChiKH.Text;
				khachhang.SDT = mtxtSDTKH.Text;
				khachhang.MaPhong = Convert.ToInt32(cbbPhong.Text);
				khachhang.LoaiKH = Convert.ToInt32(txtLoai.Text);
				KhachHangBL khBL = new KhachHangBL();
				return khBL.Insert(khachhang);
			}
			return -1;
		}

		private void btnThemKH_Click(object sender, EventArgs e)
		{
			int result = InsertKhachHang();
			if (result > 0) 
			{
				MessageBox.Show("Thêm dữ liệu thành công");
				LoadKhachHangDataToListView();
			}
			else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}

		private void btnXoaKH_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				KhachHangBL khBL = new KhachHangBL();
				int maKH = Convert.ToInt32(txtMaKH.Text);
				if (khBL.Delete1(maKH) > 0)
				{
					MessageBox.Show("Xoá thành công");				
					this.LoadKhachHangDataToListView();
				}
			}
			else MessageBox.Show("Xoá không thành công");

		}
		public int UpdateKhachHang()
		{
			if (txtTenKH.Text == "" || mtxtCMND.Text == "" || mtxtSDTKH.Text == "" || txtLoai.Text == "")
			{
				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			}
			else
			{
				khachhangCurrent.TenKH = txtTenKH.Text;
				khachhangCurrent.CMND_CCCD = mtxtCMND.Text;
				khachhangCurrent.DiaChi = txtDiaChiKH.Text;
				khachhangCurrent.SDT = mtxtSDTKH.Text;
				khachhangCurrent.MaPhong = Convert.ToInt32(cbbPhong.Text);
				khachhangCurrent.LoaiKH = Convert.ToInt32(txtLoai.Text);
				KhachHangBL khBL = new KhachHangBL();
				return khBL.Update1(khachhangCurrent.ID, khachhangCurrent.TenKH, khachhangCurrent.CMND_CCCD, khachhangCurrent.DiaChi, khachhangCurrent.SDT, khachhangCurrent.LoaiKH, khachhangCurrent.MaPhong);
			}
			return -1;
		}

		private void btnSuaKH_Click(object sender, EventArgs e)
		{
			int result = UpdateKhachHang();
			if (result > 0) 
			{
				MessageBox.Show("Cập nhật dữ liệu thành công");
				this.LoadKhachHangDataToListView();
			}
			else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}
	}
}
	

