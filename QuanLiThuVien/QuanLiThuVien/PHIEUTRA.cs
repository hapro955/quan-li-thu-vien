using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLiThuVien
{
    public partial class PHIEUTRA : Form
    {
        ConnectDB conn = new ConnectDB();
        bool themmoi;
        public PHIEUTRA()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KhoaDieuKhien()
        {
            txtMaphieutra.Enabled = false;
            txtMaphieumuon1.Enabled = false;
            txtTienPhat.Enabled = false;
            dtpNgaytrathat.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }
        void MoDieuKhien()
        {
            txtMaphieutra.Enabled = true;
            txtMaphieumuon1.Enabled = true;
            txtTienPhat.Enabled = true;
            dtpNgaytrathat.Enabled = true;


            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }
        void setNull()
        {
            txtMaphieutra.Text = "Mã phiếu trả";
            txtMaphieumuon1.Text = "Mã phiếu mượn";
            txtTienPhat.Text = "0";
        }
        public void LoadData()
        {
            string sql = "select * from phieutra";
            DataTable dt = new DataTable();
            dt = conn.GetDataTable(sql);
            dgvPhieuTra.DataSource = dt;
        }

        private void PHIEUTRA_Load(object sender, EventArgs e)
        {
            LoadData();
            KhoaDieuKhien();
            setNull();
        }

        private void dgvPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaphieutra.Text = Convert.ToString(dgvPhieuTra.CurrentRow.Cells[1].Value);
                    txtMaphieumuon1.Text = Convert.ToString(dgvPhieuTra.CurrentRow.Cells[2].Value);
                    dtpNgaytrathat.Text = Convert.ToString(dgvPhieuTra.CurrentRow.Cells[3].Value);
                    txtTienPhat.Text = Convert.ToString(dgvPhieuTra.CurrentRow.Cells[4].Value);
                }
            }
            catch
            {
                MessageBox.Show("lỗi không tải dữ liệu lên được!");
            }
        }

        private void dgvPhieuTra_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuTra.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            setNull();
            txtMaphieutra.Enabled = false;
            txtMaphieutra.Text = "";
            txtMaphieumuon1.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            txtMaphieutra.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                conn.OpenDB();
                int count = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("phieutra_them", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mapt", Convert.ToString(txtMaphieutra.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mapm", Convert.ToString(txtMaphieumuon1.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaytrathat", Convert.ToString(dtpNgaytrathat.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@tienphat", Convert.ToInt16(txtTienPhat.Text));
                    cmd.Parameters.Add(p);
                    count = cmd.ExecuteNonQuery();
                }
                catch
                {
                    count = -1;
                }
                if (count > 0)
                {
                    MessageBox.Show("thêm mới thành công!");
                    LoadData();
                    KhoaDieuKhien();
                    setNull();
                }
                else
                    MessageBox.Show("lỗi không thêm được!");
                conn.CloseDB();
            }
            else
            {
                conn.OpenDB();
                int count = 0;
                try
                {

                    SqlCommand cmd = new SqlCommand("phieutra_sua", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mapt", Convert.ToString(txtMaphieutra.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mapm", Convert.ToString(txtMaphieumuon1.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaytrathat", Convert.ToString(dtpNgaytrathat.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@tienphat", Convert.ToInt16(txtTienPhat.Text));
                    cmd.Parameters.Add(p);
                    count = cmd.ExecuteNonQuery();

                }
                catch
                {
                    count = -1;
                }
                if (count > 0)
                {
                    MessageBox.Show("sửa thành công!");
                    LoadData();
                    KhoaDieuKhien();
                    setNull();
                }
                else
                    MessageBox.Show("sửa không thành công!");
                conn.CloseDB();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.OpenDB();
            int count = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("phieutra_xoa", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ma", Convert.ToString(txtMaphieutra.Text));
                cmd.Parameters.Add(p);
                count = cmd.ExecuteNonQuery();
            }
            catch
            {
                count = -1;
            }
            if (count > 0)
            {
                MessageBox.Show("xóa thành công!");
                LoadData();
                KhoaDieuKhien();
                setNull();
            }
            else
                MessageBox.Show("Xóa không thành công!");
            conn.CloseDB();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            setNull();
        }
    }
}
