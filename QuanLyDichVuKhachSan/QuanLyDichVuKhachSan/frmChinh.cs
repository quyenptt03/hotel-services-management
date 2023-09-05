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
using BussinessLogic;
using DataAccess;

namespace QuanLyDichVuKhachSan
{
	
	public partial class frmChinh : Form
    {
		List<Phong> dsPhong = new List<Phong>();
		List<DichVu> dsDichVu = new List<DichVu>();
		List<ChiTietHD> cthd = new List<ChiTietHD>();
		Phong p = new Phong();
		DichVu dv = new DichVu();
        public frmChinh()
		{
			InitializeComponent();
		}
        #region ham bo tro
		private void ThemPhongLV(Phong p)
		{
			ListViewItem lvitem = new ListViewItem(p.TenPhong);
			lvitem.Tag = p.ID;
			lvitem.ImageIndex = Convert.ToInt32(p.Status);
			this.lvPhong.Items.Add(lvitem);
		}
		private void LoadDSPhong()
		{
			try
			{
				PhongBL phongBL = new PhongBL();
				dsPhong = phongBL.GetAll();
				this.lvPhong.Items.Clear();
				foreach (Phong phong in dsPhong)
				{
					ThemPhongLV(phong);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Lỗi khi tải danh sách phòng: " + ex.Message);
			}
        }

		public void LoadDSDV()
		{
			DichVuBL dichVuBL = new DichVuBL();
			dsDichVu = dichVuBL.GetAll();
			cbbDichVu.Items.Clear();
			foreach (var dv in dsDichVu)
			{
				cbbDichVu.Items.Add(dv.TenDV);
			}
		}
		public void LoadDSDV_LoaiDV(int idLoaiDV)
		{
			try
			{
				DichVuBL dichVuBL = new DichVuBL();
				dsDichVu = dichVuBL.GetByCategory(idLoaiDV);
				cbbDichVu.DataSource = dsDichVu;
				cbbDichVu.DisplayMember = "TenDV";
				cbbDichVu.ValueMember = "ID";

				cbbDichVu.SelectedIndex = -1;
				cbbDichVu.Text = "";
			}
			catch (Exception ex)
			{
				Console.WriteLine("Lỗi khi tải danh sách dịch vụ: " + ex.Message);
			}
		}
		public Phong GetPhong(int idPhong)
		{
			PhongBL phongBL = new PhongBL();
			Phong p = new Phong();
			p = phongBL.GetSingle(idPhong);
			return p;
		}
		public void LoadChiTietDV(int idPhong)
		{
			ChiTietHDBL chiTietDVBL = new ChiTietHDBL();
			cthd = chiTietDVBL.GetUsedByRoom(idPhong);
			//dgvChiTietDV.DataSource = cthd;
			dgvChiTietDV.Columns.Clear();
			dgvChiTietDV.Rows.Clear();
			dgvChiTietDV.Columns.Add("MaDV", "Mã DV");
			dgvChiTietDV.Columns.Add("TenDV", "Tên DV");
			dgvChiTietDV.Columns.Add("DonGia", "Đơn giá");
			dgvChiTietDV.Columns.Add("SL", "SL");
			dgvChiTietDV.Columns.Add("DVT", "DVT");
			dgvChiTietDV.Columns.Add("ThanhTien", "Thành tiền");
			dgvChiTietDV.Columns.Add("GhiChu", "Ghi chú");
			foreach (var dv in cthd)
			{
				dgvChiTietDV.Rows.Add(dv.MaDV, dv.TenDV, dv.DonGia, dv.SoLuong, dv.DVT, dv.ThanhTien, dv.GhiChu);
			}
		}
		public void LoadChiTietHoaDon(int idPhong)
		{
			HoaDonBL hoaDonBL = new HoaDonBL();
			HoaDon hd = hoaDonBL.GetByRoom(idPhong);
			if (hd.ID != 0 && hd.Status == 0)
			{
				txtTongTien.Text = hd.TongTien.ToString();
				txtThanhTien.Text = hd.ThanhTien.ToString();
				nupGiamGia.Value = (int)hd.GiamGia;
			}
		}
		public void ResetChiTietHD()
		{
			txtTongTien.Text = "";
			txtThanhTien.Text = "";
		}
		public void ResetDSDichVu()
		{
			dgvChiTietDV.Rows.Clear();
		}
		/*
        public void UpdateDichVu_Datagridview()
        {
            var dvCbb = cbbDichVu.SelectedItem as DichVu;
            if (dvCbb == null)
            {
                MessageBox.Show("Chưa chọn dịch vụ", "Message");
                return;
            }
            try
            {
                for (int i = 0; i < dgvChiTietDV.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dgvChiTietDV.Rows[i];

                    if (row.Cells["MaDV"].Value != null && Convert.ToInt32(row.Cells["MaDV"].Value) == dvCbb.ID)
                    {
                        //int currentSL = Convert.ToInt32(row.Cells["SL"].Value);
                        int newSL = (int)nudSoLuong.Value;
                        row.Cells["SL"].Value = newSL;
                        row.Cells["ThanhTien"].Value = newSL * Convert.ToInt32(row.Cells["DonGia"].Value);
                       
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại", "Error");
            }
        }*/
		public void ChangeDatagridview()
		{
			var dvCbb = cbbDichVu.SelectedItem as DichVu;
			if (dvCbb == null)
			{
				MessageBox.Show("Chưa chọn dịch vụ", "Message");
				return;
			}
			try
			{
				bool found = false;

				for (int i = 0; i < dgvChiTietDV.Rows.Count - 1; i++)
				{
					DataGridViewRow row = dgvChiTietDV.Rows[i];

					if (row.Cells["MaDV"].Value != null && Convert.ToInt32(row.Cells["MaDV"].Value) == dvCbb.ID)
					{
						int currentSL = Convert.ToInt32(row.Cells["SL"].Value);
						int newSL = currentSL + (int)nudSoLuong.Value;
						row.Cells["SL"].Value = newSL;
						row.Cells["ThanhTien"].Value = newSL * Convert.ToInt32(row.Cells["DonGia"].Value);
						found = true;
						break;
					}
				}

				if (!found)
				{
					dgvChiTietDV.Rows.Add(
						dvCbb.ID,
						dvCbb.TenDV,
						dvCbb.DonGia,
						nudSoLuong.Value,
						dvCbb.DVT,
						dvCbb.DonGia * (float)nudSoLuong.Value,
						""
					);
				}
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại", "Error");
			}
		}
		public void DisplayDatagridviewrowToCbbDichVu()
		{
			cbbDichVu.Text = "";
			DichVuBL dichVuBL = new DichVuBL();
			int idDV = Convert.ToInt32(dgvChiTietDV.SelectedRows[0].Cells["MaDV"].Value);
			DichVu dv = dichVuBL.GetSingle(idDV);
			cbbDichVu.SelectedItem = dv;
			cbbDichVu.SelectedText = dv.TenDV;
			nudSoLuong.Value = Convert.ToInt32(dgvChiTietDV.SelectedRows[0].Cells["SL"].Value);
		}

		public void DisplayThongTinKhachHang_Phong(int idPhong)
		{
			KhachHangBL khachHangBL = new KhachHangBL();
			KhachHang kh = khachHangBL.GetKhachHangByPhong(idPhong);
			if (kh.ID != 0)
			{
				txtTenKH.Text = kh.TenKH;
				txtCCCD.Text = kh.CMND_CCCD;
				txtSoDT.Text = kh.SDT;
			}
			else
			{
				txtTenKH.Text = "";
				txtCCCD.Text = "";
				txtSoDT.Text = "";
			}
		}
		public void ResetThongTinKH()
		{
			txtTenKH.Text = "";
			txtCCCD.Text = "";
			txtSoDT.Text = "";
		}
		#endregion


		private void tsmiHome_Click(object sender, EventArgs e)
		{

		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gbLoaiDV_Enter(object sender, EventArgs e)
		{
			if (rdAnUong.Checked)
			{
				LoadDSDV_LoaiDV(1);

			}
			else if (rdSpa.Checked)
			{
				LoadDSDV_LoaiDV(4);

			}
			else if (rdDiLai.Checked)
			{
				LoadDSDV_LoaiDV(2);
			}
			else if (rdGiatLa.Checked)
			{
				LoadDSDV_LoaiDV(3);

			}
			else if (rdGiaiTri.Checked)
			{
				LoadDSDV_LoaiDV(5);
			}
		}

		private void tsmiDoanhThu_Click(object sender, EventArgs e)
		{
			frmDoanhThu doanhThu = new frmDoanhThu();
			doanhThu.ShowDialog();
		}

		private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHoaDon hoaDon = new frmHoaDon();
			hoaDon.ShowDialog();
		}

		private void tsmiKhachHang_Click(object sender, EventArgs e)
		{
			frmKhachHang khachHang = new frmKhachHang();
			khachHang.ShowDialog();
		}

		private void tsmiDoiMK_Click(object sender, EventArgs e)
		{
			frmDoiMatKhau doimk = new frmDoiMatKhau();
			doimk.ShowDialog();
		}

		private void tsmiDichVu_Click(object sender, EventArgs e)
		{
			frmDSDV dsdv = new frmDSDV();
			dsdv.ShowDialog();
		}

		private void tsmi_Phong_Click(object sender, EventArgs e)
		{
			frmPhong phong = new frmPhong();
			phong.ShowDialog();
		}

		private void cbbDichVu_SelectedIndexChanged(object sender, EventArgs e)
		{

        }

        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
			this.LoadDSPhong();
			this.rdAnUong.PerformClick();
			this.LoadDSDV_LoaiDV(1);
		}

        private void lvPhong_DoubleClick(object sender, EventArgs e)
        {

        }

		private void lvChiTietDV_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void rdAnUong_CheckedChanged(object sender, EventArgs e)
		{
			rdAnUong.CheckedChanged += new EventHandler(gbLoaiDV_Enter);
		}

		private void rdAnUong_Click(object sender, EventArgs e)
		{
			rdAnUong.CheckedChanged += new EventHandler(gbLoaiDV_Enter);
		}

		private void rdSpa_CheckedChanged(object sender, EventArgs e)
		{
			rdSpa.CheckedChanged += new EventHandler(gbLoaiDV_Enter);
		}

		private void rdDiLai_CheckedChanged(object sender, EventArgs e)
		{
			rdDiLai.CheckedChanged += new EventHandler(gbLoaiDV_Enter);
		}

		private void rdGiaiTri_CheckedChanged(object sender, EventArgs e)
		{
			rdGiaiTri.CheckedChanged += new EventHandler(gbLoaiDV_Enter);
		}

		private void rdGiatLa_CheckedChanged(object sender, EventArgs e)
		{
			rdGiatLa.CheckedChanged += new EventHandler(gbLoaiDV_Enter);
		}
		//======================
		private void rdAnUong_Click_1(object sender, EventArgs e)
		{
			rdAnUong.Click += new EventHandler(gbLoaiDV_Enter);
		}

		private void btnThemDV_Click(object sender, EventArgs e)
		{
			this.ChangeDatagridview();
		}

		private void lvPhong_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			int count = this.lvPhong.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem lvitem = this.lvPhong.SelectedItems[0];
				Phong p = GetPhong((int)lvitem.Tag);
				txtSoPhong.Text = p.TenPhong.ToString();

				this.DisplayThongTinKhachHang_Phong(p.ID);
				this.LoadChiTietDV(p.ID);
				this.LoadChiTietHoaDon(p.ID);
			}
		}

		private void btnHuyDon_Click(object sender, EventArgs e)
		{
			txtSoPhong.Text = "";
			this.ResetThongTinKH();
			this.ResetChiTietHD();
			this.ResetDSDichVu();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			PhongBL phongBL = new PhongBL();
			HoaDonBL hoaDonBL = new HoaDonBL();
			ChiTietHDBL chiTietHDBL = new ChiTietHDBL();

			ListViewItem lvitem = this.lvPhong.SelectedItems[0];
			Phong p = GetPhong((int)lvitem.Tag);
			HoaDon hd = new HoaDon();
			float tongTien = 0;

			if (int.Parse(p.Status) == 0)
			{
				hd.NgayLapHD = DateTime.Now;
				hd.NgayKetThucHD = DateTime.Now;
				hd.MaPhong = p.ID;
				hd.TongTien = 0;
				hd.GiamGia = 0;
				hd.ThanhTien = 0;
				hd.Status = 0;
				int idHD = hoaDonBL.Insert(hd);
				if (idHD == 0)
				{
					MessageBox.Show("Tạo hóa đơn thất bại, mời thử lại", "Error");
				}
			}
			hd = hoaDonBL.GetByRoom(p.ID);
			cthd = chiTietHDBL.GetUsedByRoom(p.ID);

			try
			{
				foreach (var chitiet in cthd)
				{
					chiTietHDBL.Delete(chitiet);
				}
				for (int i = 0; i < dgvChiTietDV.Rows.Count - 1; i++)
				{
					DataGridViewRow row = dgvChiTietDV.Rows[i];
					ChiTietHD ct = new ChiTietHD();
					ct.MaHD = hd.ID;
					ct.MaDV = Convert.ToInt32(row.Cells["MaDV"].Value);
					ct.SoLuong = Convert.ToInt32(row.Cells["SL"].Value);
					ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
					ct.GhiChu = row.Cells["GhiChu"].ToString();
					chiTietHDBL.Insert(ct);
					//ct = chiTietHDBL.GetSingleChiTietHD(hd.ID, Convert.ToInt32(row.Cells["MaDV"].Value));
					/*if (ct.MaHD == 0 && ct.MaDV == 0)
                    {
                        ct.MaHD = hd.ID;
                        ct.MaDV = Convert.ToInt32(row.Cells["MaDV"].Value);
                        ct.SoLuong = Convert.ToInt32(row.Cells["SL"].Value);
                        ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                        ct.GhiChu = row.Cells["GhiChu"].ToString();
                        chiTietHDBL.Insert(ct);
                    }
                    else
                    {
                        ct.SoLuong = Convert.ToInt32(row.Cells["SL"].Value);
                        ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);

                        chiTietHDBL.Update(ct);
                    }*/

					tongTien += ct.ThanhTien;
				}
				//update trang thai phong
				if (int.Parse(p.Status) == 0)
				{
					p.Status = 1.ToString();
					phongBL.Update(p);
					this.LoadDSPhong();
				}

				//update hoa don
				hd.TongTien = tongTien;
				hd.GiamGia = (float)nupGiamGia.Value;
				hd.ThanhTien = hd.TongTien - (hd.TongTien * hd.GiamGia / 100);
				hoaDonBL.Update(hd);

				this.LoadChiTietHoaDon(p.ID);
				MessageBox.Show("Lưu hóa đơn thành công", "Message");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi chương trình", "Thoát khỏi chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			PhongBL phongBL = new PhongBL();
			HoaDonBL hoaDonBL = new HoaDonBL();
			ChiTietHDBL chiTietHDBL = new ChiTietHDBL();
			KhachHangBL khachHangBL = new KhachHangBL();

			ListViewItem lvitem = this.lvPhong.SelectedItems[0];
			Phong p = GetPhong((int)lvitem.Tag);
			HoaDon hd = new HoaDon();
			KhachHang kh = khachHangBL.GetKhachHangByPhong(p.ID);

			float tongTien = 0;

			if (int.Parse(p.Status) == 0)
			{
				hd.NgayLapHD = DateTime.Now;
				hd.NgayKetThucHD = DateTime.Now;
				hd.MaPhong = p.ID;
				hd.TongTien = 0;
				hd.GiamGia = 0;
				hd.ThanhTien = 0;
				hd.Status = 0;
				int idHD = hoaDonBL.Insert(hd);
				if (idHD == 0)
				{
					MessageBox.Show("Tạo hóa đơn thất bại, mời thử lại", "Error");
				}
			}
			hd = hoaDonBL.GetByRoom(p.ID);

			try
			{
				foreach (var chitiet in cthd)
				{
					chiTietHDBL.Delete(chitiet);
				}
				for (int i = 0; i < dgvChiTietDV.Rows.Count - 1; i++)
				{
					DataGridViewRow row = dgvChiTietDV.Rows[i];
					ChiTietHD ct = new ChiTietHD();
					ct.MaHD = hd.ID;
					ct.MaDV = Convert.ToInt32(row.Cells["MaDV"].Value);
					ct.SoLuong = Convert.ToInt32(row.Cells["SL"].Value);
					ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
					ct.GhiChu = row.Cells["GhiChu"].ToString();
					chiTietHDBL.Insert(ct);
					//ct = chiTietHDBL.GetSingleChiTietHD(hd.ID, Convert.ToInt32(row.Cells["MaDV"].Value));
					/*if (ct.MaHD == 0 && ct.MaDV == 0)
                    {
                        ct.MaHD = hd.ID;
                        ct.MaDV = Convert.ToInt32(row.Cells["MaDV"].Value);
                        ct.SoLuong = Convert.ToInt32(row.Cells["SL"].Value);
                        ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                        ct.GhiChu = row.Cells["GhiChu"].ToString();
                        chiTietHDBL.Insert(ct);
                    }
                    else
                    {
                        ct.SoLuong = Convert.ToInt32(row.Cells["SL"].Value);
                        ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);

                        chiTietHDBL.Update(ct);
                    }*/

					tongTien += ct.ThanhTien;
				}
				var result = MessageBox.Show("Xác nhận thực hiện thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					//update trang thai phong
					p.Status = 0.ToString();
					phongBL.Update(p);
					this.LoadDSPhong();
					//update khach hang
					if (kh.ID != 0)
					{
						kh.MaPhong = 0;

						khachHangBL.Update(kh);
					}

					//update hoa don
					hd.Status = 1;
					hd.NgayKetThucHD = DateTime.Now;
					hd.TongTien = tongTien;
					hd.GiamGia = (float)nupGiamGia.Value;
					hd.ThanhTien = hd.TongTien - (hd.TongTien * hd.GiamGia / 100);
					hoaDonBL.Update(hd);

					btnHuyDon.PerformClick();

					MessageBox.Show("Thanh toán thành công", "Message");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void dgvChiTietDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvChiTietDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.DisplayDatagridviewrowToCbbDichVu();
		}

		private void chỉnhSửaDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnLuu.PerformClick();
		}

		private void xóaDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow selectedRow = dgvChiTietDV.SelectedRows[0];
				dgvChiTietDV.Rows.Remove(selectedRow);
			}
			catch
			{
				MessageBox.Show("Chưa chọn chi tiết dịch vụ", "Error");
			}
		}

		private void dgvChiTietDV_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
		{
			this.DisplayDatagridviewrowToCbbDichVu();
		}
	}
}
