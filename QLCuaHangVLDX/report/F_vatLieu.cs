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
    public partial class F_vatLieu : Form
    {
        public F_vatLieu()
        {
            InitializeComponent();
        }

        private void F_vatLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetVatLieu.vatLieu' table. You can move, or remove it, as needed.
            this.vatLieuTableAdapter.Fill(this.DataSetVatLieu.vatLieu);
            // TODO: This line of code loads data into the 'DataSetgetNguoiDung.USP_nhanVien' table. You can move, or remove it, as needed.
            this.USP_nhanVienTableAdapter.Fill(this.DataSetgetNguoiDung.USP_nhanVien, F_dangNhap.tenDangNhap);

            this.reportViewer1.RefreshReport();
        }
    }
}
