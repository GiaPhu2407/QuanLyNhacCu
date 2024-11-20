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
    public partial class FRM_TAOTAIKHOAN : Form
    {
        LopDungChung lopchung;
        BLL.BLL_DangKy BLL_DK;
        public FRM_TAOTAIKHOAN()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            BLL_DK = new BLL.BLL_DangKy(this);
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            BLL_DK.BllDangKy();
        }
        
        private void btn_Thoat_new_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
