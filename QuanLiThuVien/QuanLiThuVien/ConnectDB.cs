using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLiThuVien
{
    class ConnectDB
    {
        public static SqlConnection connect;
        /// <summary>
        /// hàm mở kết nối
        /// </summary>
        public void OpenDB()
        {
            if (ConnectDB.connect == null)
                ConnectDB.connect = new SqlConnection(@"Data Source=HAPRO955\SQLEXPRESS; Database=QLLTPM; Integrated Security=True");
            if (ConnectDB.connect.State != ConnectionState.Open)
                ConnectDB.connect.Open();
        }

        /// <summary>
        /// hàm đóng kết nối
        /// </summary>
        public void CloseDB()
        {
            if (ConnectDB.connect != null)
            {
                if (ConnectDB.connect.State == ConnectionState.Open)
                    ConnectDB.connect.Close();
            }
        }
        /// <summary>
        /// lấy dữ liệu từ database(sqladapter) rồi đổ lên datatable 
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                OpenDB();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                CloseDB();
                return dt;
            }
            catch
            {
                MessageBox.Show("lỗi!, không lấy được dữ liệu");
                return null;
            }
        }
    }
}
