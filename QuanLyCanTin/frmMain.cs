using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCanTin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDoanhThu frmQuanLyDoanhThu = new frmQuanLyDoanhThu();
            frmQuanLyDoanhThu.ShowDialog();
            this.Close();
        }
    }
}
