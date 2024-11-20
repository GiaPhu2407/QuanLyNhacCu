using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHACCU.BLL
{
    class BLL_NhacCu
    {
        DAL.DAL_NhacCu dal_NC;
        FRM_NhacCu NC;
        public BLL_NhacCu(FRM_NhacCu fNC)
        {
            dal_NC = new DAL.DAL_NhacCu();
            NC = fNC;
        }
        public void BllLoadGrib()
        {
            NC.dataGridView1.DataSource = dal_NC.DalLoadGrid();
        }
        public void BllLoadCB_HangSX()
        {
            NC.cb_HangSX.DataSource = dal_NC.DalLoadComboHangSX();
            NC.cb_HangSX.DisplayMember = "TenHangNhacCu";
            NC.cb_HangSX.ValueMember = "MaHangNhacCu";
        }
        public void BllLoadCB_HangSXSelected()
        {
            dal_NC.DalLoadCB_HangSXselected(NC.cb_HangSX.SelectedValue.ToString());
        }
        public void BllLoadCB_NhaCCNC()
        {
            NC.cb_NhaCCNC.DataSource = dal_NC.DalLoadComboNhaCungCap();
            NC.cb_NhaCCNC.DisplayMember = "TenNhaCC";
            NC.cb_NhaCCNC.ValueMember = "MaNhaCC";
        }
        public void BllLoadCB_NhaCCNCSelected()
        {
            dal_NC.DalLoadCB_NhaCCNCselected(NC.cb_NhaCCNC.SelectedValue.ToString());
        }
        public void BllThem()
        {
            dal_NC.DalThem(NC.txt_MaNC.Text, NC.txt_TenNC.Text, NC.dateTimePicker2.Value, NC.cb_HangSX.SelectedValue.ToString(),
                NC.cb_NhaCCNC.SelectedValue.ToString(), NC.txt_TenAnhNC.Text);
        }
        public void BllSua()
        {
            dal_NC.DalSua(NC.txt_MaNC.Text, NC.txt_TenNC.Text, NC.dateTimePicker2.Value, NC.cb_HangSX.SelectedValue.ToString(),
                NC.cb_NhaCCNC.SelectedValue.ToString(), NC.txt_TenAnhNC.Text);
        }
        public void BllXoa()
        {
            dal_NC.DalXoa(NC.txt_MaNC.Text);
        }
        public void BllTim()
        {
            NC.dataGridView1.DataSource = dal_NC.DalTim();
        }
        public void BllDem()
        {
            NC.txt_DemNC.Text = dal_NC.DalDem().ToString();
        }

    }
}
