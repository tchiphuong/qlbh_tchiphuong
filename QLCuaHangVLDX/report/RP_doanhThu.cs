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
    public partial class RP_doanhThu : Form
    {
        public RP_doanhThu()
        {
            InitializeComponent();
        }

        private void RP_doanhThu_Load(object sender, EventArgs e)
        {
            
        }
        private void loadReport()
        {
            //int thangDau = Convert.ToInt32(cboMMf.Text);
            //int namDau = Convert.ToInt32(cboyyyyf.Text);
            //DataSetDoanhThu.USP_doanhThu.Clear();
            //DataSetDoanhThu.EnforceConstraints = false;
            //USP_doanhThuTableAdapter.Fill(this.DataSetDoanhThu.USP_doanhThu, thangDau, namDau);

            dataSetDoanhThu.USP_doanhThuBanHang.Clear();
            dataSetDoanhThu.EnforceConstraints = false;
            uSP_doanhThuBanHangTableAdapter.Fill(this.dataSetDoanhThu.USP_doanhThuBanHang, dateFrom.Value, dateTo.Value);

            this.uSP_nhanVienTableAdapter.Fill(this.dataSetgetNguoiDung.USP_nhanVien, F_dangNhap.tenDangNhap);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadReport();
        }

        private void cboMMf_SelectedValueChanged(object sender, EventArgs e)
        {
            loadReport();
        }

        private void cboyyyyf_SelectedValueChanged(object sender, EventArgs e)
        {
            loadReport();
        }
    }
}
