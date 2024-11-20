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
    public partial class FRM_NhacCu : Form
    {
        LopDungChung lopchung;
        BLL.BLL_NhacCu BLL_NC;
        public FRM_NhacCu()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            BLL_NC = new BLL.BLL_NhacCu(this);
        }     
        private void FRM_NhacCu_Load(object sender, EventArgs e)
        {         
            Loadcb_HangSX();
            Loadcb_NhaCC();
            LoadData();
        }
        public void LoadData()
        {
            BLL_NC.BllLoadGrib();
        }
        public void Loadcb_HangSX()
        {
            BLL_NC.BllLoadCB_HangSX();
        }
        public void Loadcb_NhaCC()
        {
            BLL_NC.BllLoadCB_NhaCCNC();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_ThemNC_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"D:\LapTrinh_Net\QUANLYNHACCU_3Layer\QUANLYNHACCU\HINHANH\" + txt_TenAnhNC.Text);
                BLL_NC.BllThem();
            }
            catch (Exception) { MessageBox.Show("Chưa có tên hình"); }
            LoadData();
        }
        private void btn_SuaNC_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"D:\LapTrinh_Net\QUANLYNHACCU_3Layer\QUANLYNHACCU\HINHANH\" + txt_TenAnhNC.Text);
            BLL_NC.BllSua();
            LoadData();
        }
        private void btn_XoaNC_Click(object sender, EventArgs e)
        {
            File.Delete(duongdan + txt_TenAnhNC.Text);
            BLL_NC.BllXoa();
            LoadData();
        }
        private void btn_LoadGrid_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        int tim = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNC.Text = dataGridView1.CurrentRow.Cells["MaNhacCu"].Value.ToString();
            txt_TenNC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_TenAnhNC.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_TenAnhNC.Text;
            tim = 1;
            cb_HangSX.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cb_NhaCCNC.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tim = 0;
        }
        private void cb_HangSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                BLL_NC.BllLoadCB_HangSXSelected();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn hình";
            OFD.Filter = "Tất cả đuôi hình|*.*|PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }
        private void btn_DemNC_Click(object sender, EventArgs e)
        {
            BLL_NC.BllDem();
        }
        private void btn_TimNC_Click(object sender, EventArgs e)
        {
            BLL_NC.BllTim();
        }       
        private void cb_NhaCCNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                BLL_NC.BllLoadCB_NhaCCNCSelected();
            }
        }

        
    }
}
