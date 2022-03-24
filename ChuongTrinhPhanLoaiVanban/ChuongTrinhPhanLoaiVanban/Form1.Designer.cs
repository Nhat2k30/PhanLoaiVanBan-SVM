namespace ChuongTrinhPhanLoaiVanban
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtPhanLoai = new System.Windows.Forms.TextBox();
            this.btnChuDe = new System.Windows.Forms.Button();
            this.btnPhanloai = new System.Windows.Forms.Button();
            this.btnDuLieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTuDien = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhanLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPhanLoai.Location = new System.Drawing.Point(0, 199);
            this.txtPhanLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanLoai.Multiline = true;
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhanLoai.Size = new System.Drawing.Size(630, 276);
            this.txtPhanLoai.TabIndex = 0;
            this.txtPhanLoai.TextChanged += new System.EventHandler(this.txtPhanLoai_TextChanged);
            // 
            // btnChuDe
            // 
            this.btnChuDe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuDe.Location = new System.Drawing.Point(16, 121);
            this.btnChuDe.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuDe.Name = "btnChuDe";
            this.btnChuDe.Size = new System.Drawing.Size(91, 62);
            this.btnChuDe.TabIndex = 1;
            this.btnChuDe.Text = "Danh Mục";
            this.toolTip1.SetToolTip(this.btnChuDe, "Danh Mục");
            this.btnChuDe.UseVisualStyleBackColor = false;
            this.btnChuDe.Click += new System.EventHandler(this.btnChuDe_Click);
            // 
            // btnPhanloai
            // 
            this.btnPhanloai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanloai.Enabled = false;
            this.btnPhanloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanloai.Location = new System.Drawing.Point(377, 121);
            this.btnPhanloai.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhanloai.Name = "btnPhanloai";
            this.btnPhanloai.Size = new System.Drawing.Size(135, 62);
            this.btnPhanloai.TabIndex = 1;
            this.btnPhanloai.Text = "Phân Loại Văn Bản";
            this.toolTip1.SetToolTip(this.btnPhanloai, "Phân Loại Văn Bản");
            this.btnPhanloai.UseVisualStyleBackColor = true;
            this.btnPhanloai.Click += new System.EventHandler(this.btnPhanloai_Click);
            // 
            // btnDuLieu
            // 
            this.btnDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuLieu.Enabled = false;
            this.btnDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuLieu.Location = new System.Drawing.Point(267, 121);
            this.btnDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuLieu.Name = "btnDuLieu";
            this.btnDuLieu.Size = new System.Drawing.Size(91, 62);
            this.btnDuLieu.TabIndex = 1;
            this.btnDuLieu.Text = "Dữ Liệu";
            this.toolTip1.SetToolTip(this.btnDuLieu, "Nạp Dữ Liệu Vào Hệ Thống");
            this.btnDuLieu.UseVisualStyleBackColor = true;
            this.btnDuLieu.Click += new System.EventHandler(this.btnDuLieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(529, 121);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 62);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chương Trình Phân Loại Văn Bản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tblTuDien
            // 
            this.tblTuDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblTuDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTuDien.Location = new System.Drawing.Point(143, 121);
            this.tblTuDien.Margin = new System.Windows.Forms.Padding(4);
            this.tblTuDien.Name = "tblTuDien";
            this.tblTuDien.Size = new System.Drawing.Size(91, 62);
            this.tblTuDien.TabIndex = 3;
            this.tblTuDien.Text = "Từ Điển";
            this.toolTip1.SetToolTip(this.tblTuDien, "Nạp Từ Điển");
            this.tblTuDien.UseVisualStyleBackColor = true;
            this.tblTuDien.Click += new System.EventHandler(this.tblTuDien_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "(Sử Dụng Thuật Toán SVM)";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(630, 475);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tblTuDien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDuLieu);
            this.Controls.Add(this.btnPhanloai);
            this.Controls.Add(this.btnChuDe);
            this.Controls.Add(this.txtPhanLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình PLVB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.Button btnChuDe;
        private System.Windows.Forms.Button btnPhanloai;
        private System.Windows.Forms.Button btnDuLieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tblTuDien;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
    }
}

