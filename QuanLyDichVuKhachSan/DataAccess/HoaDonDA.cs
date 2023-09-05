using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HoaDonDA
    {
        public List<HoaDon> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.HoaDon_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<HoaDon> list = new List<HoaDon>();
            while (reader.Read())
            {
                HoaDon hd = new HoaDon();
                hd.ID = Convert.ToInt32(reader["ID"]);
                hd.NgayLapHD = Convert.ToDateTime(reader["NgayLapHD"]);
                hd.NgayKetThucHD = Convert.ToDateTime(reader["NgayKetThucHD"]);
                hd.MaPhong = Convert.ToInt32(reader["MaPhong"]);
                hd.TongTien = Convert.ToSingle(reader["TongTien"]);
                hd.GiamGia = Convert.ToSingle(reader["GiamGia"]);
                hd.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
                hd.Status = Convert.ToInt32(reader["Status"]);

                list.Add(hd);

            }
            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(HoaDon hd, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.HoaDon_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = hd.ID;

            command.Parameters.Add("@NgayLapHD", SqlDbType.DateTime).Value = hd.NgayLapHD;
            command.Parameters.Add("@NgayKetThucHD", SqlDbType.DateTime).Value = hd.NgayKetThucHD;
            command.Parameters.Add("@MaPhong", SqlDbType.Int).Value = hd.MaPhong;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = hd.TongTien;
            command.Parameters.Add("@GiamGia", SqlDbType.Float).Value = hd.GiamGia;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = hd.ThanhTien;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = hd.Status;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }

        public HoaDon GetHD_Phong(int idPhong)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.HoaDon_GetByRoom;
            command.Parameters.Add("@IDPhong", SqlDbType.Int);
            command.Parameters["@IDPhong"].Value = idPhong;
            SqlDataReader reader = command.ExecuteReader();
            HoaDon hd = new HoaDon();
            if (reader.Read())
            {
                hd.ID = Convert.ToInt32(reader["ID"]);
                hd.NgayLapHD = Convert.ToDateTime(reader["NgayLapHD"]);
                if (reader["NgayKetThucHD"] != DBNull.Value)
                    hd.NgayKetThucHD = Convert.ToDateTime(reader["NgayKetThucHD"]);
                hd.MaPhong = Convert.ToInt32(reader["MaPhong"]);
                hd.TongTien = Convert.ToSingle(reader["TongTien"]);
                hd.GiamGia = Convert.ToSingle(reader["GiamGia"]);
                hd.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
                hd.Status = Convert.ToInt32(reader["Status"]);

            }
            sqlConn.Close();
            return hd;
        }
    }
}
