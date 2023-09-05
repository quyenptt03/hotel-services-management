using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    class Ultilities
    {
		private static string StrName = "ConnectionStringName";

		public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;
		// Các biến của bảng Phong
        public static string Phong_GetAll = "USP_XemPhong";
        public static string Phong_InsertUpdateDelete = "Phong_InsertUpdateDelete";
		public static string Phong_GetSingle = "Phong_GetSingle";
		public static string Phong_XemIPPhong = "USP_XemIPPhong";
		// Các biến của bảng LoaiDichVu
		public static string LoaiDichVu_GetAll = "USP_XemLoaiDichVu";
        public static string LoaiDichVu_InsertUpdateDelete = "LoaiDichVu_InsertUpdateDelete";
		public static string DichVu_GetSingle = "DichVu_GetSingle";
		public static string DichVu_GetByCategory = "DichVu_LoaiDV";
		// Các biến của bảng DichVu
		public static string DichVu_GetAll= "USP_XemDSDichVu";
        public static string DichVu_InsertUpdateDelete = "DichVu_InsertUpdateDelete";
        public static string DichVu_SapTen = "USP_SapTen";
        public static string DichVu_SapGia = "USP_SapGia";
		public static string DichVu_XemLoaiDV = "USP_XemLoaiDV";
		// cac bien cua bang HoaDon
		public static string HoaDon_GetAll = "USP_XemHoaDon";
		public static string HoaDon_InsertUpdateDelete = "HoaDon_InsertUpdateDelete";
		public static string HoaDon_GetByRoom = "getHDChuaThanhToan_TheoPhong";
		// cac bien cua bang ChiTietHD
		public static string ChiTietHD_GetAll = "USP_XemChiTietHD";
		public static string ChiTietHD_InsertUpdateDelete = "ChiTietHD_InsertUpdateDelete";
		public static string ChiTietHD_GetUsedByRoom = "GetDSDichVu_Phong";
		public static string ChiTietHD_GetSingle = "ChiTietHD_GetSingle";
		// cac bien cua bang khach hang
		public static string KhachHang_GetAll = "USP_XemKhachHang";
        public static string KhachHang_Delete = "sp_delete_KhachHang";
		public static string KhachHang_Update = "sp_update_KhachHang";
		public static string KhachHang_InsertUpdateDelete = "KhachHang_InsertUpdateDelete";
		public static string KhachHang_GetByRoom = "GetKhachHang_Phong";
		// cac bien cua bang DoanhThu
		public static string DoanhThu_GetAll = "USP_XemDoanhThu";
        public static string DoanhThu_InsertUpdateDelete = "DoanhThu_InsertUpdateDelete";
        public static string DoanhThu_ByDate = "USP_DoanhThuByDate";
		public static string DoanhThu_ByDay = "USP_DoanhThuByDay";
		// cac bien cua bang TaiKhoan
		public static string TaiKhoan_GetAll = "USP_XemTaiKhoan";
        public static string TaiKhoan_InsertUpdateDelete = "TaiKhoan_InsertUpdateDelete";
		public static string TaiKhoan_DangNhapByTenTK = "USP_DangNhapByTenTK";
		public static string TaiKhoan_Login = "USP_Login";
		


	}
}
