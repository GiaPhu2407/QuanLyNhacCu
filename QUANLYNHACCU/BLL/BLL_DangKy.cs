using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHACCU.BLL
{
    class BLL_DangKy
    {
        DAL.DAL_DangKy dal_DK;
        FRM_TAOTAIKHOAN TTK;
        public BLL_DangKy(FRM_TAOTAIKHOAN fTTK)
        {
            dal_DK = new DAL.DAL_DangKy();
            TTK = fTTK;
        }
        public void BllDangKy()
        {
        dal_DK.DalDangKy(TTK.txt_TenDN_new.Text, TTK.txt_MatKhau_new.Text);
            
        }
    }
}
