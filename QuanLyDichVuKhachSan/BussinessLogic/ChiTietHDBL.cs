using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussinessLogic
{
    public class ChiTietHDBL
    {
        ChiTietHDDA chiTietHDDA = new ChiTietHDDA();
        public List<ChiTietHD> GetAll()
        {
            return chiTietHDDA.GetAll();
        }
        //Phương thức thêm dữ liệu 
        public int Insert(ChiTietHD chiTietHD)
        {
            return chiTietHDDA.Insert_Update_Delete(chiTietHD, 0);
        }
        //Phương thức cập nhật dữ liệu 
        public int Update(ChiTietHD category)
        {
            return chiTietHDDA.Insert_Update_Delete(category, 1);
        }
        //Phương thức xoá dữ liệu truyền vào ID 
        public int Delete(ChiTietHD category)
        {
            return chiTietHDDA.Insert_Update_Delete(category, 2);
        }
		public List<ChiTietHD> GetUsedByRoom(int idPhong)
		{
			return chiTietHDDA.GetChiTietHD_Phong(idPhong);
		}
		public ChiTietHD GetSingleChiTietHD(int maHD, int maDV)
		{
			return chiTietHDDA.GetSingleChiTietHD(maHD, maDV);
		}
	}
}
