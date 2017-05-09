using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

       

        private void DauSach_Click(object sender, EventArgs e)
        {
            DAUSACH ds = new DAUSACH();
            ds.Show();
        }

        private void DocGia_Click(object sender, EventArgs e)
        {
            DOCGIA dg = new DOCGIA();
            dg.Show();
        }

        private void TheDocGia_Click(object sender, EventArgs e)
        {
            THEDOCGIA tdg = new THEDOCGIA();
            tdg.Show();
        }

        private void NhomSach_Click(object sender, EventArgs e)
        {
            NHOMSACH ns = new NHOMSACH();
            ns.Show();
        }

        private void PhieuMuon_Click(object sender, EventArgs e)
        {
            PHIEUMUON pm = new PHIEUMUON();
            pm.Show();
        }

        private void PhieuTra_Click(object sender, EventArgs e)
        {
            PHIEUTRA pt = new PHIEUTRA();
            pt.Show();
        }

        private void DangKi_Click(object sender, EventArgs e)
        {
            DANGKI dk = new DANGKI();
            dk.Show();
        }

        private void CuonSach_Click_1(object sender, EventArgs e)
        {
            CUONSACH cs = new CUONSACH();
            cs.Show();
        }
    }
}
