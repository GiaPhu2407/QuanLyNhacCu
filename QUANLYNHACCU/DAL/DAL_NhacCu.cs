using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.DAL
{
    class DAL_NhacCu
    {
        LopDungChung lopchung;
        public DAL_NhacCu()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlLoadGrid = "select * from NHACCU ";
            return lopchung.LoadDuLieu(sqlLoadGrid);
        }
        public DataTable DalLoadComboHangSX()
        {
            string sqlLoadComboHSX = "select * from HANGNHACCU";
            return lopchung.LoadDuLieu(sqlLoadComboHSX);
        }
        public DataTable DalLoadCB_HangSXselected(string HangSX)
        {
            string sqlLoadCB_HSXSelect = "select * from NHACCU where MaHangNhacCu = '"
                    + HangSX + "'";
            return lopchung.LoadDuLieu(sqlLoadCB_HSXSelect);
        }
        public DataTable DalLoadComboNhaCungCap()
        {
            string sqlLoadComboNCC = "select * from NHACUNGCAP";         
            return lopchung.LoadDuLieu(sqlLoadComboNCC);
        }
        public DataTable DalLoadCB_NhaCCNCselected(string NhaCCNC)
        {
            string sqlCB_NhaCCNCSelect = "select * from NHACCU where MaNhaCC = '"
                    + NhaCCNC + "'";
            return lopchung.LoadDuLieu(sqlCB_NhaCCNCSelect);
        }
        public void DalThem(string MaNC, string TenNC, DateTime NgayNhapHang, string HangSX, string NhaCCNC, string TenAnh)
        {
            string sqlThem = "insert into NHACCU values ('" + MaNC + "', '" + TenNC
                + "', Convert(DateTime, '" + NgayNhapHang
                + "' ,103), '" + HangSX + "', '" + NhaCCNC + "', '" + TenAnh + "')";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(string MaNC, string TenNC, DateTime NgayNhapHang, string HangSX, string NhaCCNC, string TenAnh)
        {
            string sqlSua = "Update NHACCU set TenNhacCu = N'" + TenNC +
                "', NgayNhapHang = Convert(DateTime, '" + NgayNhapHang +
                "' ,103), MaHangNhacCu = '" + HangSX + "', MaNhaCC = '" + NhaCCNC + "', TenAnh = '" + TenAnh +
                "' where MaNhacCu = '" + MaNC + "' ";
            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(string MaNC)
        {
            string sqlXoa = "delete NHACCU where MaNhacCu = '" + MaNC + "' ";
            lopchung.Nonquery(sqlXoa);
        }
        public DataTable DalTim()
        {
            string nhap = Interaction.InputBox("Nhap vao ten hoac ma nhac cu");
            string sqlTim = "select * from NHACCU where MaNhacCu like '%" + nhap + "%' or TenNhacCu like '%" + nhap + "%' ";
            return lopchung.LoadDuLieu(sqlTim);
        }
        public int DalDem()
        {
            string sqlDem = "select count (*) from NHACCU ";
            int ketQua = (int)lopchung.Scalar(sqlDem);
            return ketQua;
        }
        
    }
}
