using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.DAL
{
    class DAL_DangKy
    {
        LopDungChung lopchung;
        public DAL_DangKy()
        {
            lopchung = new LopDungChung();
        }
        public void DalDangKy(string TenDN, string MatKhau)
        {
            string sqlDK = "insert into TAIKHOAN values ('" + TenDN + "', '" + MatKhau + "')";
            lopchung.Nonquery(sqlDK);
        }
    }
}
