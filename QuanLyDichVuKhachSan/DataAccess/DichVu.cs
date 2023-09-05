using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DichVu
    {
        public int ID { get; set; }
        public string TenDV { get; set; }
        public int IDLoaiDichVu { get; set; }
        public float DonGia { get; set; }
        public string DVT { get; set; }
        public string LuuY { get; set; }
    }
}
