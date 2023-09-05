using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class KhachHangBL
    {
        KhachHangDA khachHangDA = new KhachHangDA();
        public List<KhachHang> GetAll()
        {
            return khachHangDA.GetAll();
        }

        public int Insert(KhachHang kh)
        {
            return khachHangDA.Insert_Update_Delete(kh, 0);
        }

        public int Update(KhachHang kh)
        {
            return khachHangDA.Insert_Update_Delete(kh, 1);
		}

		public int Delete(KhachHang kh)
		{
			return khachHangDA.Insert_Update_Delete(kh, 2);
		}
		public int Delete1(int ID)
		{
			return khachHangDA.Delete(ID);
		}
		public int Update1(int id, string makh, string cmnd, string diachi, string sdt, int loaikh, int maphong)
		{
			return khachHangDA.Update(id, makh, cmnd, diachi, sdt, loaikh, maphong);
		}
		public KhachHang GetKhachHangByPhong(int idPhong)
		{
			return khachHangDA.GetKhachHang_Phong(idPhong);
		}
	}
}
