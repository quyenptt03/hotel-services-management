using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LoaiDVDA
    {
        public List<LoaiDV> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.LoaiDichVu_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<LoaiDV> list = new List<LoaiDV>();
            while (reader.Read())
            {
                LoaiDV loaiDV = new LoaiDV();
                loaiDV.ID = Convert.ToInt32(reader["ID"]);
                loaiDV.Name = reader["Name"].ToString();

                list.Add(loaiDV);

            }
            sqlConn.Close();
            return list;
        }
		public DataTable XemLoaiDichVu()
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.DichVu_XemLoaiDV;

			DataTable dataTable = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;

		}
        public int Insert_Update_Delete(LoaiDV loaiDV, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.LoaiDichVu_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = loaiDV.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = loaiDV.Name;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
    }
}
