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
    public partial class DANGKI : Form
    {
        ConnectDB conn = new ConnectDB();
        bool themmoi;
        public DANGKI()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KhoaDieuKhien()
        {
            cmbDauSach.Enabled = false;
            cmbDocGia.Enabled = false;
            dtpNgayDangKi.Enabled = false;
            rtxtGhiChu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }
        void MoDieuKhien()
        {
            cmbDauSach.Enabled = true;
            cmbDocGia.Enabled = true;
            dtpNgayDangKi.Enabled = true;
            rtxtGhiChu.Enabled = true;


            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }
        void setNull()
        {
            cmbDauSach.Text = "Đầu sách";
            cmbDocGia.Text = "Mã độc giả";
            rtxtGhiChu.Text = "Ghi chú";
        }
        private void LoadData()
        {
            string sql = "select a.ma_docgia, b.hoten, a.ma_dausach,c.tendausach,a.ngaydangki,a.ghichu from dangki a inner join docgia b on a.ma_docgia=b.ma_docgia inner join dausach c on a.ma_dausach= c.ma_dausach  ";
            
            dgvDangKi.DataSource = conn.GetDataTable(sql);
        }
        private void show_ComboDauSach()
        {
            string sql = "select * from dausach";
            cmbDauSach.DataSource = conn.GetDataTable(sql);
            cmbDauSach.ValueMember = "ma_dausach";
            cmbDauSach.DisplayMember = "tendausach";

        }
        private void show_ComboDocGia()
        {
            string sql = "select * from docgia";
            cmbDocGia.DataSource = conn.GetDataTable(sql);
            cmbDocGia.ValueMember = "ma_docgia";
            cmbDocGia.DisplayMember = "ma_docgia";
        }
        private void DANGKI_Load(object sender, EventArgs e)
        {
            show_ComboDauSach();
            show_ComboDocGia();
            LoadData();
            KhoaDieuKhien();
            setNull();
        }

        private void dgvDangKi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cmbDocGia.Text = Convert.ToString(dgvDangKi.CurrentRow.Cells[1].Value);
                    cmbDauSach.Text = Convert.ToString(dgvDangKi.CurrentRow.Cells[3].Value);
                    dtpNgayDangKi.Text = Convert.ToString(dgvDangKi.CurrentRow.Cells[5].Value);
                    rtxtGhiChu.Text = Convert.ToString(dgvDangKi.CurrentRow.Cells[6].Value);
                  
                }
            }
            catch
            {
                MessageBox.Show("lỗi không tải dữ liệu lên được!");
            }
        }

        private void dgvDangKi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDangKi.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            cmbDauSach.Text = "";
            cmbDocGia.Text = "";
            rtxtGhiChu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            cmbDauSach.Enabled = false;
            cmbDocGia.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                conn.OpenDB();
                int count = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("dangki_them", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mads", Convert.ToString(cmbDauSach.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@madg", Convert.ToString(cmbDocGia.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaydangki", Convert.ToString(dtpNgayDangKi.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ghichu", Convert.ToString(rtxtGhiChu.Text));
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

                    SqlCommand cmd = new SqlCommand("dangki_sua", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@mads", Convert.ToString(cmbDauSach.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@madg", Convert.ToString(cmbDocGia.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ngaydangki", Convert.ToString(dtpNgayDangKi.Value));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@ghichu", Convert.ToString(rtxtGhiChu.Text));
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
                SqlCommand cmd = new SqlCommand("dangki_xoa", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@mads", Convert.ToString(cmbDauSach.SelectedValue));
                cmd.Parameters.Add(p);
                p = new SqlParameter("@madg", Convert.ToString(cmbDocGia.SelectedValue));
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
