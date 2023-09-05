using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKH { get; set; }
        public string CMND_CCCD { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int LoaiKH { get; set; }
        public int Status { get; set; }
		public int MaPhong { get; set; }
	}
}
