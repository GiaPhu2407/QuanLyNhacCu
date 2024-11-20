using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHACCU
{
    class LopDungChung
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\QUANLYNHACCU_3Layer\QUANLYNHACCU_3Layer\QUANLYNHACCU\QL_NHACCU.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }
        public DataTable LoadDuLieu(string sqlLoad)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlLoad, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1)
                MessageBox.Show("Thành công");
            else MessageBox.Show("Thất bại");

        }
        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();                    
            conn.Close();
            return ketqua;
        }

    }
}
