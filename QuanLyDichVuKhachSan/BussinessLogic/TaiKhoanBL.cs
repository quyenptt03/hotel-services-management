using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class TaiKhoanBL
    {
        TaiKhoanDA taiKhoanDA = new TaiKhoanDA();
        public List<TaiKhoan> GetAll()
        {
            return taiKhoanDA.GetAll();
        }

        public int Insert(TaiKhoan tk)
        {
            return taiKhoanDA.Insert_Update_Delete(tk, 0);
        }

        public int Update(TaiKhoan tk)
        {
            return taiKhoanDA.Insert_Update_Delete(tk, 1);
        }

        public int Delete(TaiKhoan tk)
        {
            return taiKhoanDA.Insert_Update_Delete(tk, 2);
        }
		public int UpdateMK(TaiKhoan tk)
        { 
			return taiKhoanDA.Insert_Update_Delete(tk, 3);
		}
		public List<TaiKhoan> LoginByTenTK(string Tentk)
        {
            return taiKhoanDA.DangNhap(Tentk);
        }
		public bool Login(string tenTaiKhoan, string password)
		{
			return taiKhoanDA.Login(tenTaiKhoan, password);
		}
	}
}
