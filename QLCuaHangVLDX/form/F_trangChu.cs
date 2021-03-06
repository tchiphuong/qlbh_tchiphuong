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
using System.Data.SqlClient;

namespace QLCuaHangVLDX.form
{
    public partial class F_trangChu : Form
    {
        public F_trangChu()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        private void F_trangChu_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT quyenHan FROM dbo.nguoiDung WHERE tenDangNhap =N'" + F_dangNhap.tenDangNhap + "'";
            SqlCommand cm = new SqlCommand(sql, conn);
            string chucVu = (string)cm.ExecuteScalar();
            conn.Close();
            if (chucVu == "Nhân viên bán hàng")
            {
                uC_hoaDon1.BringToFront();
                btnCongNo.Enabled = true;
                btnHoaDon.Enabled = true;
            }
            else if (chucVu == "Quản lý bán hàng")
            {
                uC_vatLieu1.BringToFront();
                btnCongNo.Enabled = true;
                btnHoaDon.Enabled = true;
                btnCapNhatGia.Enabled = true;
                btnDoahThu.Enabled = true;
                btnQuanLyKho.Enabled = true;
                btnNhapKho.Enabled = true;
                btnRnhapkho.Enabled = true;
                btnRxuatkho.Enabled = true;
            }
            else if (chucVu == "Quản lý kho")
            {
                uC_vatLieu1.BringToFront();
                btnQuanLyKho.Enabled = true;
                btnNhapKho.Enabled = true;
                btnRnhapkho.Enabled = true;
                btnRxuatkho.Enabled = true;
            }
            else if (chucVu == "Quản trị viên")
            {
                uC_nguoiDung1.BringToFront();
                btnTaiKhoan.Enabled = true;
                btnCongNo.Enabled = true;
                btnHoaDon.Enabled = true;
                btnCapNhatGia.Enabled = true;
                btnDoahThu.Enabled = true;
                btnQuanLyKho.Enabled = true;
                btnNhapKho.Enabled = true;
                btnRnhapkho.Enabled = true;
                btnRxuatkho.Enabled = true;
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            uC_nguoiDung1.BringToFront();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            uC_hoaDon1.BringToFront();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            uC_vatLieu1.BringToFront();
        }

        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {
            uC_capNhatGia1.BringToFront();
        }

        private void btnThongTinDN_Click(object sender, EventArgs e)
        {
            F_thongTinTK f = new F_thongTinTK();
            f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_dangNhap f = new F_dangNhap();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void F_trangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCongNo_Click(object sender, EventArgs e)
        {
            uC_congNo1.BringToFront();
        }

        private void btnDoahThu_Click(object sender, EventArgs e)
        {
            report.RP_doanhThu f = new report.RP_doanhThu();
            f.ShowDialog();
        }

        private void btnCapNhatTK_Click(object sender, EventArgs e)
        {
            F_capNhatTK f = new F_capNhatTK();
            f.ShowDialog();
        }

        private void btnNhapKho_Click_1(object sender, EventArgs e)
        {
            F_nhapKho f = new F_nhapKho();
            f.ShowDialog();
        }

        private void btnRnhapkho_Click(object sender, EventArgs e)
        {
            report.F_nhapHang f = new report.F_nhapHang();
            f.ShowDialog();
        }

        private void btnRxuatkho_Click(object sender, EventArgs e)
        {
            report.F_xuatHang f = new report.F_xuatHang();
            f.ShowDialog();
        }
    }
}
