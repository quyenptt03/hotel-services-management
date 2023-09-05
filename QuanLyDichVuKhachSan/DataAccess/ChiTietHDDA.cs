using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace DataAccess
{
    public class ChiTietHDDA
    {
        public List<ChiTietHD> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ChiTietHD_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<ChiTietHD> list = new List<ChiTietHD>();
            while (reader.Read())
            {
                ChiTietHD chitietHD = new ChiTietHD();
                chitietHD.MaHD = Convert.ToInt32(reader["MaHD"]);
                chitietHD.MaDV = Convert.ToInt32(reader["MaDV"]);
                chitietHD.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                chitietHD.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
                chitietHD.GhiChu = reader["GhiChu"].ToString();

                list.Add(chitietHD);

            }
            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(ChiTietHD chiTietHD, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ChiTietHD_InsertUpdateDelete;
            //command.CommandText = "execute ChiTietHD_InsertUpdateDelete @MaHD, @MaDV, @SoLuong, @ThanhTien, @GhiChu, @Action";
            //SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            // IDPara.Direction = ParameterDirection.InputOutput;
            //command.Parameters.Add(IDPara).Value = chiTietHD.ID;
            command.Parameters.Add("@MaHD", SqlDbType.Int).Value = chiTietHD.MaHD;
            command.Parameters.Add("@MaDV", SqlDbType.Int).Value = chiTietHD.MaDV;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = chiTietHD.SoLuong;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = chiTietHD.ThanhTien;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 100).Value = chiTietHD.GhiChu;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return 1;
            return 0;
        }


        public List<ChiTietHD> GetChiTietHD_Phong(int ID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ChiTietHD_GetUsedByRoom;
            //command.CommandText = "EXECUTE GetDSDichVu_Phong @ID";

            command.Parameters.Add("@IDPhong", SqlDbType.Int);
            command.Parameters["@IDPhong"].Value = ID;

            SqlDataReader reader = command.ExecuteReader();
            List<ChiTietHD> list = new List<ChiTietHD>();
            /*if (reader.Read())
            {
                ChiTietHD cthd = new ChiTietHD();
                cthd.MaHD = Convert.ToInt32(reader["MaHD"]);
                cthd.MaDV = Convert.ToInt32(reader["MaDV"]);
                cthd.TenDV = reader["TenDV"].ToString();
                cthd.DonGia = Convert.ToSingle(reader["DonGia"]);
                cthd.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                cthd.DVT = reader["DVT"].ToString();
                cthd.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
                cthd.GhiChu = reader["GhiChu"].ToString();

                list.Add(cthd);
            }*/
            if (reader.Read())
            {
                do
                {
                    ChiTietHD cthd = new ChiTietHD();
                    cthd.MaHD = Convert.ToInt32(reader["MaHD"]);
                    cthd.MaDV = Convert.ToInt32(reader["MaDV"]);
                    cthd.TenDV = reader["TenDV"].ToString();
                    cthd.DonGia = Convert.ToSingle(reader["DonGia"]);
                    cthd.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                    cthd.DVT = reader["DVT"].ToString();
                    cthd.ThanhTien = Convert.ToSingle(reader["ThanhTien"]);
                    cthd.GhiChu = reader["GhiChu"].ToString();

                    list.Add(cthd);
                } while (reader.Read());
            }
            return list;
        }

        public ChiTietHD GetSingleChiTietHD(int maHD, int maDV)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ChiTietHD_GetSingle;

            command.Parameters.Add("@MaHD", SqlDbType.Int);
            command.Parameters["@MaHD"].Value = maHD;
            command.Parameters.Add("@MaDV", SqlDbType.Int);
            command.Parameters["@MaDV"].Value = maDV;
            SqlDataReader reader = command.ExecuteReader();
            ChiTietHD ct = new ChiTietHD();
            if (reader.Read())
            {
                ct.MaHD = Convert.ToInt32(reader["MaHD"]);
                ct.MaDV = Convert.ToInt32(reader["MaDV"]);
                ct.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                ct.ThanhTien = Convert.ToInt32(reader["ThanhTien"]);
                ct.GhiChu = reader["GhiChu"].ToString();

            }
            sqlConn.Close();
            return ct;
        }
    }
}
