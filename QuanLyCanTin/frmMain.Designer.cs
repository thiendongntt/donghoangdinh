
namespace QuanLyCanTin
{
    partial class frmMain
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnGiaoHang = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(148, 123);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(110, 56);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(333, 123);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(110, 56);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Quản lý bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnGiaoHang
            // 
            this.btnGiaoHang.Location = new System.Drawing.Point(527, 123);
            this.btnGiaoHang.Name = "btnGiaoHang";
            this.btnGiaoHang.Size = new System.Drawing.Size(110, 56);
            this.btnGiaoHang.TabIndex = 2;
            this.btnGiaoHang.Text = "Quản lý giao hàng";
            this.btnGiaoHang.UseVisualStyleBackColor = true;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(148, 244);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(110, 56);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Quản lý doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Location = new System.Drawing.Point(333, 244);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(110, 56);
            this.btnNguoiDung.TabIndex = 4;
            this.btnNguoiDung.Text = "Quản lý người dùng";
            this.btnNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Location = new System.Drawing.Point(527, 244);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(110, 56);
            this.btnKhoHang.TabIndex = 5;
            this.btnKhoHang.Text = "Quản lý kho hàng";
            this.btnKhoHang.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKhoHang);
            this.Controls.Add(this.btnNguoiDung);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.btnGiaoHang);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnNhanVien);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnGiaoHang;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnNguoiDung;
        private System.Windows.Forms.Button btnKhoHang;
    }
}