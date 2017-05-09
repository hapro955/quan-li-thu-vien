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
    public partial class THEDOCGIA : Form
    {
        ConnectDB conn = new ConnectDB();
        bool themmoi;
        public THEDOCGIA()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KhoaDieuKhien()
        {
            txtMathedocgia.Enabled = false;
            txtMadocgia.Enabled = false;
            dtpNgaylamthe.Enabled = false;
            dtpNgayhethan.Enabled = false;

            bntThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }
        void MoDieuKhien()
        {
            txtMathedocgia.Enabled = true;
            txtMadocgia.Enabled = true;
            dtpNgaylamthe.Enabled = true;
            dtpNgayhethan.Enabled = true;

            bntThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }
        void setNull()
        {
            txtMathedocgia.Text = "Mã thẻ độc giả";
            txtMadocgia.Text = "Mã độc giả";
        }
        public void LoadData()
        {
            string sql = "select * from thedocgia";
         
            dgvThedocgia.DataSource = conn.GetDataTable(sql);
        }

        private void THEDOCGIA_Load(object sender, EventArgs e)
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
                    txtMathedocgia.Text = Convert.ToString(dgvThedocgia.CurrentRow.Cells[1].Value);
                    txtMadocgia.Text = Convert.ToString(dgvThedocgia.CurrentRow.Cells[2].Value);
                    dtpNgaylamthe.Text = Convert.ToString(dgvThedocgia.CurrentRow.Cells[3].Value);
                    dtpNgayhethan.Text = Convert.ToString(dgvThedocgia.CurrentRow.Cells[4].Value);
                }
            }
            catch
            {
                MessageBox.Show("lỗi không tải dữ liệu lên được!");
            }
        }

        private void dgvPhieumuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThedocgia.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            setNull();
            txtMathedocgia.Enabled = false;
            txtMathedocgia.Text = "";
            txtMadocgia.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            txtMathedocgia.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                conn.OpenDB();
                int count = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("thedocgia_them", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@matdg", Convert.ToString(txtMathedocgia.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@madg", Convert.ToString(txtMadocgia.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaylt", Convert.ToString(dtpNgaylamthe.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngayhh", Convert.ToString(dtpNgayhethan.Value));
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

                    SqlCommand cmd = new SqlCommand("thedocgia_sua", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@matdg", Convert.ToString(txtMathedocgia.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@madg", Convert.ToString(txtMadocgia.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaylt", Convert.ToString(dtpNgaylamthe.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngayhh", Convert.ToString(dtpNgayhethan.Value));
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
                SqlCommand cmd = new SqlCommand("thedocgia_xoa", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ma", Convert.ToString(txtMathedocgia.Text));
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

       
    }
}
