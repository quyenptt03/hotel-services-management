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
	public partial class frmChiTietHD : Form
	{
		List<ChiTietHD> listChiTietHD = new List<ChiTietHD>();
		private DataTable chiTietHDTable;
		ChiTietHD chiTietHDCurrent = new ChiTietHD();
		int _id;

        public frmChiTietHD(int id)
		{
			InitializeComponent();
			 _id = id;
		}

		private void frmChiTietHD_Load(object sender, EventArgs e)
		{
			
            string connectionString = "server=.; database = QLDVKS; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM ChiTietHD WHERE ChiTietHD.MaHD =@id";
            sqlCommand.Parameters.AddWithValue("@id", _id);
            sqlConnection.Open();
            
            this.Text = "Danh sách các mặt hàng của hóa đơn";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable("ChiTietHD");
            adapter.Fill(table);
            dgvChiTiet.DataSource = table;
            dgvChiTiet.Columns[0].ReadOnly = true;
            sqlConnection.Close();
        }
		public void LoadChiTietDataToListView()
		{

			ChiTietHDBL chiTietHDBL = new ChiTietHDBL();
			listChiTietHD = chiTietHDBL.GetAll();
			dgvChiTiet.DataSource = listChiTietHD;
			dgvChiTiet.Refresh();
		}
	}
}
