using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class DichVuBL
    {
        DichVuDA dichvuDA = new DichVuDA();
        public List<DichVu> GetAll()
        {
            return dichvuDA.GetAll();
        }
		public DichVu GetDichVu(int id)
		{
			return dichvuDA.GetSingle(id);
		}
		public int Insert(DichVu dv)
        {
            return dichvuDA.Insert_Update_Delete(dv, 0);
        }
        
        public int Update(DichVu dv)
        {
            return dichvuDA.Insert_Update_Delete(dv, 1);
        }

        public int Delete(DichVu dv)
        {
            return dichvuDA.Insert_Update_Delete(dv, 2);
        }
        public List<DichVu> SapTen()
        {
            return dichvuDA.SapTen();
        }
        public List<DichVu> SapGia()
        {
            return dichvuDA.SapGia();
        }
		public DichVu GetSingle(int id)
		{
			return dichvuDA.GetSingleDichVu(id);
		}

		public List<DichVu> GetByCategory(int catID)
		{
			return dichvuDA.GetByCategory(catID);
		}
	}
}
