
using BussinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyDichVuKhachSan
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}
		
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			var tenDangNhap = txtTenTaiKhoan.Text;
			var matKhau = txtMatKhau.Text;

			if (tenDangNhap == "" || matKhau == "" || (tenDangNhap == "" && matKhau == ""))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
				return;
			}
			TaiKhoanBL tkBL = new TaiKhoanBL();
			if (!(tkBL.Login(tenDangNhap, matKhau)))
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
				return;
			}

			List<TaiKhoan> account = tkBL.LoginByTenTK(tenDangNhap);

			
			frmChinh main = new frmChinh();
			this.Hide();
			main.ShowDialog();
			this.Show();

		}

		private void btnThoatDN_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{

		}

		private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
		{
			string msg = "Bạn có chắc chắn muốn thoát chương trình ?";
			var result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes)
				e.Cancel = true;
		}

		private void cbShowPass_CheckedChanged(object sender, EventArgs e)
		{
			txtMatKhau.UseSystemPasswordChar = !cbShowPass.Checked;
		}
	}
}
