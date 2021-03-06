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
    public partial class F_congNo : Form
    {
        public F_congNo()
        {
            InitializeComponent();
        }

        private void F_congNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCongNo.View_congNo' table. You can move, or remove it, as needed.
            //this.View_congNoTableAdapter.Fill(this.DataSetCongNo.View_congNo);
            DataSetCongNo.View_congNo.Clear();
            DataSetCongNo.EnforceConstraints = false;
            View_congNoTableAdapter.Fill(DataSetCongNo.View_congNo);
            // TODO: This line of code loads data into the 'DataSetgetNguoiDung.USP_nhanVien' table. You can move, or remove it, as needed.
            this.USP_nhanVienTableAdapter.Fill(this.DataSetgetNguoiDung.USP_nhanVien,F_dangNhap.tenDangNhap);

            this.reportViewer1.RefreshReport();
        }
    }
}
