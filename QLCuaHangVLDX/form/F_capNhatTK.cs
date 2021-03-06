using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCuaHangVLDX.form
{
    public partial class F_capNhatTK : Form
    {
        public F_capNhatTK()
        {
            InitializeComponent();
        }

        
        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        private void F_capNhatTK_Load(object sender, EventArgs e)
        {
            loadTK();
        }

        private void loadTK()
        {
            string tenDN = F_dangNhap.tenDangNhap;
            try
            {
                var dap = new SqlDataAdapter("SELECT tenDangNhap FROM dbo.nguoiDung WHERE tenDangNhap='" + tenDN + "'", conn);
                var listNguoiDung = new DataTable();
                dap.Fill(listNguoiDung);
                txtTK.Text = listNguoiDung.Rows[0]["tenDangNhap"].ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
                conn.Open();
            }

            string sql = "SELECT * FROM nguoiDung WHERE tenDangNhap='" + txtTK.Text + "'and matKhau='" + txtMK.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == false)
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMK.Text = "";
                txtMKM.Text = "";
                txtMKMM.Text = "";
            }
            else
            {
                if (txtMKM.Text != txtMKMM.Text)
                {
                    MessageBox.Show("Mật khẩu mới phải trùng nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKMM.Text = "";
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                    }
                    string sql2 = "UPDATE nguoiDung SET matKhau=N'" + txtMKM.Text + "' WHERE tenDangNhap=N'" + txtTK.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
