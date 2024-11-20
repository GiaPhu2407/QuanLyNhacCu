using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.DAL
{
    class DAL_DangNhap
    {
        LopDungChung lopchung;
        public DAL_DangNhap()
        {
            lopchung = new LopDungChung();

        }
        public int DalDangNhap(string TenDN, string MatKhau)
        {
            string sqlDN = "select count (*) from TAIKHOAN where TenDangNhap = '" +
                TenDN + "' and MatKhau = '" + MatKhau + "'";
            return (int)lopchung.Scalar(sqlDN);           
        }
        
    }
}
