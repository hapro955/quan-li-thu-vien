namespace QuanLiThuVien
{
    partial class THEDOCGIA
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
            this.dtpNgayhethan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaylamthe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvThedocgia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_nhomsach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhomsach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.txtMathedocgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThedocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayhethan
            // 
            this.dtpNgayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayhethan.Location = new System.Drawing.Point(503, 143);
            this.dtpNgayhethan.Name = "dtpNgayhethan";
            this.dtpNgayhethan.Size = new System.Drawing.Size(138, 20);
            this.dtpNgayhethan.TabIndex = 78;
            // 
            // dtpNgaylamthe
            // 
            this.dtpNgaylamthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylamthe.Location = new System.Drawing.Point(503, 115);
            this.dtpNgaylamthe.Name = "dtpNgaylamthe";
            this.dtpNgaylamthe.Size = new System.Drawing.Size(138, 20);
            this.dtpNgaylamthe.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Ngày làm thẻ:";
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Location = new System.Drawing.Point(217, 141);
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(167, 20);
            this.txtMadocgia.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 73;
            this.label4.Text = "Thẻ Độc Giả";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(477, 214);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 72;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(396, 214);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 71;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvThedocgia
            // 
            this.dgvThedocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThedocgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ma_nhomsach,
            this.tennhomsach,
            this.Column2,
            this.Column3});
            this.dgvThedocgia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThedocgia.Location = new System.Drawing.Point(0, 254);
            this.dgvThedocgia.Name = "dgvThedocgia";
            this.dgvThedocgia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThedocgia.Size = new System.Drawing.Size(794, 199);
            this.dgvThedocgia.TabIndex = 70;
            this.dgvThedocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieumuon_CellClick);
            this.dgvThedocgia.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPhieumuon_RowPrePaint);
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
            this.ma_nhomsach.DataPropertyName = "ma_thedocgia";
            this.ma_nhomsach.HeaderText = "Mã thẻ độc giả";
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
            this.Column2.DataPropertyName = "ngaylamthe";
            this.Column2.HeaderText = "Ngày làm thẻ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ngayhethan";
            this.Column3.HeaderText = "Ngày hết hạn";
            this.Column3.Name = "Column3";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(558, 214);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 69;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(315, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 68;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(234, 214);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 67;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(153, 214);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 66;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // txtMathedocgia
            // 
            this.txtMathedocgia.Location = new System.Drawing.Point(217, 115);
            this.txtMathedocgia.Name = "txtMathedocgia";
            this.txtMathedocgia.Size = new System.Drawing.Size(167, 20);
            this.txtMathedocgia.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã thẻ độc giả:";
            // 
            // THEDOCGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 453);
            this.Controls.Add(this.dtpNgayhethan);
            this.Controls.Add(this.dtpNgaylamthe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMadocgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvThedocgia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.txtMathedocgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "THEDOCGIA";
            this.Text = "THEDOCGIA";
            this.Load += new System.EventHandler(this.THEDOCGIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThedocgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayhethan;
        private System.Windows.Forms.DateTimePicker dtpNgaylamthe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvThedocgia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.TextBox txtMathedocgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nhomsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhomsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}