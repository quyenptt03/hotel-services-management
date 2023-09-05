using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DichVuDA
    {
        public List<DichVu> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DichVu_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<DichVu> list = new List<DichVu>();
            while (reader.Read())
            {
                DichVu dv = new DichVu();
                dv.ID = Convert.ToInt32(reader["ID"]);
                dv.TenDV = reader["TenDV"].ToString();
                dv.IDLoaiDichVu = Convert.ToInt32(reader["idLoaiDichVu"]);
                dv.DonGia = Convert.ToSingle(reader["DonGia"]);
                dv.DVT = reader["DVT"].ToString();
                dv.LuuY = reader["MoTa"].ToString();

                list.Add(dv);

            }
            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(DichVu dv, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DichVu_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = dv.ID;
            command.Parameters.Add("@TenDV", SqlDbType.NVarChar, 70).Value = dv.TenDV;
            command.Parameters.Add("@IdLoaiDichVu", SqlDbType.Int).Value = dv.IDLoaiDichVu;
            command.Parameters.Add("@DonGia", SqlDbType.Float).Value = dv.DonGia;
            command.Parameters.Add("@DVT", SqlDbType.NVarChar, 20).Value = dv.DVT;
            command.Parameters.Add("@MoTa", SqlDbType.NVarChar, 100).Value = dv.LuuY;
            command.Parameters.Add("@Action", SqlDbType.NVarChar, 100).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
        public List<DichVu> SapTen()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DichVu_SapTen;

            SqlDataReader reader = command.ExecuteReader();
            List<DichVu> list = new List<DichVu>();
            while (reader.Read())
            {
                DichVu dv = new DichVu();
                dv.ID = Convert.ToInt32(reader["ID"]);
                dv.TenDV = reader["TenDV"].ToString();
                dv.IDLoaiDichVu = Convert.ToInt32(reader["idLoaiDichVu"]);
                dv.DonGia = Convert.ToSingle(reader["DonGia"]);
                dv.DVT = reader["DVT"].ToString();
                dv.LuuY = reader["MoTa"].ToString();

                list.Add(dv);

            }
            sqlConn.Close();
            return list;
        }
        public List<DichVu> SapGia()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DichVu_SapGia;

            SqlDataReader reader = command.ExecuteReader();
            List<DichVu> list = new List<DichVu>();
            while (reader.Read())
            {
                DichVu dv = new DichVu();
                dv.ID = Convert.ToInt32(reader["ID"]);
                dv.TenDV = reader["TenDV"].ToString();
                dv.IDLoaiDichVu = Convert.ToInt32(reader["idLoaiDichVu"]);
                dv.DonGia = Convert.ToSingle(reader["DonGia"]);
                dv.DVT = reader["DVT"].ToString();
                dv.LuuY = reader["MoTa"].ToString();

                list.Add(dv);

            }
            sqlConn.Close();
            return list;
        }
		public List<DichVu> GetByCategory(int catID)
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.DichVu_GetByCategory;

			command.Parameters.Add("@IDLoaiDV", SqlDbType.Int);
			command.Parameters["@IDLoaiDV"].Value = catID;

			SqlDataReader reader = command.ExecuteReader();
			List<DichVu> list = new List<DichVu>();
			while (reader.Read())
			{
				DichVu dv = new DichVu();
				dv.ID = Convert.ToInt32(reader["ID"]);
				dv.TenDV = reader["TenDV"].ToString();
				dv.IDLoaiDichVu = Convert.ToInt32(reader["idLoaiDichVu"]);
				dv.DonGia = Convert.ToSingle(reader["DonGia"]);
				dv.DVT = reader["DVT"].ToString();
				dv.LuuY = reader["MoTa"].ToString();

				list.Add(dv);

			}
			sqlConn.Close();
			return list;
        }
        public DichVu GetSingleDichVu(int ID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DichVu_GetSingle;
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = ID;
            SqlDataReader reader = command.ExecuteReader();
            DichVu dv = new DichVu();
            if (reader.Read())
            {
                dv.ID = Convert.ToInt32(reader["ID"]);
                dv.TenDV = reader["TenDV"].ToString();
                dv.IDLoaiDichVu = Convert.ToInt32(reader["idLoaiDichVu"]);
                dv.DonGia = Convert.ToSingle(reader["DonGia"]);
                dv.DVT = reader["DVT"].ToString();
                dv.LuuY = reader["MoTa"].ToString();

            }
            sqlConn.Close();
            return dv;
        }
		public DichVu GetSingle(int id)
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.DichVu_GetSingle;

			command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

			SqlDataReader reader = command.ExecuteReader();
			DichVu dv = new DichVu();
			while (reader.Read())
			{
				dv.ID = Convert.ToInt32(reader["ID"]);
				dv.TenDV = reader["TenDV"].ToString();
				dv.IDLoaiDichVu = Convert.ToInt32(reader["idLoaiDichVu"]);
				dv.DonGia = Convert.ToSingle(reader["DonGia"]);
				dv.DVT = reader["DVT"].ToString();
				dv.LuuY = reader["MoTa"].ToString();


			}
			sqlConn.Close();
			return dv;
		}
	}
}
