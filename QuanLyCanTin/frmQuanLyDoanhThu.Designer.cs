
namespace QuanLyCanTin
{
    partial class frmQuanLyDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnXuatNhapKho = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userQuanLyXuatNhapKhoControl = new QuanLyCanTin.UserQuanLyXuatNhapKhoControl();
            this.userQuanLyDoanhThuControl = new QuanLyCanTin.UserQuanLyDoanhThuControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXuatNhapKho);
            this.panel1.Controls.Add(this.btnDoanhThu);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 377);
            this.panel1.TabIndex = 0;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(13, 128);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(105, 42);
            this.btnDoanhThu.TabIndex = 0;
            this.btnDoanhThu.Text = "Quản lý doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnXuatNhapKho
            // 
            this.btnXuatNhapKho.Location = new System.Drawing.Point(13, 201);
            this.btnXuatNhapKho.Name = "btnXuatNhapKho";
            this.btnXuatNhapKho.Size = new System.Drawing.Size(105, 39);
            this.btnXuatNhapKho.TabIndex = 1;
            this.btnXuatNhapKho.Text = "Quản lý xuất nhập kho";
            this.btnXuatNhapKho.UseVisualStyleBackColor = true;
            this.btnXuatNhapKho.Click += new System.EventHandler(this.btnXuatNhapKho_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userQuanLyXuatNhapKhoControl);
            this.panel2.Controls.Add(this.userQuanLyDoanhThuControl);
            this.panel2.Location = new System.Drawing.Point(150, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 377);
            this.panel2.TabIndex = 1;
            // 
            // userQuanLyXuatNhapKhoControl
            // 
            this.userQuanLyXuatNhapKhoControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.userQuanLyXuatNhapKhoControl.AllowDrop = true;
            this.userQuanLyXuatNhapKhoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userQuanLyXuatNhapKhoControl.Location = new System.Drawing.Point(0, 0);
            this.userQuanLyXuatNhapKhoControl.Name = "userQuanLyXuatNhapKhoControl";
            this.userQuanLyXuatNhapKhoControl.Size = new System.Drawing.Size(638, 377);
            this.userQuanLyXuatNhapKhoControl.TabIndex = 1;
            // 
            // userQuanLyDoanhThuControl
            // 
            this.userQuanLyDoanhThuControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.userQuanLyDoanhThuControl.AllowDrop = true;
            this.userQuanLyDoanhThuControl.Location = new System.Drawing.Point(0, 0);
            this.userQuanLyDoanhThuControl.Name = "userQuanLyDoanhThuControl";
            this.userQuanLyDoanhThuControl.Size = new System.Drawing.Size(646, 377);
            this.userQuanLyDoanhThuControl.TabIndex = 0;
            // 
            // frmQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyDoanhThu";
            this.Text = "frmQuanLyDoanhThu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXuatNhapKho;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private UserQuanLyDoanhThuControl userQuanLyDoanhThuControl;
        private UserQuanLyXuatNhapKhoControl userQuanLyXuatNhapKhoControl;
    }
}