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

namespace QuanLyDichVuKhachSan
{
	public partial class frmDoiMatKhau : Form
	{
		List<TaiKhoan> listKH = new List<TaiKhoan>();
		TaiKhoan tkCurrent = new TaiKhoan();
		public frmDoiMatKhau()
		{
			InitializeComponent();
		}

	

		public void LoadMatKhauDataToListView()
		{

			TaiKhoanBL khBL = new TaiKhoanBL();
			listKH = khBL.GetAll();

			dgvTaiKhoan.DataSource = listKH;
			dgvTaiKhoan.Refresh();


		}


		

		public int InsertTaiKhoan()
		{
			TaiKhoan tk = new TaiKhoan();
			tk.MaTaiKhoan = txtUserName.Text;
			// Kiểm tra nếu các ô nhập khác rỗng
			if (txtDisplayName.Text == "" || nmAccountType.Text == "" )
			{

				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			}
			else
			{
				//Nhận giá trị Name, Unit, và Notes từ người dùng nhập vào

				tk.PassWord = txtMatKhau.Text;
				tk.TenTaiKhoan = txtDisplayName.Text;

				// Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
				int price = 0;
				try
				{
					// Cố gắng lấy giá trị
					price = int.Parse(nmAccountType.Text);
				}
				catch
				{
					// Nếu sai, gán giá = 0
					price = 0;
				}
				tk.Type = price;
				// Khao báo đối tượng FoodBL từ tầng Business
				TaiKhoanBL khBL = new TaiKhoanBL();
				// Chèn dữ liệu vào bảng
				return khBL.Insert(tk);
			}
			return -1;
		}


		/*
		public int UpdateKhachHang()
		{

			// Kiểm tra nếu các ô nhập khác rỗng
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
				khachhangCurrent.MaPhong = Convert.ToInt32(txtMaPhong.Text);
				// Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
				int price = 0;
				try
				{
					// Cố gắng lấy giá trị
					price = int.Parse(txtLoai.Text);
				}
				catch
				{
					// Nếu sai, gán giá = 0
					price = 0;
				}
				khachhangCurrent.LoaiKH = price;
				// Khao báo đối tượng FoodBL từ tầng Business
				KhachHangBL khBL = new KhachHangBL();
				// Chèn dữ liệu vào bảng
				return khBL.Update1(khachhangCurrent.ID, khachhangCurrent.TenKH, khachhangCurrent.CMND_CCCD, khachhangCurrent.DiaChi, khachhangCurrent.SDT, khachhangCurrent.LoaiKH, khachhangCurrent.MaPhong);
			}
			return -1;
		}

		private void btnSuaKH_Click(object sender, EventArgs e)
		{
			// Gọi phương thức cập nhật dữ liệu
			int result = UpdateKhachHang();
			if (result > 0) // Nếu cập nhật thành công
			{
				// Thông báo kết quả
				MessageBox.Show("Cập nhật dữ liệu thành công");
				// Tải lại dữ liệu cho ListView
				this.LoadKhachHangDataToListView();
			}
			// Nếu thêm không thành công thì thông báo cho người dùng
			else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}
*/

		private void frmDoiMatKhau_Load_1(object sender, EventArgs e)
		{
			LoadMatKhauDataToListView();
			dgvTaiKhoan.Columns["PassWord"].Visible = false;
		}

		private void dgvTaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi hàng được chọn, không phải tiêu đề cột
			{
				DataGridViewRow selectedRow = dgvTaiKhoan.Rows[e.RowIndex];
				// Điền dữ liệu từ các ô trong hàng được chọn vào các TextBox tương ứng
				txtUserName.Text = selectedRow.Cells["MaTaiKhoan"].Value.ToString();
				txtDisplayName.Text = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
				nmAccountType.Text = selectedRow.Cells["Type"].Value.ToString();

			}
		}

		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			// Gọi phương thức thêm dữ liệu
			int result = InsertTaiKhoan();
			if (result > 0) // Nếu thêm thành công
			{
				// Thông báo kết quả
				MessageBox.Show("Thêm dữ liệu thành công");
				// Tải lại dữ liệu cho ListView
				LoadMatKhauDataToListView();
			}
			else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				// Khai báo đối tượng FoodBL từ BusinessLogic
				TaiKhoanBL tkBL = new TaiKhoanBL();
				if (tkBL.Delete(tkCurrent) > 0)// Nếu xoá thành công
				{
					MessageBox.Show("Xoá thực phẩm thành công");
					// Tải tữ liệu lên ListView
					LoadMatKhauDataToListView();
				}
				else MessageBox.Show("Xoá không thành công");
				
			}
			else MessageBox.Show("Xoá không thành công");
		}
		public int UpdateMK()
		{
			TaiKhoan tk = new TaiKhoan();
			tk.MaTaiKhoan = txtUserName.Text;
			// Kiểm tra nếu các ô nhập khác rỗng
			if (tk.PassWord == "" )
			{

				MessageBox.Show("Chưa nhập mật khẩu mới, vui lòng nhập lại");
			}
			else
			{
				//Nhận giá trị Name, Unit, và Notes từ người dùng nhập vào

				tk.PassWord = txtMatKhau.Text;
				tk.TenTaiKhoan = txtDisplayName.Text;

				// Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
				int price = 0;
				try
				{
					// Cố gắng lấy giá trị
					price = int.Parse(nmAccountType.Text);
				}
				catch
				{
					// Nếu sai, gán giá = 0
					price = 0;
				}
				tk.Type = price;
				// Khao báo đối tượng FoodBL từ tầng Business
				TaiKhoanBL khBL = new TaiKhoanBL();
				// Chèn dữ liệu vào bảng
				return khBL.UpdateMK(tk);
			}
			return -1;
		}
		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			// Gọi phương thức thêm dữ liệu
			int result = UpdateMK();
			if (result > 0) // Nếu thêm thành công
			{
				// Thông báo kết quả
				MessageBox.Show("Đổi mật khẩu thành công thành công");
				// Tải lại dữ liệu cho ListView
				LoadMatKhauDataToListView();
			}
			else MessageBox.Show("Thêm đổi mật khẩu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}
	}
}

