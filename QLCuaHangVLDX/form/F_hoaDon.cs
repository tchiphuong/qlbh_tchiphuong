using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCuaHangVLDX.form
{
    public partial class F_hoaDon : Form
    {
        public F_hoaDon()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string maHoaDon = "";
        public static bool xemHD = true;
        private void btnIn_Click(object sender, EventArgs e)
        {
            maHoaDon = comboBox3.Text;
            xemHD = true;
            report.RP_HoaDon f = new report.RP_HoaDon();
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "EXEC USP_xoaHoaDon @maHD = '" + comboBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Đã xóa chi tiết hóa","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            hienThi();
        }

        private void hienThi()
        {
            string sql1 = "SELECT tenKhachHang, dienThoai, diaChi FROM View_HoaDon GROUP BY tenKhachHang, dienThoai, diaChi";
            var dap1 = new SqlDataAdapter(sql1, conn);
            var maHD = new DataTable();
            dap1.Fill(maHD);
            comboBox1.DataSource = maHD;
            comboBox1.DisplayMember = "tenKhachHang";
            comboBox1.ValueMember = "tenKhachHang";
            lblDC.DataBindings.Clear();
            lblDC.DataBindings.Add("Text", comboBox1.DataSource, "diaChi");
            lblDT.DataBindings.Clear();
            lblDT.DataBindings.Add("Text", comboBox1.DataSource, "dienThoai");
        }

        private void F_hoaDon_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT CONCAT(DAY(ngayLap),'/', MONTH(ngayLap),'/', YEAR(ngayLap)) AS ngay FROM View_HoaDon WHERE tenKhachHang = N'" + comboBox1.Text + "' GROUP BY MONTH(ngayLap), DAY(ngayLap), YEAR(ngayLap)";

            //string sql2 = "SELECT ngayLap FROM View_HoaDon WHERE tenKhachHang = N'" + comboBox1.Text + "' GROUP BY ngayLap, nhanVien";
            var dap2 = new SqlDataAdapter(sql2, conn);
            var ngay = new DataTable();
            dap2.Fill(ngay);
            comboBox2.DataSource = ngay;
            comboBox2.DisplayMember = "ngay";
            comboBox2.ValueMember = "ngay";
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql2 = "SET DATEFORMAT DMY SELECT maHoaDon, nhanVien FROM View_HoaDon WHERE ngayLap = N'" + comboBox2.Text + "' AND tenKhachHang = N'" + comboBox1.Text + "' GROUP BY maHoaDon, nhanVien";
            var dap2 = new SqlDataAdapter(sql2, conn);
            var ngay = new DataTable();
            dap2.Fill(ngay);
            comboBox3.DataSource = ngay;
            comboBox3.DisplayMember = "maHoaDon";
            comboBox3.ValueMember = "maHoaDon";
            lblNV.DataBindings.Clear();
            lblNV.DataBindings.Add("Text", comboBox3.DataSource, "nhanVien");
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql = "SELECT ten, donViTinh, soLuong, donGia, thanhTien FROM dbo.View_HoaDon WHERE maHoaDon='" + comboBox3.Text + "'";
            var dap = new SqlDataAdapter(sql, conn);
            var listHD = new DataTable();
            dap.Fill(listHD);
            dgvHD.DataSource = listHD;
        }
    }
}
