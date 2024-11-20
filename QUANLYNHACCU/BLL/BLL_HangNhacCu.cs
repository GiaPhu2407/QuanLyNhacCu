using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.BLL
{
    class BLL_HangNhacCu
    {
        DAL.DAL_HangNhacCu dal_HNC;
        FRM_HangNhacCu HNC;
        public BLL_HangNhacCu(FRM_HangNhacCu fHNC)
        {
            dal_HNC = new DAL.DAL_HangNhacCu();
            HNC = fHNC;
        }
        public void BllLoadGrib()
        {
            HNC.dataGridView1.DataSource = dal_HNC.DalLoadGrid();
        }
        public void BllThem()
        {
            dal_HNC.DalThem(HNC.txt_MaHNC.Text, HNC.txt_TenHNC.Text, HNC.txt_NoiSX.Text, HNC.txt_TenAnhHNC.Text);
        }
        public void BllSua()
        {
            dal_HNC.DalSua(HNC.txt_MaHNC.Text, HNC.txt_TenHNC.Text, HNC.txt_NoiSX.Text, HNC.txt_TenAnhHNC.Text);
        }
        public void BllXoa()
        {
            dal_HNC.DalXoa(HNC.txt_MaHNC.Text);
        }
        public void BllTim()
        {
            HNC.dataGridView1.DataSource = dal_HNC.DalTim();
        }


    }
}
