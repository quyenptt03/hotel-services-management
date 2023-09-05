using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class PhongBL
    {
        PhongDA phongDA = new PhongDA();

        public List<Phong> GetAll()
        {
            return phongDA.GetAll();    
        }
        public int Insert(Phong p)
        {
            return phongDA.Insert_Update_Delete(p, 0);
        }

        public int Update(Phong p)
        {
            return phongDA.Insert_Update_Delete(p, 1);
        }

        public int Delete(Phong p)
        {
            return phongDA.Insert_Update_Delete(p, 2);
        }
        public DataTable XemIPPhong()
        {
            return phongDA.XemIpPhong();
        }
		public Phong GetSingle(int id)
		{
			return phongDA.GetSinglePhong(id);
		}
	}
}
