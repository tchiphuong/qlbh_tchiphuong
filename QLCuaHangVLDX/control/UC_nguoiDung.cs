using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangVLDX.report;
using System.Data.SqlClient;

namespace QLCuaHangVLDX.control
{
    public partial class UC_nguoiDung : UserControl
    {
        public UC_nguoiDung()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        //BUS_nguoiDung bus = new BUS_nguoiDung();
        //EC_nguoiDung ec = new EC_nguoiDung();
        //private bool themMoi = false;
        //private bool click = false;

        void khoaDieuKien()
        {
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            txtTen.Enabled = false;
            txtNgay.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
            cboChucVu.Enabled = false;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
        }

        void moDieuKien()
        {
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            txtTen.Enabled = true;
            txtNgay.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
            cboChucVu.Enabled = true;

            btnThem.Enabled = false;
            btnCapNhat.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        void setNull()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private bool themMoi = false;
        private bool click = false;
        void hienThi()
        {
            try
            {
                var dap = new SqlDataAdapter("SELECT * FROM nguoiDung", conn);
                var listNguoiDung = new DataTable();
                dap.Fill(listNguoiDung);
                dgvNguoiDung.DataSource = listNguoiDung;
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_nguoiDung_Load(object sender, EventArgs e)
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
                txtTaiKhoan.Enabled = false;
                themMoi = false;
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
                    if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtTen.Text == "" || txtNgay.Text == "" || cboGioiTinh.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "" || cboChucVu.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập thông tin chứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        conn.Open();
                        string sql = "INSERT INTO nguoiDung (tenDangNhap, matKhau, ten, namSinh, gioiTinh, diaChi, dienThoai, quyenHan) VALUES ('" + txtTaiKhoan.Text + "','" + txtMatKhau.Text + "',N'" + txtTen.Text + "','" + txtNgay.Text + "',N'" + cboGioiTinh.Text + "',N'" + txtDiaChi.Text + "','" + txtDienThoai.Text + "',N'" + cboChucVu.Text + "')";
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
                    MessageBox.Show(txtTaiKhoan.Text + "đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE nguoiDung SET matKhau ='" + txtMatKhau.Text + "', ten =N'" + txtTen.Text + "', namSinh ='" + txtNgay.Text + "', gioiTinh =N'" + cboGioiTinh.Text + "', diaChi =N'" + txtDiaChi.Text + "', dienThoai ='" + txtDienThoai.Text + "', quyenHan =N'" + cboChucVu.Text + "' WHERE tenDangNhap='" + txtTaiKhoan.Text + "'";
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
                    MessageBox.Show("Không thể sửa " + txtTaiKhoan.Text + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sql = "DELETE FROM nguoiDung WHERE tenDangNhap=N'" + txtTaiKhoan.Text + "'";
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
                    MessageBox.Show(txtTaiKhoan.Text + " chưa được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            R_nguoiDung r = new R_nguoiDung();
            r.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hienThi();
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                click = true;
                khoaDieuKien();
                if (e.RowIndex >= 0)
                {
                    int dong = e.RowIndex;
                    txtTaiKhoan.Text    = dgvNguoiDung.Rows[dong].Cells[0].Value.ToString();
                    txtMatKhau.Text     = dgvNguoiDung.Rows[dong].Cells[1].Value.ToString();
                    txtTen.Text         = dgvNguoiDung.Rows[dong].Cells[2].Value.ToString();
                    txtNgay.Text        = dgvNguoiDung.Rows[dong].Cells[3].Value.ToString();
                    cboGioiTinh.Text    = dgvNguoiDung.Rows[dong].Cells[4].Value.ToString();
                    txtDiaChi.Text      = dgvNguoiDung.Rows[dong].Cells[5].Value.ToString();
                    txtDienThoai.Text   = dgvNguoiDung.Rows[dong].Cells[6].Value.ToString();
                    cboChucVu.Text      = dgvNguoiDung.Rows[dong].Cells[7].Value.ToString();
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s = cboHinhThuc.Text;
            if (s == "Họ tên")
            {
                try
                {
                    var dap = new SqlDataAdapter("SELECT * FROM nguoiDung WHERE ten LIKE N'%" + txtNoiDungTim.Text + "%'", conn);
                    var listVatLieu = new DataTable();
                    dap.Fill(listVatLieu);
                    dgvNguoiDung.DataSource = listVatLieu;
                    string dem = dgvNguoiDung.RowCount.ToString();
                    MessageBox.Show("Có " + dem + " kết quả cho tìm kiếm của bạn.", "Kết quả");
                }
                catch
                {
                    MessageBox.Show("Không có kết quả cho tìm kiếm của bạn.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (s == "Giới tính")
            {
                try
                {
                    var dap = new SqlDataAdapter("SELECT * FROM nguoiDung WHERE gioiTinh LIKE N'%" + txtNoiDungTim.Text + "%'", conn);
                    var listVatLieu = new DataTable();
                    dap.Fill(listVatLieu);
                    dgvNguoiDung.DataSource = listVatLieu;
                    string dem = dgvNguoiDung.RowCount.ToString();
                    MessageBox.Show("Có " + dem + " kết quả cho tìm kiếm của bạn.", "Kết quả");
                }
                catch
                {
                    MessageBox.Show("Không có kết quả cho tìm kiếm của bạn.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (s == "Chức vụ")
            {
                try
                {
                    var dap = new SqlDataAdapter("SELECT * FROM nguoiDung WHERE quyenHan LIKE N'%" + txtNoiDungTim.Text + "%'", conn);
                    var listVatLieu = new DataTable();
                    dap.Fill(listVatLieu);
                    dgvNguoiDung.DataSource = listVatLieu;
                    string dem = dgvNguoiDung.RowCount.ToString();
                    MessageBox.Show("Có " + dem + " kết quả cho tìm kiếm của bạn.", "Kết quả");
                }
                catch
                {
                    MessageBox.Show("Không có kết quả cho tìm kiếm của bạn.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
