namespace ChuongTrinhPhanLoaiVanban
{
    partial class frmTuDien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNap = new System.Windows.Forms.Button();
            this.cboNapTuDien = new System.Windows.Forms.ComboBox();
            this.lstHienThi = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnNap);
            this.groupBox2.Controls.Add(this.cboNapTuDien);
            this.groupBox2.Location = new System.Drawing.Point(200, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(214, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Từ Điển";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(127, 55);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 50);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNap
            // 
            this.btnNap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNap.Location = new System.Drawing.Point(28, 55);
            this.btnNap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(82, 50);
            this.btnNap.TabIndex = 3;
            this.btnNap.Text = "Nạp Từ Điển";
            this.toolTip1.SetToolTip(this.btnNap, "Nạp Từ Điển");
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // cboNapTuDien
            // 
            this.cboNapTuDien.FormattingEnabled = true;
            this.cboNapTuDien.Location = new System.Drawing.Point(28, 23);
            this.cboNapTuDien.Margin = new System.Windows.Forms.Padding(4);
            this.cboNapTuDien.Name = "cboNapTuDien";
            this.cboNapTuDien.Size = new System.Drawing.Size(171, 24);
            this.cboNapTuDien.TabIndex = 2;
            this.cboNapTuDien.SelectedIndexChanged += new System.EventHandler(this.cboNapTuDien_SelectedIndexChanged);
            // 
            // lstHienThi
            // 
            this.lstHienThi.FormattingEnabled = true;
            this.lstHienThi.ItemHeight = 16;
            this.lstHienThi.Location = new System.Drawing.Point(16, 15);
            this.lstHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.lstHienThi.Name = "lstHienThi";
            this.lstHienThi.Size = new System.Drawing.Size(175, 260);
            this.lstHienThi.TabIndex = 3;
            // 
            // frmTuDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(437, 289);
            this.Controls.Add(this.lstHienThi);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTuDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTuDien";
            this.Load += new System.EventHandler(this.frmTuDien_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNap;
        private System.Windows.Forms.ComboBox cboNapTuDien;
        private System.Windows.Forms.ListBox lstHienThi;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}