namespace _102200013_NguyenCongCuong.GUI
{
    partial class JiangHongyan_MF
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
            this.cboMonAn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSreach = new System.Windows.Forms.TextBox();
            this.dgvQLSP = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAđd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cboSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Món ăn";
            // 
            // cboMonAn
            // 
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.Location = new System.Drawing.Point(138, 39);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(121, 24);
            this.cboMonAn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sreach";
            // 
            // txtSreach
            // 
            this.txtSreach.Location = new System.Drawing.Point(650, 41);
            this.txtSreach.Name = "txtSreach";
            this.txtSreach.Size = new System.Drawing.Size(100, 22);
            this.txtSreach.TabIndex = 3;
            this.txtSreach.TextChanged += new System.EventHandler(this.textBox_Sreach_TextChanged);
            // 
            // dgvQLSP
            // 
            this.dgvQLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.STT,
            this.TenNguyenLieu,
            this.SoLuong,
            this.DonViTinh,
            this.TinhTrang});
            this.dgvQLSP.Location = new System.Drawing.Point(55, 151);
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.RowHeadersWidth = 51;
            this.dgvQLSP.RowTemplate.Height = 24;
            this.dgvQLSP.Size = new System.Drawing.Size(695, 203);
            this.dgvQLSP.TabIndex = 4;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Visible = false;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 80;
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            this.TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.TenNguyenLieu.MinimumWidth = 6;
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quản lý sản phẩm";
            // 
            // btnAđd
            // 
            this.btnAđd.Location = new System.Drawing.Point(55, 401);
            this.btnAđd.Name = "btnAđd";
            this.btnAđd.Size = new System.Drawing.Size(75, 23);
            this.btnAđd.TabIndex = 6;
            this.btnAđd.Text = "Add";
            this.btnAđd.UseVisualStyleBackColor = true;
            this.btnAđd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(184, 401);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(322, 401);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(503, 401);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Location = new System.Drawing.Point(629, 401);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(121, 24);
            this.cboSort.TabIndex = 7;
            // 
            // JiangHongyan_MF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAđd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvQLSP);
            this.Controls.Add(this.txtSreach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMonAn);
            this.Controls.Add(this.label1);
            this.Name = "JiangHongyan_MF";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSreach;
        private System.Windows.Forms.DataGridView dgvQLSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAđd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
    }
}

