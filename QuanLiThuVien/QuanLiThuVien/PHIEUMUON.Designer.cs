namespace QuanLiThuVien
{
    partial class PHIEUMUON
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvPhieumuon = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.txtMaphieumuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_nhomsach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhomsach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Ngày trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Ngày mượn:";
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Location = new System.Drawing.Point(200, 134);
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(167, 20);
            this.txtMadocgia.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 31);
            this.label4.TabIndex = 57;
            this.label4.Text = "Phiếu Mượn";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(486, 205);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 56;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(405, 205);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvPhieumuon
            // 
            this.dgvPhieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ma_nhomsach,
            this.tennhomsach,
            this.Column2,
            this.Column3});
            this.dgvPhieumuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieumuon.Location = new System.Drawing.Point(0, 234);
            this.dgvPhieumuon.Name = "dgvPhieumuon";
            this.dgvPhieumuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieumuon.Size = new System.Drawing.Size(791, 199);
            this.dgvPhieumuon.TabIndex = 54;
            this.dgvPhieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieumuon_CellClick);
            this.dgvPhieumuon.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPhieumuon_RowPrePaint);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(567, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(324, 205);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(243, 205);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(162, 205);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 50;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // txtMaphieumuon
            // 
            this.txtMaphieumuon.Location = new System.Drawing.Point(200, 108);
            this.txtMaphieumuon.Name = "txtMaphieumuon";
            this.txtMaphieumuon.Size = new System.Drawing.Size(167, 20);
            this.txtMaphieumuon.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // dtpNgaymuon
            // 
            this.dtpNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaymuon.Location = new System.Drawing.Point(486, 108);
            this.dtpNgaymuon.Name = "dtpNgaymuon";
            this.dtpNgaymuon.Size = new System.Drawing.Size(138, 20);
            this.dtpNgaymuon.TabIndex = 61;
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytra.Location = new System.Drawing.Point(486, 134);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.Size = new System.Drawing.Size(138, 20);
            this.dtpNgaytra.TabIndex = 62;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // ma_nhomsach
            // 
            this.ma_nhomsach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ma_nhomsach.DataPropertyName = "ma_phieumuon";
            this.ma_nhomsach.HeaderText = "Mã phiếu mượn";
            this.ma_nhomsach.Name = "ma_nhomsach";
            // 
            // tennhomsach
            // 
            this.tennhomsach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennhomsach.DataPropertyName = "ma_docgia";
            this.tennhomsach.HeaderText = "Mã độc giả";
            this.tennhomsach.Name = "tennhomsach";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ngaymuon";
            this.Column2.HeaderText = "Ngày mượn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ngaytra";
            this.Column3.HeaderText = "Ngày trả";
            this.Column3.Name = "Column3";
            // 
            // PHIEUMUON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.dtpNgaytra);
            this.Controls.Add(this.dtpNgaymuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMadocgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvPhieumuon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.txtMaphieumuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PHIEUMUON";
            this.Text = "PHIEUMUON";
            this.Load += new System.EventHandler(this.PHIEUMUON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvPhieumuon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.TextBox txtMaphieumuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaymuon;
        private System.Windows.Forms.DateTimePicker dtpNgaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nhomsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhomsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}