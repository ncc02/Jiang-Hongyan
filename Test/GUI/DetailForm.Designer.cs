namespace _102200013_NguyenCongCuong.GUI
{
    partial class JiangHongyan_DF
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboTenNguyenLieu = new System.Windows.Forms.ComboBox();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(200, 92);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(212, 22);
            this.txtSoLuong.TabIndex = 0;
            // 
            // cboTenNguyenLieu
            // 
            this.cboTenNguyenLieu.FormattingEnabled = true;
            this.cboTenNguyenLieu.Location = new System.Drawing.Point(200, 38);
            this.cboTenNguyenLieu.Name = "cboTenNguyenLieu";
            this.cboTenNguyenLieu.Size = new System.Drawing.Size(212, 24);
            this.cboTenNguyenLieu.TabIndex = 1;
            this.cboTenNguyenLieu.SelectedIndexChanged += new System.EventHandler(this.cboTenNguyenLieu_SelectedIndexChanged);
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(200, 148);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(212, 24);
            this.cboDonViTinh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tình trạng";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(99, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(200, 200);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(212, 24);
            this.cboTinhTrang.TabIndex = 1;
            // 
            // JiangHongyan_DF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.cboDonViTinh);
            this.Controls.Add(this.cboTenNguyenLieu);
            this.Controls.Add(this.txtSoLuong);
            this.Name = "JiangHongyan_DF";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboTenNguyenLieu;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboTinhTrang;
    }
}