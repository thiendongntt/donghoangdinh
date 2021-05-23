
namespace QuanLyCanTin
{
    partial class UserQuanLyDoanhThuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanLyDoanhThu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "user ql doanh thu";
            // 
            // dgvQuanLyDoanhThu
            // 
            this.dgvQuanLyDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvQuanLyDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyDoanhThu.Location = new System.Drawing.Point(32, 155);
            this.dgvQuanLyDoanhThu.Name = "dgvQuanLyDoanhThu";
            this.dgvQuanLyDoanhThu.Size = new System.Drawing.Size(583, 150);
            this.dgvQuanLyDoanhThu.TabIndex = 1;
            // 
            // UserQuanLyDoanhThuControl
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvQuanLyDoanhThu);
            this.Controls.Add(this.label1);
            this.Name = "UserQuanLyDoanhThuControl";
            this.Size = new System.Drawing.Size(646, 377);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanLyDoanhThu;
    }
}
