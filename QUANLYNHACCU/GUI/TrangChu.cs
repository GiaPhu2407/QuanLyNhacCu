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
    public partial class FRM_TRANGCHU : Form
    {
        public FRM_TRANGCHU()
        {
            InitializeComponent();
        }

        private void qUANLYNHACCUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FRM_NhacCu"] == null)
            {
                FRM_NhacCu NC = new FRM_NhacCu();
                NC.MdiParent = this;
                NC.Show();
            }
            else Application.OpenForms["FRM_NhacCu"].Activate();
        }

        private void tIMKIMNHACCUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FRM_NhaCungCap"] == null)
            {
                FRM_NhaCungCap TK = new FRM_NhaCungCap();
                TK.MdiParent = this;
                TK.Show();
            }
            else Application.OpenForms["FRM_NhaCungCap"].Activate();
        }

        private void qUANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FRM_HangNhacCu"] == null)
            {
                FRM_HangNhacCu TK = new FRM_HangNhacCu();
                TK.MdiParent = this;
                TK.Show();
            }
            else Application.OpenForms["FRM_HangNhacCu"].Activate();
        }
    }
}
