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

namespace QLCuaHangVLDX.control
{
    public partial class UC_capNhatGia : UserControl
    {
        public UC_capNhatGia()
        {
            InitializeComponent();
        }

        private bool click = false;
        string maVL = "";

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);


        void khoaDieuKien()
        {
            txtTenVL.Enabled = false;
            txtDonVT.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuong.Enabled = false;

            btnLuu.Enabled = false;
        }

        void moDieuKien()
        {
            txtTenVL.Enabled = false;
            txtDonVT.Enabled = false;
            txtDonGia.Enabled = true;
            txtSoLuong.Enabled = false;

            btnLuu.Enabled = true;
        }

        void setNull()
        {
            txtTenVL.Text = "";
            txtDonVT.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }

        void hienThi()
        {
            try
            {
                var dap = new SqlDataAdapter("SELECT maVatLieu, ten, donViTinh, donGia, soLuong FROM vatLieu", conn);
                var listVatLieu = new DataTable();
                dap.Fill(listVatLieu);
                dgvVatLieu.DataSource = listVatLieu;
                khoaDieuKien();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                var dap = new SqlDataAdapter("SELECT maVatLieu, ten, donViTinh, donGia, soLuong FROM vatLieu WHERE ten LIKE N'%" + txtNoiDungTim.Text + "%'", conn);
                var listVatLieu = new DataTable();
                dap.Fill(listVatLieu);
                dgvVatLieu.DataSource = listVatLieu;
                string dem = dgvVatLieu.RowCount.ToString();
                MessageBox.Show("Có " + dem + " kết quả cho tìm kiếm của bạn.", "Kết quả");
            }
            catch
            {
                MessageBox.Show("Không có kết quả cho tìm kiếm của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE vatLieu SET donGia ='" + int.Parse(txtDonGia.Text) + "' WHERE maVatLieu=N'" + maVL + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                setNull();
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienThi();
                txtDonVT.Enabled = false;
                txtSoLuong.Enabled = false;
                txtTenVL.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không thể sửa " + txtTenVL.Text + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hienThi();
        }

        private void UC_capNhatGia_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void dgvVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                moDieuKien();
                click = true;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvVatLieu.Rows[e.RowIndex];
                    maVL = row.Cells[0].Value.ToString();
                    txtTenVL.Text = row.Cells[1].Value.ToString();
                    txtDonVT.Text = row.Cells[2].Value.ToString();
                    txtDonGia.Text = row.Cells[3].Value.ToString();
                    txtSoLuong.Text = row.Cells[4].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
