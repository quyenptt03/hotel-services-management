using BussinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyDichVuKhachSan
{
	public partial class frmCapNhatDV : Form
	{
		List<LoaiDV> ListDichVu = new List<LoaiDV>();
		LoaiDVBL DichVuBL = new LoaiDVBL();
		DichVu dvCurrent = new DichVu();
		int idDVCurrent;
		public frmCapNhatDV(int idDV)
		{
			InitializeComponent();
			idDVCurrent = idDV;
		}

		private void frmCapNhatDV_Load(object sender, EventArgs e)
		{
			this.InitValues();
		}
		private void InitValues()
		{

			DataTable dt_dv = new DataTable();
			dt_dv = DichVuBL.XemLoaiDichVu();
			cbbLoaiDichVu.DataSource = dt_dv;
			cbbLoaiDichVu.DisplayMember = "ID";
			cbbLoaiDichVu.ValueMember = "ID";

		}
		public void ResetText()
		{
			txtMaDV.ResetText();
			txtTenDV.ResetText();
			cbbLoaiDichVu.ResetText();
			txtMoTa.ResetText();
			txtGia.ResetText();
			txtDVT.ResetText();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			int result = InsertDichVu();
			if (result > 0)
			{
				MessageBox.Show("Thêm dữ liệu thành công");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}
		public int InsertDichVu()
		{
			DichVu dv = new DichVu();
			dv.ID = 0;
			if (txtTenDV.Text == "" || cbbLoaiDichVu.Text == "" || txtMoTa.Text == "" || txtGia.Text == "" || txtDVT.Text == "")
			{

				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			}
			else
			{

				dv.TenDV = txtTenDV.Text;
				dv.IDLoaiDichVu = Convert.ToInt32(cbbLoaiDichVu.Text);
				dv.LuuY = txtMoTa.Text;
				dv.DonGia = Convert.ToInt32(txtGia.Text);
				dv.DVT = txtDVT.Text;
				DichVuBL dvBL = new DichVuBL();
				return dvBL.Insert(dv);
			}
			return -1;
		}
		public int UpdateDichVu(int id)
		{
			DichVuBL dichVuBL = new DichVuBL();
			DichVu dv = dichVuBL.GetDichVu(id);
			if (txtTenDV.Text == "" || cbbLoaiDichVu.Text == "" || txtMoTa.Text == "" || txtGia.Text == "" || txtDVT.Text == "")
			{

				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			}
			else
			{

				dv.TenDV = txtTenDV.Text;
				dv.IDLoaiDichVu = Convert.ToInt32(cbbLoaiDichVu.Text);
				dv.LuuY = txtMoTa.Text;
				dv.DonGia = Convert.ToInt32(txtGia.Text);
				dv.DVT = txtDVT.Text;
				DichVuBL dvBL = new DichVuBL();
				return dvBL.Update(dv);
			}
			return -1;
		}

		private void btnLuuTaomoi_Click(object sender, EventArgs e)
		{
			int result = UpdateDichVu(idDVCurrent);
			if (result > 0)
			{
				MessageBox.Show("Cập nhật dữ liệu thành công");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		
			else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		}
		public void DisplayFoodInfo(DataRowView rowView)
		{
			try
			{
				txtMaDV.Text = rowView["ID"].ToString();
				txtTenDV.Text = rowView["Name"].ToString();
				cbbLoaiDichVu.Text = rowView["Unit"].ToString();
				txtMoTa.Text = rowView["Notes"].ToString();
				txtGia.Text = rowView["Price"].ToString();
				txtDVT.Text = rowView["Price"].ToString();

				cbbLoaiDichVu.SelectedIndex = -1;
				for (int index = 0; index < cbbLoaiDichVu.Items.Count; index++)
				{
					DataRowView cat = cbbLoaiDichVu.Items[index] as DataRowView;
					if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
					{
						cbbLoaiDichVu.SelectedIndex = index;
						break;
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
				this.Close();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
