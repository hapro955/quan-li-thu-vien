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
    public partial class PHIEUMUON : Form
    {
        ConnectDB conn = new ConnectDB();
        bool themmoi;
        public PHIEUMUON()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KhoaDieuKhien()
        {
            txtMadocgia.Enabled = false;
            txtMaphieumuon.Enabled = false;
            dtpNgaymuon.Enabled = false;
            dtpNgaytra.Enabled = false;

            bntThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }
        void MoDieuKhien()
        {
            txtMadocgia.Enabled = true;
            txtMaphieumuon.Enabled = true;
            dtpNgaymuon.Enabled = true;
            dtpNgaytra.Enabled = true;

            bntThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }
        void setNull()
        {
            txtMadocgia.Text = "Mã độc giả";
            txtMaphieumuon.Text = "Mã phiếu mượn";
        }
        public void LoadData()
        {
            string sql = "select * from phieumuon";
            DataTable dt = new DataTable();
            dt = conn.GetDataTable(sql);
            dgvPhieumuon.DataSource = dt;
        }
        private void PHIEUMUON_Load(object sender, EventArgs e)
        {
            LoadData();
            KhoaDieuKhien();
            setNull();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            setNull();
        }

        private void dgvPhieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {                   
                    txtMaphieumuon.Text = Convert.ToString(dgvPhieumuon.CurrentRow.Cells[1].Value);
                    txtMadocgia.Text = Convert.ToString(dgvPhieumuon.CurrentRow.Cells[2].Value);
                    dtpNgaymuon.Text = Convert.ToString(dgvPhieumuon.CurrentRow.Cells[3].Value);
                    dtpNgaytra.Text = Convert.ToString(dgvPhieumuon.CurrentRow.Cells[4].Value);
                }
            }
            catch
            {
                MessageBox.Show("lỗi không tải dữ liệu lên được!");
            }
        }

        private void dgvPhieumuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieumuon.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            setNull();
            txtMaphieumuon.Enabled = false;
            txtMaphieumuon.Text = "";
            txtMadocgia.Text = "";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            txtMaphieumuon.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                conn.OpenDB();
                int count = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("phieumuon_them", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mapm", Convert.ToString(txtMaphieumuon.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@madg", Convert.ToString(txtMadocgia.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaym", Convert.ToString(dtpNgaymuon.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngayt", Convert.ToString(dtpNgaytra.Value));
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

                    SqlCommand cmd = new SqlCommand("phieumuon_sua", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mapm", Convert.ToString(txtMaphieumuon.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@madg", Convert.ToString(txtMadocgia.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaym", Convert.ToString(dtpNgaymuon.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngayt", Convert.ToString(dtpNgaytra.Value));
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
                SqlCommand cmd = new SqlCommand("phieumuon_xoa", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ma", Convert.ToString(txtMaphieumuon.Text));
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
                MessageBox.Show("Phiếu mượn đang chứa sách , không thể xóa!");
            conn.CloseDB();
        }
    }
}
