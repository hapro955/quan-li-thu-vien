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
    public partial class DOCGIA : Form
    {
        ConnectDB conn = new ConnectDB();
        bool themmoi;
        public DOCGIA()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtSdt.Enabled = false;
            txtHinhanh.Enabled = false;

            bntThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }
        void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtSdt.Enabled = true;
            txtHinhanh.Enabled = true;

            bntThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }
        void setNull()
        {
            txtMa.Text = "Mã độc giả";
            txtTen.Text = "Tên độc giả";
            txtSdt.Text = "Số điện thoạt";
            txtHinhanh.Text = "Hình ảnh";
        }
        public void LoadData()
        {
            string sql = "select * from docgia";
            
            dgvDocgia.DataSource = conn.GetDataTable(sql);
        }

        private void DOCGIA_Load(object sender, EventArgs e)
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

        private void bntThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            setNull();
            txtMa.Enabled = false;
            txtMa.Text = "";
            txtTen.Text = "";
            txtSdt.Text = "";
            txtHinhanh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            txtMa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (themmoi == true)
            {
                conn.OpenDB();
                int count = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("docgia_them", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@ma", Convert.ToString(txtMa.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@hoten", Convert.ToString(txtTen.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@sdt", Convert.ToString(txtSdt.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@hinhanh", Convert.ToString(txtHinhanh.Text));
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

                    SqlCommand cmd = new SqlCommand("docgia_sua", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@ma", Convert.ToString(txtMa.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@hoten", Convert.ToString(txtTen.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@sdt", Convert.ToString(txtSdt.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@hinhanh", Convert.ToString(txtHinhanh.Text));
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
                SqlCommand cmd = new SqlCommand("docgia_xoa", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ma", Convert.ToString(txtMa.Text));
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
                MessageBox.Show("Độc giả đang mượn sách , không thể xóa!");
            conn.CloseDB();
        }

        private void dgvDocgia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDocgia.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMa.Text = Convert.ToString(dgvDocgia.CurrentRow.Cells[1].Value);
                    txtTen.Text = Convert.ToString(dgvDocgia.CurrentRow.Cells[2].Value);
                    txtSdt.Text=Convert.ToString(dgvDocgia.CurrentRow.Cells[3].Value);
                    txtHinhanh.Text = Convert.ToString(dgvDocgia.CurrentRow.Cells[4].Value);
                }
            }
            catch
            {
                MessageBox.Show("lỗi không tải dữ liệu lên được!");
            }
        }
    }
}
