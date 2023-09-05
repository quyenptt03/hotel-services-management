using DataAccess;
using BussinessLogic;
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
	public partial class frmPhong : Form
	{
		List<Phong> listPhong = new List<Phong>();
		public frmPhong()
		{
			InitializeComponent();
		}

		private void frmPhong_Load(object sender, EventArgs e)
		{
			LoadPhongDataToListView();
		}
		public void LoadPhongDataToListView()
		{

			PhongBL phongBL = new PhongBL();
			listPhong = phongBL.GetAll();
			dgvPhong.DataSource = listPhong;
			dgvPhong.Refresh();
		}
	}
}
