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
    public partial class F_nhapHang : Form
    {
        public F_nhapHang()
        {
            InitializeComponent();
        }

        private void loadReport()
        {
            // TODO: This line of code loads data into the 'DataSetNhapHang.USP_nhapHang' table. You can move, or remove it, as needed.
            //this.USP_nhapHangTableAdapter.Fill(this.DataSetNhapHang.USP_nhapHang,dateFrom.Value,dateTo.Value);
            DataSetNhapHang.USP_nhapHang.Clear();
            DataSetNhapHang.EnforceConstraints = false;
            USP_nhapHangTableAdapter.Fill(DataSetNhapHang.USP_nhapHang, dateFrom.Value, dateTo.Value);
            // TODO: This line of code loads data into the 'DataSetgetNguoiDung.USP_nhanVien' table. You can move, or remove it, as needed.
            this.USP_nhanVienTableAdapter.Fill(this.DataSetgetNguoiDung.USP_nhanVien,F_dangNhap.tenDangNhap);

            this.reportViewer1.RefreshReport();
        }

        private void F_nhapHang_Load(object sender, EventArgs e)
        {
            loadReport();
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
