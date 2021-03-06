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
using QLCuaHangVLDX.control;

namespace QLCuaHangVLDX.form
{
    public partial class F_themKH : Form
    {
        public F_themKH()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string TenKhachHang = txtTenKH.Text;
            string DienThoai = txtDienThoai.Text;
            string DiaChi = txtDiaChi.Text;

            try
            {
                if (TenKhachHang == "" || DienThoai == "" || DiaChi == "")
                {
                    MessageBox.Show("Bạn phải nhập thông tin chứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Open();
                    string sql = "INSERT INTO khachHang (tenKhachHang, dienThoai, diaChi) VALUES (N'" + TenKhachHang + "',N'" + DienThoai + "',N'" + DiaChi + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Dữ liệu đã được thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show(TenKhachHang + "chưa được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_themKH_Load(object sender, EventArgs e)
        {
            txtDienThoai.Text = UC_hoaDon.soDienThoai;
        }
    }
}
