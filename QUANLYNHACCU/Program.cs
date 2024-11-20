using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHACCU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_DangNhap());
            //Application.Run(new FRM_TRANGCHU());
            //Application.Run(new FRM_HangNhacCu());
            //Application.Run(new FRM_NhacCu());
            //Application.Run(new FRM_NhaCungCap());

        }
    }
}
