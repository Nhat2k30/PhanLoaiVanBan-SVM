namespace ChuongTrinhPhanLoaiVanban
{
    partial class frmPhanLoai
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
            this.btnXuLy = new System.Windows.Forms.Button();
            this.btnPhanLoai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.Location = new System.Drawing.Point(0, 154);
            this.txtPhanLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanLoai.Multiline = true;
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhanLoai.Size = new System.Drawing.Size(430, 219);
            this.txtPhanLoai.TabIndex = 0;
            // 
            // btnXuLy
            // 
            this.btnXuLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.Location = new System.Drawing.Point(8, 23);
            this.btnXuLy.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(82, 50);
            this.btnXuLy.TabIndex = 1;
            this.btnXuLy.Text = "Xử Lí Văn Bản";
            this.toolTip1.SetToolTip(this.btnXuLy, "Xử Lí Văn Bản");
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // btnPhanLoai
            // 
            this.btnPhanLoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanLoai.Enabled = false;
            this.btnPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanLoai.Location = new System.Drawing.Point(98, 23);
            this.btnPhanLoai.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhanLoai.Name = "btnPhanLoai";
            this.btnPhanLoai.Size = new System.Drawing.Size(90, 50);
            this.btnPhanLoai.TabIndex = 1;
            this.btnPhanLoai.Text = "Phân Loại Văn Bản";
            this.toolTip1.SetToolTip(this.btnPhanLoai, "Phân Loại Văn Bản");
            this.btnPhanLoai.UseVisualStyleBackColor = true;
            this.btnPhanLoai.Click += new System.EventHandler(this.btnPhanLoai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phân Loại Văn Bản";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.toolTip1.SetToolTip(this.button1, "Thoát");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXuLy);
            this.groupBox1.Controls.Add(this.btnPhanLoai);
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(202, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // frmPhanLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(429, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhanLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhanLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanLoai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanLoai_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanLoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Button btnPhanLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}