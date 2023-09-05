using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class LoaiDVBL
    {
        LoaiDVDA loaiDVDA = new LoaiDVDA();
        public List<LoaiDV> GetAll()
        {
            return loaiDVDA.GetAll();
        }
		public DataTable XemLoaiDichVu()
		{
			return loaiDVDA.XemLoaiDichVu();
		}
		public int Insert(LoaiDV loaiDV)
        {
            return loaiDVDA.Insert_Update_Delete(loaiDV, 0);
        }

        public int Update(LoaiDV loaiDV)
        {
            return loaiDVDA.Insert_Update_Delete(loaiDV, 1);
        }

        public int Delete(LoaiDV loaiDV)
        {
            return loaiDVDA.Insert_Update_Delete(loaiDV, 2);
        }
    }
}
