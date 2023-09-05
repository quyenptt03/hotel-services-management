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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDichVuKhachSan
{
	public partial class frmDoanhThu : Form
	{
		List<DoanhThu> ListDoanhThu = new List<DoanhThu>();
		DoanhThuBL doanhthuBL = new DoanhThuBL();
		
		public frmDoanhThu()
		{
			InitializeComponent();
		}

		private void txtTongDoanhThu_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmDoanhThu_Load(object sender, EventArgs e)
		{
			LoadDoanhThuDataToListView();
			dgvDoanhThu.Columns[0].HeaderText = "Ngày bắt đầu";
			dgvDoanhThu.Columns[1].HeaderText = "Ngày kết thúc";
			dgvDoanhThu.Columns[2].HeaderText = "Mã hóa đơn";
			dgvDoanhThu.Columns[3].HeaderText = "Tên dịch vụ";
			dgvDoanhThu.Columns[4].HeaderText = "Số lượng";
			dgvDoanhThu.Columns[5].HeaderText = "Đơn giá";
			dgvDoanhThu.Columns[6].HeaderText = "Thành tiền";
			this.Tinh();
		}
		public void LoadDoanhThuDataToListView()
		{


			ListDoanhThu = doanhthuBL.GetAll();
			dgvDoanhThu.DataSource = ListDoanhThu;
			dgvDoanhThu.Refresh();

		}
		private void btnXem_Click(object sender, EventArgs e)
		{
			DateTime from = dtpTuNgay.Value;
			DateTime to = dtpDenNgay.Value;
			this.LoadListBillByDate(from, to);
			this.Tinh();
		}
		void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
		{
			ListDoanhThu = doanhthuBL.DoanhThuByDate(checkIn, checkOut);
			dgvDoanhThu.DataSource = ListDoanhThu;

		}


		private void btnThongKeDay_Click(object sender, EventArgs e)
		{
			DateTime ngay = dtpNgay.Value;
			LoadListBillByDay(ngay);
			this.Tinh();
		}
		void LoadListBillByDay(DateTime checkIn)
		{
			//ListDoanhThu = doanhthuBL.DoanhThuByDay(checkIn);
			dgvDoanhThu.DataSource = ListDoanhThu;
			DataTable dt_dv = new DataTable();
			dt_dv = doanhthuBL.DoanhThuByDay_DichVu(checkIn);
			dgvDoanhThu.DataSource = dt_dv;
			

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			this.LoadDoanhThuDataToListView();
		}
		private void Tinh()
		{
			float tong = 0;
			foreach (DataGridViewRow row in dgvDoanhThu.Rows)
			{
				float giaTri = Convert.ToSingle(row.Cells[dgvDoanhThu.Columns.Count - 1].Value);
				tong += giaTri;
			}
			txtTongDoanhThu.Text = tong.ToString();


		}

		private void label3_Click(object sender, EventArgs e)
		{



		}

	}
}
