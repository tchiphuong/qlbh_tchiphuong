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
using QLCuaHangVLDX.form;

namespace QLCuaHangVLDX.form
{
    public partial class F_thongTinTK : Form
    {
        public F_thongTinTK()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        private void F_thongTinTK_Load(object sender, EventArgs e)
        {
            loadNguoiDung();
        }
        private void loadNguoiDung()
        {
            string tenDN = F_dangNhap.tenDangNhap;
            //try
            //{
            string ngay = "";
            string thang = "";
            string sql = "SELECT tenDangNhap, matKhau, ten, DAY(namSinh) AS ngay,MONTH(namSinh) AS thang, YEAR(namSinh) AS nam, gioiTinh, diaChi, dienThoai, quyenHan FROM dbo.nguoiDung WHERE tenDangNhap='" + tenDN + "'";
            var dap = new SqlDataAdapter(sql, conn);
                //var dap = new SqlDataAdapter("SELECT tenDangNhap, matKhau, ten, namSinh, gioiTinh, diaChi, dienThoai, quyenHan FROM dbo.nguoiDung WHERE tenDangNhap='" + tenDN + "'", conn);
                var listNguoiDung = new DataTable();
                dap.Fill(listNguoiDung);
                if (double.Parse(listNguoiDung.Rows[0]["ngay"].ToString()) < 10)
                {
                    ngay = "0" + listNguoiDung.Rows[0]["ngay"];
                }
                else
                {
                    ngay = listNguoiDung.Rows[0]["ngay"].ToString();
                }
                if (double.Parse(listNguoiDung.Rows[0]["thang"].ToString()) < 10)
                {
                    thang = "0" + listNguoiDung.Rows[0]["thang"];
                }
                else
                {
                    thang = listNguoiDung.Rows[0]["thang"].ToString();
                }
                string ngaySinh = ngay + "/" + thang + "/" + listNguoiDung.Rows[0]["nam"];
                lblTK.Text = listNguoiDung.Rows[0]["tenDangNhap"].ToString();
                lblMK.Text = listNguoiDung.Rows[0]["matKhau"].ToString();
                lblHT.Text = listNguoiDung.Rows[0]["ten"].ToString();
                lblNS.Text = ngaySinh;
                //lblNS.Text = listNguoiDung.Rows[0]["namSinh"].ToString();
                //lblNS.Text = DateTime.Parse(listNguoiDung.Rows[0]["namSinh"].ToString()).ToShortDateString();
                lblGT.Text = listNguoiDung.Rows[0]["gioiTinh"].ToString();
                lblDC.Text = listNguoiDung.Rows[0]["diaChi"].ToString();
                lblDT.Text = listNguoiDung.Rows[0]["dienThoai"].ToString();
                lblCV.Text = listNguoiDung.Rows[0]["quyenHan"].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
