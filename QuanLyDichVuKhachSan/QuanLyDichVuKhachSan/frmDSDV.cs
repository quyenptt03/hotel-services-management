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
	public partial class frmDSDV : Form
	{
		List<DichVu> listDichVu = new List<DichVu>();
		DichVu dvCurrent = new DichVu();
		public frmDSDV()
		{
			InitializeComponent();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
            if (dgvDSDichVu.SelectedRows.Count > 0)
            {
                //DichVuBL dvBL = new DichVuBL();
                int idDV = Convert.ToInt32(dgvDSDichVu.SelectedRows[0].Cells["ID"].Value);
                //dvCurrent = dvBL.GetDichVu(idDV);
                //DataGridViewRow selectedRow = dgvDSDichVu.SelectedRows[0];
                //DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                frmCapNhatDV capnhatDV = new frmCapNhatDV(idDV);
                //capnhatDV.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);
                var result = capnhatDV.ShowDialog();
                //capnhatDV.DisplayFoodInfo(rowView);
                if (result == DialogResult.OK)
                {
                    LoadDSDVDataToListView();
                }
            }
        }

		private void foodForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
		private void frmDSDV_Load(object sender, EventArgs e)
		{
			LoadDSDVDataToListView();
		}

		public void LoadDSDVDataToListView()
		{

			DichVuBL dichvuBL = new DichVuBL();
			listDichVu = dichvuBL.GetAll();
			dgvDSDichVu.DataSource = listDichVu;
			dgvDSDichVu.Refresh();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{

				DichVuBL dvBL = new DichVuBL();
				if (dvBL.Delete(dvCurrent) > 0)
				{
					MessageBox.Show("Xoá dịch vụ thành công");
					LoadDSDVDataToListView();
				}

			}
			else MessageBox.Show("Xoá không thành công");
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
            frmCapNhatDV capnhatDV = new frmCapNhatDV(0);
            //capnhatDV.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);
            DialogResult result = capnhatDV.ShowDialog();
            //DialogResult result = capnhatDV.ShowDialog();

            // Kiểm tra kết quả trạng thái của form
            if (result == DialogResult.OK)
            {
                LoadDSDVDataToListView();
            }
        }

		private void dgvDSDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dgvDSDichVu.Rows[e.RowIndex];
				txtMaTenDV.Text = selectedRow.Cells["id"].Value.ToString();
			}
		}

		private void rdTen_CheckedChanged(object sender, EventArgs e)
		{
			DichVuBL dichvuBL = new DichVuBL();
			listDichVu = dichvuBL.SapTen();
			dgvDSDichVu.DataSource = listDichVu;
		}

		private void rdGia_CheckedChanged(object sender, EventArgs e)
		{
			DichVuBL dichvuBL = new DichVuBL();
			listDichVu = dichvuBL.SapGia();
			dgvDSDichVu.DataSource = listDichVu;
		}

		private void btnLammoi_Click(object sender, EventArgs e)
		{
			this.LoadDSDVDataToListView();
		}
	}
}
