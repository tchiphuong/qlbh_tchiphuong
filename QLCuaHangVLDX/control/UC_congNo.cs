using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLCuaHangVLDX.form;

namespace QLCuaHangVLDX.control
{
    public partial class UC_congNo : UserControl
    {
        public UC_congNo()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        private void hienThi()
        {
            if (comboBox1.Text == "Tất cả")
            {
                var dap = new SqlDataAdapter("SELECT * FROM view_congNo", conn);
                var listNo = new DataTable();
                dap.Fill(listNo);
                dataGridView1.DataSource = listNo;
            }
            else
            {
                var dap = new SqlDataAdapter("EXEC USP_getCongNo @maNV = N'" + F_dangNhap.tenDangNhap + "'", conn);
                var listNo = new DataTable();
                dap.Fill(listNo);
                dataGridView1.DataSource = listNo;
            }
            txtTienTra.Enabled = false;
            txtTienNo.Text = "";
            txtTenKH.Text = "";
            txtMHD.Text = "";
            txtTienTra.Text = "";
        }

        private void UC_congNo_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hienThi();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtTienTra.Enabled = true;
            btnLuu.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTienTra.Text != "")
            {
                btnLuu.Enabled = false;
                btnCapNhat.Enabled = true;
                int tien = 0;
                tien = int.Parse(txtTienNo.Text.ToString()) - int.Parse(txtTienTra.Text.ToString());
                conn.Open();
                string sql = "UPDATE dbo.congNo SET tienNo='" + tien + "' WHERE maHoaDon='" + txtMHD.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                xoaCongNo();
                hienThi();
            }
            else
            {
                MessageBox.Show("Chưa nhập số tiền cần trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xoaCongNo()
        {
            conn.Open();
            string sql = "DELETE FROM congNo WHERE tienNo=N'0'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Đã xóa nợ khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM view_congNo WHERE tenKhachHang LIKE N'%" + txtNoiDungTim.Text + "%'", conn);
            var list = new DataTable();
            dap.Fill(list);
            dataGridView1.DataSource = list;
            string dem = dataGridView1.RowCount.ToString();
            MessageBox.Show("Có " + dem + " kết quả cho tìm kiếm của bạn.", "Kết quả");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;
                txtTenKH.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                txtMHD.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
                txtTienNo.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            }
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            report.F_congNo f = new report.F_congNo();
            f.ShowDialog();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienThi();
        }
    }
}
