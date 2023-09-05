using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataAccess
{
    public class DoanhThuDA
    {
        public List<DoanhThu > GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DoanhThu_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<DoanhThu> list = new List<DoanhThu>();
            while (reader.Read())
            {
                DoanhThu dt = new DoanhThu();
				dt.NgayLapHD = Convert.ToDateTime(reader["NgayLapHD"]);
				dt.NgayKetThucHD = Convert.ToDateTime(reader["NgayKetThucHD"]);
                dt.MaHD = Convert.ToInt32(reader["MaHD"]);
				dt.TenDV = reader["TenDV"].ToString();
                dt.SoLuong = Convert.ToInt32(reader["SoLuong"]);
				dt.DonGia = Convert.ToInt32(reader["DonGia"]);
				dt.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
                list.Add(dt);

            }
            sqlConn.Close();
            return list;
        }

       
        public List<DoanhThu> DoanhThuByDate(DateTime tungay, DateTime denngay)
        {

            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DoanhThu_ByDate;


            command.Parameters.Add("@ngaylap", SqlDbType.DateTime).Value = tungay;
            command.Parameters.Add("@ngayketthuc", SqlDbType.DateTime).Value = denngay;
            SqlDataReader reader = command.ExecuteReader();
            List<DoanhThu> list = new List<DoanhThu>();
            while (reader.Read())
            {
				DoanhThu dt = new DoanhThu();
				dt.NgayLapHD = Convert.ToDateTime(reader["NgayLapHD"]);
				dt.NgayKetThucHD = Convert.ToDateTime(reader["NgayKetThucHD"]);
				dt.MaHD = Convert.ToInt32(reader["MaHD"]);
				dt.TenDV = reader["TenDV"].ToString();
				dt.SoLuong = Convert.ToInt32(reader["SoLuong"]);
				dt.DonGia = Convert.ToInt32(reader["DonGia"]);
				dt.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
				list.Add(dt);

			}
            sqlConn.Close();
            return list;
        }
        public List<DoanhThu> DoanhThuByDay(DateTime tungay)
        {

            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DoanhThu_ByDay;
            command.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = tungay;

            /*DataTable dataTable = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);

			// Trả về DataTable chứa kết quả truy vấn
			return dataTable;*/
            SqlDataReader reader = command.ExecuteReader();
            List<DoanhThu> list = new List<DoanhThu>();
            while (reader.Read())
            {
                DoanhThu dt = new DoanhThu();
                dt.NgayLapHD = Convert.ToDateTime(reader["NgayLapHD"]);
                dt.NgayKetThucHD = Convert.ToDateTime(reader["NgayKetThucHD"]);
                dt.MaHD = Convert.ToInt32(reader["MaHD"]);
                dt.TenDV = reader["TenDV"].ToString();
                dt.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                dt.DonGia = Convert.ToInt32(reader["DonGia"]);
                dt.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
                list.Add(dt);

            }
            sqlConn.Close();
            return list;

        }
		public DataTable DoanhThuByDay_DichVu(DateTime tungay)
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();
			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.DoanhThu_ByDay;
			command.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = tungay;

			DataTable dataTable = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);
			return dataTable;
			

		}
	}
}
