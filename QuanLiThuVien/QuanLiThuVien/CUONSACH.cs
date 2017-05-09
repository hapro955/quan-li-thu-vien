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
    public partial class CUONSACH : Form
    {
        ConnectDB conn = new ConnectDB();
        bool themmoi;
        public CUONSACH()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KhoaDieuKhien()
        {
            txtMaCuonSach.Enabled = false;
            txtTinhTrang.Enabled = false;
            cmbMaDauSach.Enabled = false;
            cmbMaPhieuMuon.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
        }
        void MoDieuKhien()
        {
            txtMaCuonSach.Enabled = true;
            txtTinhTrang.Enabled = true;
            cmbMaDauSach.Enabled = true;
            cmbMaPhieuMuon.Enabled = true;


            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }
        void setNull()
        {
            txtTinhTrang.Text = "Tình trạng";
            txtMaCuonSach.Text = "Mã cuốn sách";
            cmbMaDauSach.Text = "Đầu sách";
            cmbMaPhieuMuon.Text = "Mã phiếu mượn";
        }
        private void LoadData()
        {
            string sql = "select * from cuonsach";
            dgvCuonSach.DataSource = conn.GetDataTable(sql);
        }
        private void show_ComboPhieuMuon()
        {
            string sql = "select * from phieumuon";
            cmbMaPhieuMuon.DataSource = conn.GetDataTable(sql);
            cmbMaPhieuMuon.ValueMember = "ma_phieumuon";
            cmbMaPhieuMuon.DisplayMember = "ma_phieumuon";

        }
        private void show_ComboDauSach()
        {
            string sql = "select * from dausach";
            cmbMaDauSach.DataSource = conn.GetDataTable(sql);
            cmbMaDauSach.ValueMember = "ma_dausach";
            cmbMaDauSach.DisplayMember = "tendausach";

        }

        private void CUONSACH_Load(object sender, EventArgs e)
        {
            LoadData();
            show_ComboDauSach();
            show_ComboPhieuMuon();
            KhoaDieuKhien();
            setNull();
        }

        private void dgvCuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaCuonSach.Text = Convert.ToString(dgvCuonSach.CurrentRow.Cells[1].Value);
                    cmbMaDauSach.Text = Convert.ToString(dgvCuonSach.CurrentRow.Cells[2].Value);
                    cmbMaPhieuMuon.Text = Convert.ToString(dgvCuonSach.CurrentRow.Cells[3].Value);
                    txtTinhTrang.Text = Convert.ToString(dgvCuonSach.CurrentRow.Cells[4].Value);  
                }
            }
            catch
            {
                MessageBox.Show("lỗi không tải dữ liệu lên được!");
            }
        }

        private void dgvCuonSach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvCuonSach.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            txtMaCuonSach.Enabled = false;
            txtTinhTrang.Text = "";
            txtMaCuonSach.Text = "";
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            txtMaCuonSach.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                conn.OpenDB();
                int count = 0;
                try
                {

                    SqlCommand cmd = new SqlCommand("cuonsach_them", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@macs", Convert.ToString(txtMaCuonSach.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mapm", Convert.ToString(cmbMaPhieuMuon.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mads", Convert.ToString(cmbMaDauSach.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@tt", Convert.ToString(txtTinhTrang.Text));
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

                    SqlCommand cmd = new SqlCommand("cuonsach_sua", ConnectDB.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@macs", Convert.ToString(txtMaCuonSach.Text));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mapm", Convert.ToString(cmbMaPhieuMuon.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@mads", Convert.ToString(cmbMaDauSach.SelectedValue));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@tt", Convert.ToString(txtTinhTrang.Text));
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
                SqlCommand cmd = new SqlCommand("cuonsach_xoa", ConnectDB.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@macs", Convert.ToString(txtMaCuonSach.Text));
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
