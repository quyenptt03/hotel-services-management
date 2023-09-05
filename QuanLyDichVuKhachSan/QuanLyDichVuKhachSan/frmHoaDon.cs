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

namespace QuanLyDichVuKhachSan
{
	public partial class frmHoaDon : Form
	{
		List<HoaDon> listHD = new List<HoaDon>();
		private DataTable billTable;
		public frmHoaDon()
		{
			InitializeComponent();
		}

		private void frmHoaDon_Load(object sender, EventArgs e)
		{
            string connectionString = "server=.; database = QLDVKS; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM HoaDon";
            sqlConnection.Open();
            //string categoryName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách toàn bộ hóa đơn";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable("HoaDon");
            adapter.Fill(table);
            dgvHoaDon.DataSource = table;
            dgvHoaDon.Columns[0].ReadOnly = true;
            sqlConnection.Close();
        }
		public void LoadHoaDonDataToListView()
		{

			HoaDonBL HDBL = new HoaDonBL();
			listHD = HDBL.GetAll();
			dgvHoaDon.DataSource = listHD;
			dgvHoaDon.Refresh();
		}
		private void LoadCategory()
		{
			string connectionString = "server=.; database = QLDVKS; Integrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT ID, MaPhong FROM  HoaDon";
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			conn.Open();
			adapter.Fill(dt);
			conn.Close();
			conn.Dispose();


			cbbPhong.DataSource = dt;

			cbbPhong.DisplayMember = "MaPhong";

			cbbPhong.ValueMember = "ID";
		}
		private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbbPhong.SelectedIndex == -1) return;
			string connectionString = "server=.; database = QLDVKS; Integrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM  HoaDon WHERE ID = @id";

			cmd.Parameters.Add("@id", SqlDbType.Int);
			if (cbbPhong.SelectedValue is DataRowView)
			{
				DataRowView rowView = cbbPhong.SelectedValue as DataRowView;
				cmd.Parameters["@id"].Value = rowView["ID"];

			}
			else
			{
				cmd.Parameters["@id"].Value = cbbPhong.SelectedValue;

			}

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			billTable = new DataTable();

			conn.Open();

			adapter.Fill(billTable);
			conn.Close();
			conn.Dispose();

			dgvHoaDon.DataSource = billTable;
		}

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra xem đã chọn hóa đơn nào trong DataGridView chưa
            if (dgvHoaDon.SelectedRows.Count > 0)
            {

                // Lấy hóa đơn được chọn
                var selectedBill = dgvHoaDon.SelectedRows[0].DataBoundItem;

                // Kiểm tra xem hóa đơn có tồn tại hay không
                if (selectedBill != null)
                {
                    int selectedBillId = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["ID"].Value);

                    var chiTietHDForm = new frmChiTietHD(selectedBillId);
                    chiTietHDForm.Show();
                }
            }
        }
    }
}
