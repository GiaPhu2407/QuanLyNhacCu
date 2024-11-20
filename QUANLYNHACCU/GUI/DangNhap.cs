using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHACCU
{
    public partial class FRM_DangNhap : Form
    {
        LopDungChung lopchung;
        BLL.BLL_DangNhap Bll_DN;
        public FRM_DangNhap()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            Bll_DN = new BLL.BLL_DangNhap(this);
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Bll_DN.BllDangNhap();
            
        }
         int tam = 0;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                tam = 1;
                Application.Exit();
            }
        }

        private void FRM_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tam == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }  
        private void btn_DangKy_Click(object sender, EventArgs e)
        {            
                FRM_TAOTAIKHOAN TTK = new FRM_TAOTAIKHOAN();
                TTK.Show();
        }
    }
}
