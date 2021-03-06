using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangVLDX.form;

namespace QLCuaHangVLDX.report
{
    public partial class F_xuatHang : Form
    {
        public F_xuatHang()
        {
            InitializeComponent();
        }

        private void F_xuatHang_Load(object sender, EventArgs e)
        {

        }
        private void loadReport()
        {
            DataSetXuatHang.USP_xuatHang.Clear();
            DataSetXuatHang.EnforceConstraints = false;
            USP_xuatHangTableAdapter.Fill(DataSetXuatHang.USP_xuatHang, dateFrom.Value, dateTo.Value);
            this.USP_nhanVienTableAdapter.Fill(this.DataSetgetNguoiDung.USP_nhanVien, F_dangNhap.tenDangNhap);
            this.reportViewer1.RefreshReport();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            loadReport();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            loadReport();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            loadReport();
        }
    }
}
