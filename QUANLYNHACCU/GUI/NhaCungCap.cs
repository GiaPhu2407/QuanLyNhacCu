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
    public partial class FRM_NhaCungCap : Form
    {
        LopDungChung lopchung;
        BLL.BLL_NhaCungCap BLL_NCC;
        public FRM_NhaCungCap()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            BLL_NCC = new BLL.BLL_NhaCungCap(this);
        }
        private void FRM_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            BLL_NCC.BllLoadGrid();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +"\\HINHANH\\";
        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {           
            try
            {
                pictureBox1.Image.Save(@"D:\LapTrinh_Net\QUANLYNHACCU_3Layer\QUANLYNHACCU\HINHANH\" + txt_AnhNCC.Text);
                BLL_NCC.BllThem();
            }
            catch (Exception) { MessageBox.Show("Chưa có tên hình"); }
            LoadData();
        }
        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {           
            pictureBox1.Image.Save(@"D:\LapTrinh_Net\QUANLYNHACCU_3Layer\QUANLYNHACCU\HINHANH\" + txt_AnhNCC.Text);
            BLL_NCC.BllSua();
            LoadData();
        }
        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {           
            File.Delete(duongdan + txt_AnhNCC.Text);
            BLL_NCC.BllXoa();
            LoadData();
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNhaCC.Text = dataGridView1.CurrentRow.Cells["MaNhaCC"].Value.ToString();
            txt_TenNhaCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SoDT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_AnhNCC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_AnhNCC.Text;                         
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
