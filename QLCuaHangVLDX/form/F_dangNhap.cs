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
    public partial class F_dangNhap : Form
    {
        public F_dangNhap()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        public static string tenDangNhap;

        private void resetDangNhap()
        {
            txtMatKhau.Text = "";
            txtTaiKhoan.Focus();
        }


        private void btnHienMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                btnHienMK.BackgroundImage = global::QLCuaHangVLDX.Properties.Resources.an;
                toolTip1.SetToolTip(this.btnHienMK, "Ẩn mật khẩu");
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                btnHienMK.BackgroundImage = global::QLCuaHangVLDX.Properties.Resources.hien;
                toolTip1.SetToolTip(this.btnHienMK, "Hiện mật khẩu");
            }
        }

        private void dangNhap()
        {
            //try
            //{
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
                conn.Open();
            }
            string sql = "SELECT * FROM nguoiDung WHERE tenDangNhap='" + txtTaiKhoan.Text + "'and matKhau='" + txtMatKhau.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            string User = txtTaiKhoan.Text;
            if (dta.Read() == true)
            {
                tenDangNhap = txtTaiKhoan.Text;
                F_trangChu f = new F_trangChu();
                this.Hide();
                f.ShowDialog();
                resetDangNhap();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetDangNhap();
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối");
            //    resetDangNhap();
            //}

        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangNhap();
        }

        private void F_dangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void F_dangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
