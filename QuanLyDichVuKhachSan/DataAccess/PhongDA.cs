using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PhongDA
    {
        public List<Phong> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Phong_GetAll;
            
            SqlDataReader reader = command.ExecuteReader();
            List<Phong> list = new List<Phong>();
            while (reader.Read())
            {
                Phong phong = new Phong();
                phong.ID = Convert.ToInt32(reader["ID"]);
                phong.TenPhong = reader["TenPhong"].ToString();
               // phong.MaKh = Convert.ToInt32(reader["MaKH"]);
                phong.GhiChu = reader["GhiChu"].ToString();
				phong.Status= reader["Status"].ToString();

				list.Add(phong);

            }
            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Phong p, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Phong_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = p.ID;
            command.Parameters.Add("@TenPhong", SqlDbType.NVarChar, 50).Value = p.TenPhong;
            //command.Parameters.Add("@MaKh", SqlDbType.Int).Value = p.MaKh;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 100).Value = p.GhiChu;
            command.Parameters.Add("@Status", SqlDbType.NVarChar, 100).Value = p.Status;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
        public DataTable XemIpPhong()
        {

            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Phong_XemIPPhong;

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;


        }
		public Phong GetSinglePhong(int ID)
		{
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Phong_GetSingle;
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = ID;
            SqlDataReader reader = command.ExecuteReader();
            Phong p = new Phong();
            if (reader.Read())
            {
                p.ID = Convert.ToInt32(reader["ID"]);
                p.TenPhong = reader["TenPhong"].ToString();
                p.GhiChu = reader["GhiChu"].ToString();
                p.Status = reader["Status"].ToString();

            }
            sqlConn.Close();
            return p;
        }
	}
}
