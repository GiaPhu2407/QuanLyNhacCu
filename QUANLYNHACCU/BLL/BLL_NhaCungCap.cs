using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.BLL
{
    class BLL_NhaCungCap
    {
        DAL.DAL_NhaCungCap dal_NhaCC;
        FRM_NhaCungCap NCC;
        public BLL_NhaCungCap(FRM_NhaCungCap fNCC)
        {
            dal_NhaCC = new DAL.DAL_NhaCungCap();
            NCC = fNCC;
        }
        public void BllLoadGrid()
        {
            NCC.dataGridView1.DataSource = dal_NhaCC.DalLoadGrid();
        }
        public void BllThem()
        {
            dal_NhaCC.DalThem(NCC.txt_MaNhaCC.Text, NCC.txt_TenNhaCC.Text, NCC.txt_SoDT.Text, NCC.txt_DiaChi.Text, NCC.txt_AnhNCC.Text);
        }
        public void BllSua()
        {
            dal_NhaCC.DalSua(NCC.txt_MaNhaCC.Text, NCC.txt_TenNhaCC.Text, NCC.txt_SoDT.Text, NCC.txt_DiaChi.Text, NCC.txt_AnhNCC.Text);
        }
        public void BllXoa()
        {
            dal_NhaCC.DalXoa(NCC.txt_MaNhaCC.Text);
        }

    }
}
