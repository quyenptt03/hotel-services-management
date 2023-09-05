using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KhachHangDA
    {
        public List<KhachHang> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.KhachHang_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<KhachHang> list = new List<KhachHang>();
            while (reader.Read())
            {
                KhachHang kh = new KhachHang();
                kh.ID = Convert.ToInt32(reader["ID"]);
                kh.TenKH = reader["TenKH"].ToString();
                kh.CMND_CCCD = reader["CMND_CCCD"].ToString();
                kh.DiaChi = reader["DiaChi"].ToString();
                kh.SDT = reader["SDT"].ToString();
                kh.LoaiKH = Convert.ToInt32(reader["LoaiKH"]);
                object value = (reader["MaPhong"]); // Lấy giá trị từ cơ sở dữ liệu

                if (Convert.IsDBNull(value))
                {
                    kh.MaPhong = 0; // Giá trị mặc định khi DBNull
                }
                else
                {
                    kh.MaPhong = Convert.ToInt32(value); // Chuyển đổi giá trị sang kiểu int
                }

                list.Add(kh);

            }
            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(KhachHang kh, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.KhachHang_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = kh.ID;
            command.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50).Value = kh.TenKH;
            command.Parameters.Add("@CMND_CCCD", SqlDbType.NVarChar, 12).Value = kh.CMND_CCCD;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100).Value = kh.DiaChi;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 100).Value = kh.SDT;
            command.Parameters.Add("@LoaiKH", SqlDbType.Int).Value = kh.LoaiKH;
            command.Parameters.Add("@MaPhong", SqlDbType.Int).Value = kh.MaPhong;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;
			this.GetAll();
			int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }

        public int Delete(int id)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.KhachHang_Delete;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            this.GetAll();
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
        public int Update(int id, string makh, string cmnd, string diachi, string sdt, int loaikh, int maphong)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.KhachHang_Update;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50).Value = makh;
            command.Parameters.Add("@CMND_CCCD", SqlDbType.NVarChar, 12).Value = cmnd;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100).Value = diachi;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 100).Value = sdt;
            command.Parameters.Add("@LoaiKH", SqlDbType.Int).Value = loaikh;
            command.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maphong;
            this.GetAll();
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
		public KhachHang GetKhachHang_Phong(int idPhong)
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.KhachHang_GetByRoom;

			command.Parameters.Add("@IDPhong", SqlDbType.Int).Value = idPhong;

			SqlDataReader reader = command.ExecuteReader();
			KhachHang kh = new KhachHang();
			while (reader.Read())
			{
				kh.ID = Convert.ToInt32(reader["ID"]);
				kh.TenKH = reader["TenKH"].ToString();
				kh.CMND_CCCD = reader["CMND_CCCD"].ToString();
				kh.DiaChi = reader["DiaChi"].ToString();
				kh.SDT = reader["SDT"].ToString();
				kh.LoaiKH = Convert.ToInt32(reader["LoaiKH"]);
				kh.MaPhong = Convert.ToInt32(reader["MaPhong"]);

			}
			sqlConn.Close();
			return kh;
		}
	}
}
