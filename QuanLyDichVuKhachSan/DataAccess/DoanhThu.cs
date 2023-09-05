using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DoanhThu
    {
		public DateTime NgayLapHD { get; set; }
		public DateTime NgayKetThucHD { get; set; }
        public int MaHD { get; set; }
		public string TenDV { get; set; }
		public int SoLuong { get; set; }
		public int DonGia { get; set; }		    
        public float ThanhTien { get;set;}
    }
}
