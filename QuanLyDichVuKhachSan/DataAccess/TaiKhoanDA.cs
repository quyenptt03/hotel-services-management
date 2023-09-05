using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace DataAccess
{
	public class TaiKhoanDA
	{
		public List<TaiKhoan> GetAll()
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.TaiKhoan_GetAll;

			SqlDataReader reader = command.ExecuteReader();
			List<TaiKhoan> list = new List<TaiKhoan>();
			while (reader.Read())
			{
				TaiKhoan tk = new TaiKhoan();
				tk.MaTaiKhoan = reader["MaTaiKhoan"].ToString();
				tk.TenTaiKhoan = reader["TenTaiKhoan"].ToString();
				tk.PassWord = reader["PassWord"].ToString();
				tk.Type = Convert.ToInt32(reader["Type"]);

				list.Add(tk);

			}
			sqlConn.Close();
			return list;
		}

		public int Insert_Update_Delete(TaiKhoan tk, int action)
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();
			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.TaiKhoan_InsertUpdateDelete;

			command.Parameters.Add("@MaTaiKhoan", SqlDbType.Char, 6).Value = tk.MaTaiKhoan;
			command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar, 70).Value = tk.TenTaiKhoan;
			command.Parameters.Add("@PassWord", SqlDbType.NVarChar, 1000).Value = tk.PassWord;
			command.Parameters.Add("@Type", SqlDbType.Int).Value = tk.Type;
			command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

			int result = command.ExecuteNonQuery();
			if (result > 0)
				return 1;
			return 0;
		}

		public List<TaiKhoan> DangNhap(string tenTaiKhoan)
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();
			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.TaiKhoan_DangNhapByTenTK;

			command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar, 100).Value = tenTaiKhoan;

			SqlDataReader reader = command.ExecuteReader();
			List<TaiKhoan> list = new List<TaiKhoan>();
			while (reader.Read())
			{
				TaiKhoan tk = new TaiKhoan();
				tk.MaTaiKhoan = reader["MaTaiKhoan"].ToString();
				tk.TenTaiKhoan = reader["TenTaiKhoan"].ToString();
				tk.PassWord = reader["PassWord"].ToString();
				tk.Type = Convert.ToInt32(reader["Type"]);

				list.Add(tk);

			}
			sqlConn.Close();
			return list;
		}
		public bool Login(string tenTaiKhoan, string password)
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();
			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.TaiKhoan_Login;

			command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar, 100).Value = tenTaiKhoan;
			command.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = password;

			SqlDataReader reader = command.ExecuteReader();

			if (reader.HasRows)
			{
				return true;

			}
			reader.Close();
			return false;

		}
	}
}
