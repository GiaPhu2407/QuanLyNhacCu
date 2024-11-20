using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHACCU.BLL
{
    class BLL_DangNhap
    {
        DAL.DAL_DangNhap dal_DN;
        FRM_DangNhap DN;
        public BLL_DangNhap(FRM_DangNhap fDN)
        {
            dal_DN = new DAL.DAL_DangNhap();
            DN = fDN;
        }
        public void BllDangNhap()
        {
          int ketqua = dal_DN.DalDangNhap(DN.txt_TaiKhoan.Text, DN.txt_MatKhau.Text);
            if (ketqua>=1)
            {
                FRM_TRANGCHU TT= new FRM_TRANGCHU();
                TT.Show();
            }
            else MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu hoặc tài khoản chưa tồn tại bạn có thể đăng ký tài khoản mới", "Thông Báo");
        }       
    }
}
