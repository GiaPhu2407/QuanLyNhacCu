using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace QUANLYNHACCU
{
    public partial class FRM_HangNhacCu : Form
    {
        LopDungChung lopchung;
        BLL.BLL_HangNhacCu bll_HNC;
        public FRM_HangNhacCu()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_HNC = new BLL.BLL_HangNhacCu(this);
        }

        private void FRM_HangNhacCu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            bll_HNC.BllLoadGrib();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_ThemHNC_Click(object sender, EventArgs e)
        {           
            try
            {
                pictureBox1.Image.Save(@"D:\LapTrinh_Net\QUANLYNHACCU_3Layer\QUANLYNHACCU\HINHANH\" + txt_TenAnhHNC.Text);
                bll_HNC.BllThem();
            }
            catch (Exception) { MessageBox.Show("Chưa có tên hình"); }
            LoadData();
        }

        private void btn_SuaHNC_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"D:\LapTrinh_Net\QUANLYNHACCU_3Layer\QUANLYNHACCU\HINHANH\" + txt_TenAnhHNC.Text);
            bll_HNC.BllSua();
            LoadData();
        }

        private void btn_XoaHNC_Click(object sender, EventArgs e)
        {
            File.Delete(duongdan + txt_TenAnhHNC.Text);
            bll_HNC.BllXoa();
            LoadData();
        }

        private void btn_RefreshHNC_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_TimHNC_Click(object sender, EventArgs e)
        {
            bll_HNC.BllTim();
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHNC.Text = dataGridView1.CurrentRow.Cells["MaHangNhacCu"].Value.ToString();
            txt_TenHNC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_NoiSX.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_TenAnhHNC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_TenAnhHNC.Text;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn hình";
            OFD.Filter = "Tất cả đuôi hình|*.*|PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }
    }
}
