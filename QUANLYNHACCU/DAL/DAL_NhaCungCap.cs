using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.DAL
{
    class DAL_NhaCungCap
    {
        LopDungChung lopchung;
        public DAL_NhaCungCap()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlLoadGrid = "select * from NHACUNGCAP ";
            return lopchung.LoadDuLieu(sqlLoadGrid);
        }
        public void DalThem(string MaNCC, string TenNCC,string SDT, string DiaChi, string TenAnh)
        {
            string sqlThem = "insert into NHACUNGCAP values ('" + MaNCC + "', N'" + TenNCC +
                 "', '" + SDT + "','" + DiaChi + "' ,'" + TenAnh + "')";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(string MaNCC, string TenNCC, string SDT, string DiaChi, string TenAnh)
        {
            string sqlSua = "Update NHACUNGCAP set TenNhaCC = N'" + TenNCC +
                "', SoDT = '" + SDT + "', DiaChi = '" + DiaChi + "', TenAnhNCC = '" + TenAnh +
                "' where MaNhaCC = '" + MaNCC + "' ";
            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(string MaNCC)
        {
            string sqlXoa = "delete NHACUNGCAP where MaNhaCC = '" + MaNCC + "' ";
            lopchung.Nonquery(sqlXoa);
        }


    }
}
