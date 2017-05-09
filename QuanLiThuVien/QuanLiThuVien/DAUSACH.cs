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
    public partial class DAUSACH : Form
    {
        ConnectDB conn = new ConnectDB();
        bool themmoi;
        public DAUSACH()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KhoaDieuKhien()
        {
            txtMaDauSach.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtSoQuyen.Enabled = false;
            txtTenDauSach.Enabled = false;
            cmbNhomSach.Enabled = false;
            rtxtTomTat.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }
        void MoDieuKhien()
        {
            txtMaDauSach.Enabled = true;
            txtNgonNgu.Enabled = true;
            txtSoQuyen.Enabled = true;
            txtTenDauSach.Enabled = true;
            cmbNhomSach.Enabled = true;
            rtxtTomTat.Enabled = true;


            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }
        void setNull()
        {
            txtMaDauSach.Text = "Mã đầu sách";
            txtNgonNgu.Text = "Ngôn ngữ";
            txtSoQuyen.Text = "Số quyển ";
            txtTenDauSach.Text = "Tên đầu sách";
            cmbNhomSach.Text = "Nhóm sách";
            rtxtTomTat.Text = "Nội dung";
        }
        private void LoadData()
        {
            string sql = "select * from dausach";
            dgvDauSach.DataSource = conn.GetDataTable(sql);
        }
        private void show_ComboNhomSach()
        {
            string sql = "select * from nhomsach";
            cmbNhomSach.DataSource = conn.GetDataTable(sql);
            cmbNhomSach.ValueMember = "ma_nhomsach";
            cmbNhomSach.DisplayMember = "tennhomsach";

        }

        private void DAUSACH_Load(object sender, EventArgs e)
        {
            LoadData();
            show_ComboNhomSach();
            KhoaDieuKhien();
            setNull();
        }

        private void dgvPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaDauSach.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["a"].Value);
                    txtTenDauSach.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["b"].Value);
                    cmbNhomSach.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["c"].Value);
                    txtNgonNgu.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["d"].Value);
                    txtSoQuyen.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["e"].Value);
                    rtxtTomTat.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["f"].Value);
                }
            }
            catch
            {
                MessageBox.Show("lỗi không tải dữ liệu lên được!");
            }
        }

        private void dgvDauSach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDauSach.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1; 

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            txtMaDauSach.Enabled = false;
            txtMaDauSach.Text = "";
            txtNgonNgu.Text = "";
            txtSoQuyen.Text = "";
            txtTenDauSach.Text = "";
            cmbNhomSach.Text = "";
            rtxtTomTat.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            txtMaDauSach.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                conn.OpenDB();
                int count = 0;
                try
                {
                    	
                    SqlCommand cmd = new SqlCommand("dausach_them", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mads", Convert.ToString(txtMaDauSach.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mans", Convert.ToString(cmbNhomSach.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngonngu", Convert.ToString(txtNgonNgu.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@tomtat", Convert.ToString(rtxtTomTat.Text));
                    cmd.Parameters.Add(p);
                     p = new SqlParameter("@trangthai", Convert.ToString(txtSoQuyen.Text));
                    cmd.Parameters.Add(p);
                     p = new SqlParameter("@ten", Convert.ToString(txtTenDauSach.Text));
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

                    SqlCommand cmd = new SqlCommand("dausach_sua", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mads", Convert.ToString(txtMaDauSach.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mans", Convert.ToString(cmbNhomSach.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngonngu", Convert.ToString(txtNgonNgu.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@tomtat", Convert.ToString(rtxtTomTat.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@trangthai", Convert.ToInt16(txtSoQuyen.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ten", Convert.ToString(txtTenDauSach.Text));
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
                SqlCommand cmd = new SqlCommand("dausach_xoa", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ma", Convert.ToString(txtMaDauSach.Text));
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
