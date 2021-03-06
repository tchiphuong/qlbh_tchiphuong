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
    public partial class UC_vatLieu : UserControl
    {
        public UC_vatLieu()
        {
            InitializeComponent();
        }

        private bool themMoi = false;
        private bool click = false;
        string maVL ="";

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        void khoaDieuKien()
        {
            txtTenVL.Enabled = false;
            txtDonVT.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuong.Enabled = false;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
        }

        void moDieuKien()
        {
            txtTenVL.Enabled = true;
            txtDonVT.Enabled = true;
            txtDonGia.Enabled = true;
            txtSoLuong.Enabled = true;

            btnThem.Enabled = false;
            btnCapNhat.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
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
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_vatLieu_Load(object sender, EventArgs e)
        {
            khoaDieuKien();
            hienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            moDieuKien();
            setNull();
            themMoi = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (click == true)
            {
                moDieuKien();
                txtDonGia.Enabled = false;
                themMoi = false;
                txtSoLuong.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themMoi == true)
            {
                try
                {
                    if (txtTenVL.Text == "" || txtDonVT.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập thông tin chứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        conn.Open();
                        string sql = "INSERT INTO vatLieu (ten, donViTinh, donGia, soLuong) VALUES (N'" + txtTenVL.Text + "',N'" + txtDonVT.Text + "','" + int.Parse(txtDonGia.Text) + "','" + int.Parse(txtSoLuong.Text) + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        khoaDieuKien();
                        setNull();
                        MessageBox.Show("Dữ liệu đã được thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThi();
                    }
                }
                catch
                {
                    MessageBox.Show(txtTenVL.Text + "đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE vatLieu SET ten =N'" + txtTenVL.Text + "', donViTinh =N'" + txtDonVT.Text + "' WHERE maVatLieu=N'" + lalmaVL.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    khoaDieuKien();
                    setNull();
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThi();

                }
                catch
                {
                    MessageBox.Show("Không thể sửa " + txtTenVL.Text + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (click == true)
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM vatLieu WHERE maVatLieu=N'" + lalmaVL.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    khoaDieuKien();
                    setNull();
                    MessageBox.Show("Dữ liệu đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThi();
                }
                catch
                {
                    MessageBox.Show(txtTenVL.Text + " chưa được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                khoaDieuKien();
                click = true;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvVatLieu.Rows[e.RowIndex];
                    lalmaVL.Text = row.Cells[0].Value.ToString();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hienThi();
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

        private void btnInDS_Click(object sender, EventArgs e)
        {
            report.F_vatLieu f = new report.F_vatLieu();
            f.ShowDialog();
        }

        
    }
}
