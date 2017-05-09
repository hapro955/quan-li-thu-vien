namespace QuanLiThuVien
{
    partial class MENU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSáchChứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DauSach = new System.Windows.Forms.ToolStripMenuItem();
            this.DocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.TheDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.NhomSach = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuTra = new System.Windows.Forms.ToolStripMenuItem();
            this.DangKi = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần Mềm Quản Lí Thư Viện";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchChứcNăngToolStripMenuItem,
            this.thốngKếToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchChứcNăngToolStripMenuItem
            // 
            this.danhSáchChứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DauSach,
            this.DocGia,
            this.TheDocGia,
            this.NhomSach,
            this.PhieuMuon,
            this.PhieuTra,
            this.DangKi,
            this.CuonSach});
            this.danhSáchChứcNăngToolStripMenuItem.Name = "danhSáchChứcNăngToolStripMenuItem";
            this.danhSáchChứcNăngToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.danhSáchChứcNăngToolStripMenuItem.Text = "Danh sách chức năng";
            // 
            // DauSach
            // 
            this.DauSach.Name = "DauSach";
            this.DauSach.Size = new System.Drawing.Size(176, 22);
            this.DauSach.Text = "Đầu sách";
            this.DauSach.Click += new System.EventHandler(this.DauSach_Click);
            // 
            // DocGia
            // 
            this.DocGia.Name = "DocGia";
            this.DocGia.Size = new System.Drawing.Size(176, 22);
            this.DocGia.Text = "Độc giả";
            this.DocGia.Click += new System.EventHandler(this.DocGia_Click);
            // 
            // TheDocGia
            // 
            this.TheDocGia.Name = "TheDocGia";
            this.TheDocGia.Size = new System.Drawing.Size(176, 22);
            this.TheDocGia.Text = "Thẻ độc giả";
            this.TheDocGia.Click += new System.EventHandler(this.TheDocGia_Click);
            // 
            // NhomSach
            // 
            this.NhomSach.Name = "NhomSach";
            this.NhomSach.Size = new System.Drawing.Size(176, 22);
            this.NhomSach.Text = "Nhóm sách";
            this.NhomSach.Click += new System.EventHandler(this.NhomSach_Click);
            // 
            // PhieuMuon
            // 
            this.PhieuMuon.Name = "PhieuMuon";
            this.PhieuMuon.Size = new System.Drawing.Size(176, 22);
            this.PhieuMuon.Text = "Phiếu mượn";
            this.PhieuMuon.Click += new System.EventHandler(this.PhieuMuon_Click);
            // 
            // PhieuTra
            // 
            this.PhieuTra.Name = "PhieuTra";
            this.PhieuTra.Size = new System.Drawing.Size(176, 22);
            this.PhieuTra.Text = "Phiếu trả";
            this.PhieuTra.Click += new System.EventHandler(this.PhieuTra_Click);
            // 
            // DangKi
            // 
            this.DangKi.Name = "DangKi";
            this.DangKi.Size = new System.Drawing.Size(176, 22);
            this.DangKi.Text = "Đăng kí mượn sách";
            this.DangKi.Click += new System.EventHandler(this.DangKi_Click);
            // 
            // thốngKếToolStripMenuItem
            // 
            this.thốngKếToolStripMenuItem.Name = "thốngKếToolStripMenuItem";
            this.thốngKếToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKếToolStripMenuItem.Text = "Thống kế";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // CuonSach
            // 
            this.CuonSach.Name = "CuonSach";
            this.CuonSach.Size = new System.Drawing.Size(176, 22);
            this.CuonSach.Text = "Cuốn Sách";
            this.CuonSach.Click += new System.EventHandler(this.CuonSach_Click_1);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchChứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DauSach;
        private System.Windows.Forms.ToolStripMenuItem DocGia;
        private System.Windows.Forms.ToolStripMenuItem TheDocGia;
        private System.Windows.Forms.ToolStripMenuItem NhomSach;
        private System.Windows.Forms.ToolStripMenuItem PhieuMuon;
        private System.Windows.Forms.ToolStripMenuItem PhieuTra;
        private System.Windows.Forms.ToolStripMenuItem DangKi;
        private System.Windows.Forms.ToolStripMenuItem thốngKếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CuonSach;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}