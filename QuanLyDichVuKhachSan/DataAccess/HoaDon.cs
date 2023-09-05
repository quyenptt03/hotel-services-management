using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HoaDon
    {
        public int ID { get; set; }
        public DateTime NgayLapHD { get; set; }
        public DateTime NgayKetThucHD { get; set; }
        public int MaPhong { get; set; }
        public float TongTien { get; set; }
        public float GiamGia { get; set; }
        public float ThanhTien { get;set; }
        public int Status { get; set; }
    }
}
