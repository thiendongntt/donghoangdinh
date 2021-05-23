using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyCanTin
{
    public partial class UserQuanLyDoanhThuControl : UserControl
    {
        public UserQuanLyDoanhThuControl()
        {
            InitializeComponent();
            dgvQuanLyDoanhThu.DataSource = ThongKeBUS.Instance.getAll();
        }
    }
}
