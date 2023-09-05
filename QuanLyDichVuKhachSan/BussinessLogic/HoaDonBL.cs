using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class HoaDonBL
    {
        HoaDonDA hoaDonDA = new HoaDonDA();
        public List<HoaDon> GetAll()
        {
            return hoaDonDA.GetAll();
        }

        public int Insert(HoaDon hd)
        {
            return hoaDonDA.Insert_Update_Delete(hd, 0);
        }

        public int Update(HoaDon hd)
        {
            return hoaDonDA.Insert_Update_Delete(hd, 1);
        }

        public int Delete(HoaDon hd)
        {
            return hoaDonDA.Insert_Update_Delete(hd, 2);
        }
		public HoaDon GetByRoom(int roomId)
		{
			return hoaDonDA.GetHD_Phong(roomId);
		}
	}
}
