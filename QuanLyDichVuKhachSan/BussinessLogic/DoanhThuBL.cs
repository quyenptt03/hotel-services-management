using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class DoanhThuBL
    {
        DoanhThuDA doanhThuDA = new DoanhThuDA();
        public List<DoanhThu> GetAll()
        {
            return doanhThuDA.GetAll();
        }
        public List<DoanhThu> DoanhThuByDate(DateTime tungay, DateTime denngay)
        {
            return doanhThuDA.DoanhThuByDate(tungay, denngay);
        }
        public List<DoanhThu> DoanhThuByDay(DateTime tungay)
        {
            return doanhThuDA.DoanhThuByDay(tungay);
        }
		public DataTable DoanhThuByDay_DichVu(DateTime tungay)
		{
			return doanhThuDA.DoanhThuByDay_DichVu(tungay);
		}
		


	}
}
