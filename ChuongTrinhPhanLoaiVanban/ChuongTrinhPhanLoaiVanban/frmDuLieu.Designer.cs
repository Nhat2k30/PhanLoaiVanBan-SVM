namespace ChuongTrinhPhanLoaiVanban
{
    partial class frmDuLieu
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
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNapDuLieu = new System.Windows.Forms.Button();
            this.btnPhanTich = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtketQuaDuLieu = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(156, 7);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(191, 22);
            this.txtDuongDan.TabIndex = 1;
            this.txtDuongDan.TextChanged += new System.EventHandler(this.txtDuongDan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường Dẫn Dữ Liệu";
            // 
            // btnNapDuLieu
            // 
            this.btnNapDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNapDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapDuLieu.Location = new System.Drawing.Point(17, 23);
            this.btnNapDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnNapDuLieu.Name = "btnNapDuLieu";
            this.btnNapDuLieu.Size = new System.Drawing.Size(99, 50);
            this.btnNapDuLieu.TabIndex = 3;
            this.btnNapDuLieu.Text = "Nạp Dữ Liệu";
            this.toolTip1.SetToolTip(this.btnNapDuLieu, "Nạp Dữ Liệu");
            this.btnNapDuLieu.UseVisualStyleBackColor = true;
            this.btnNapDuLieu.Click += new System.EventHandler(this.btnNapDuLieu_Click);
            // 
            // btnPhanTich
            // 
            this.btnPhanTich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanTich.Enabled = false;
            this.btnPhanTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanTich.Location = new System.Drawing.Point(124, 23);
            this.btnPhanTich.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhanTich.Name = "btnPhanTich";
            this.btnPhanTich.Size = new System.Drawing.Size(94, 50);
            this.btnPhanTich.TabIndex = 3;
            this.btnPhanTich.Text = "Phân Tích";
            this.toolTip1.SetToolTip(this.btnPhanTich, "Phân Tích");
            this.btnPhanTich.UseVisualStyleBackColor = true;
            this.btnPhanTich.Click += new System.EventHandler(this.btnPhanTich_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(355, 7);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 64);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtketQuaDuLieu
            // 
            this.txtketQuaDuLieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtketQuaDuLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtketQuaDuLieu.Location = new System.Drawing.Point(0, 143);
            this.txtketQuaDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtketQuaDuLieu.Multiline = true;
            this.txtketQuaDuLieu.Name = "txtketQuaDuLieu";
            this.txtketQuaDuLieu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtketQuaDuLieu.Size = new System.Drawing.Size(473, 254);
            this.txtketQuaDuLieu.TabIndex = 6;
            this.txtketQuaDuLieu.TextChanged += new System.EventHandler(this.txtketQuaDuLieu_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNapDuLieu);
            this.groupBox1.Controls.Add(this.btnPhanTich);
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(226, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // frmDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(473, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtketQuaDuLieu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDuLieu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDuLieu_FormClosing);
            this.Load += new System.EventHandler(this.DuLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNapDuLieu;
        private System.Windows.Forms.Button btnPhanTich;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtketQuaDuLieu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}