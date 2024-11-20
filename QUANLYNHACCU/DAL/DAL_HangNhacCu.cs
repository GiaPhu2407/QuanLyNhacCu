using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.DAL
{
    class DAL_HangNhacCu
    {
        LopDungChung lopchung;
        public DAL_HangNhacCu()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlLoadGrid = "select * from HANGNHACCU ";
            return lopchung.LoadDuLieu(sqlLoadGrid);
        }
        public void DalThem(string MaHNC, string TenHNC, string NoiSX, string TenAnh)
        {
            string sqlThem = "insert into HANGNHACCU values ('" + MaHNC + "', '" + TenHNC
                + "', '" + NoiSX + "', '" + TenAnh + "')";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(string MaHNC, string TenHNC, string NoiSX, string TenAnh)
        {
            string sqlSua = "Update HANGNHACCU set TenHangNhacCu = '" + TenHNC +
                "', NoiSanXuat = '" + NoiSX + "', AnhHangNhacCu = '" + TenAnh +
                "' where MaHangNhacCu = '" + MaHNC + "' ";
            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(string MaHNC)
        {
            string sqlXoa = "delete HANGNHACCU where MaHangNhacCu = '" + MaHNC + "' ";
            lopchung.Nonquery(sqlXoa);
        }
        public DataTable DalTim()
        {
            string nhap = Interaction.InputBox("Nhap vao ten hoac ma hang nhac cu");
            string sqlTim = "select * from HANGNHACCU where MaHangNhacCu like '%" + nhap + "%' or TenHangNhacCu like '%" + nhap + "%' ";
            return lopchung.LoadDuLieu(sqlTim);
        }
    }
}
