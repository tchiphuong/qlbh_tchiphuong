using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangVLDX.form;
using QLCuaHangVLDX.report;
using System.Data.SqlClient;

namespace QLCuaHangVLDX.control
{
    public partial class UC_hoaDon : UserControl
    {
        public UC_hoaDon()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);

        int dong = 0;
        int tongTien = 0;
        public static string maHD;
        public static string maKH;
        public static bool themKH = false;


        string maKHang = "";
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtNgay.Text == "" || cboMaKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập thông tin chứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string MaKhachHang = lblMaKH.Text;
                string MaNguoiDung = txtNhanVien.Text;
                //string NgayLap = txtNgay.Text;
                txtNgay.CustomFormat = "dd/MM/yyyy";
                string NgayLap = txtNgay.Text;
                txtNgay.CustomFormat = "'ngày 'dd' tháng 'MM' năm 'yyyy";
                maKHang = lblMaKH.Text;
                conn.Open();
                string sql = "SET DATEFORMAT DMY INSERT INTO hoaDon (ngayLap, nhanVien, khachHang) VALUES ('" + NgayLap + "',N'" + MaNguoiDung.ToString() + "','" + MaKhachHang.ToString() + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                insertXuathang(NgayLap, MaNguoiDung);
            }
            try
            {
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    string MaVatLieu = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                    string SoLuongCo = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                    string SoLuongMua = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                    string DonGiaBan = dgvHoaDon.Rows[i].Cells[4].Value.ToString();

                    conn.Open();
                    string mH = "SELECT mahoadon = MAX(maHoaDon) FROM hoaDon";
                    SqlCommand cm = new SqlCommand(mH, conn);
                    var MaHoaDon = (string)cm.ExecuteScalar();
                    string sql = "INSERT INTO chiTietHoaDon (maHoaDon, maVatLieu, soLuong, donGia, thanhTien) VALUES ('" + MaHoaDon + "','" + MaVatLieu + "','" + SoLuongMua + "','" + DonGiaBan + "',(" + SoLuongMua + "*" + DonGiaBan + "))";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    capNhatVatLieu(MaVatLieu, SoLuongCo, SoLuongMua);
                    insertCHxuatKho(MaVatLieu,SoLuongMua);
                }
                MessageBox.Show("Đã thêm hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGhiNo.Enabled = true;
                btnThanhToan.Enabled = true;
            }
            catch
            {

            }
        }

        private void loadMaHD()
        {
            conn.Open();
            string mH = "SELECT mahoadon = MAX(maHoaDon) FROM hoaDon";
            SqlCommand cm = new SqlCommand(mH, conn);
            var MaHoaDon = (string)cm.ExecuteScalar();
            conn.Close();
            string maMoi = "";
            string soMa;
            string maCong;
            if (MaHoaDon != "")
            {
                soMa = MaHoaDon.Substring(2, 4);
            }
            else
            {
                soMa = "0";
            }

            maCong = (int.Parse(soMa) + 1).ToString();
            if (int.Parse(soMa) < 10)
            {
                maMoi = "HD000" + maCong;
            }
            else if (int.Parse(soMa) < 100)
            {
                maMoi = "HD00" + maCong;
            }
            else if (int.Parse(soMa) < 1000)
            {
                maMoi = "HD0" + maCong;
            }
            else
            {
                maMoi = "HD" + maCong;
            }
            lblMaHD.Text = maMoi;
        }

        private void insertXuathang(string ngay, string nhanvien)
        {
            conn.Open();
            string sql = "SET DATEFORMAT DMY INSERT INTO xuatKho (ngayNhap, nhanVien) VALUES ('" + ngay + "','" + nhanvien + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void insertCHxuatKho(string maVL, string soLuong)
        {
            conn.Open();
            string sql1 = "SELECT maXuatKho = MAX(maXuatKho) FROM xuatKho";
            SqlCommand cm = new SqlCommand(sql1, conn);
            var maXuat = (string)cm.ExecuteScalar();
            string sql = "INSERT INTO phieuXuatKho (maXuatKho, vatlieu, soluong) VALUES ('" + maXuat + "','" + maVL + "','" + soLuong + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void hienThi()
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
            var dap = new SqlDataAdapter("SELECT maVatLieu,ten,donGia,soLuong FROM vatLieu", conn);
            var maVL = new DataTable();
            dap.Fill(maVL);
            colMa.DataSource = maVL;
            colMa.ValueMember = "maVatLieu";
            colMa.DisplayMember = "ten";
            loadKhachHang();
            btnGhiNo.Enabled = false;
            btnThanhToan.Enabled = false;
            txtNhanVien.Text = F_dangNhap.tenDangNhap;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvHoaDon.ClearSelection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
                conn.Open();
            }
            hienThi();
        }
        
        private void UC_hoaDon_Load(object sender, EventArgs e)
        {
            hienThi();
            loadMaHD();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.Rows[dong].Cells[2].Value != null && dgvHoaDon.Rows[dong].Cells[3].Value != "0")
            {
                string SoLuongCo = dgvHoaDon.Rows[dong].Cells[2].Value.ToString();
                string SoLuongMua = dgvHoaDon.Rows[dong].Cells[3].Value.ToString();
                if (int.Parse(SoLuongCo) < int.Parse(SoLuongMua))
                {
                    MessageBox.Show("Số lượng mua vượt số số lượng hiện có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvHoaDon.Rows[dong].Cells[3].Style.BackColor = Color.Red;
                    return;
                }
                else
                {
                    dgvHoaDon.Rows[dong].Cells[3].Style.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                }
            }

            if (dgvHoaDon.Rows[dong].Cells[4].Value != "0" && dgvHoaDon.Rows[dong].Cells[3].Value != "0")
            {
                try
                {
                    dgvHoaDon.Rows[dong].Cells[5].Value = (double.Parse(dgvHoaDon.Rows[dong].Cells[4].Value.ToString()) * double.Parse(dgvHoaDon.Rows[dong].Cells[3].Value.ToString())).ToString();
                    int sc = dgvHoaDon.Rows.Count;
                    tongTien = 0;
                    for (int i = 0; i < sc - 1; i++)
                    {
                        tongTien += int.Parse(dgvHoaDon.Rows[i].Cells[5].Value.ToString());
                    }
                    lblTongTien.Text = String.Format("{0:#,##0}", double.Parse(tongTien.ToString()));
                }
                catch
                {

                }
            }
            
            try
            {
                var dap = new SqlDataAdapter("SELECT maVatLieu,ten, donViTinh,donGia,soLuong FROM vatLieu WHERE maVatLieu = '" + dgvHoaDon.Rows[dong].Cells[0].Value.ToString() + "'", conn);
                var maVL = new DataTable();
                dap.Fill(maVL);
                dgvHoaDon.Rows[dong].Cells[1].Value = maVL.Rows[0]["donViTinh"].ToString();
                dgvHoaDon.Rows[dong].Cells[2].Value = int.Parse(maVL.Rows[0]["soLuong"].ToString());
                dgvHoaDon.Rows[dong].Cells[4].Value = int.Parse(maVL.Rows[0]["donGia"].ToString());
            }
            catch
            {

            }
        }

        private void btnGhiNo_Click(object sender, EventArgs e)
        {
            string TienNo = tongTien.ToString();
            try
            {
                conn.Open();
                string mH = "SELECT mahoadon = MAX(maHoaDon) FROM hoaDon";
                SqlCommand cm = new SqlCommand(mH, conn);
                string MaHoaDon = (string)cm.ExecuteScalar();
                string sql = "INSERT INTO congNo (maKhachHang, maHoaDon, tienNo, nhanVien) VALUES ('" + maKHang + "','" + MaHoaDon + "','" + int.Parse(TienNo) + "', '" + txtNhanVien.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Hóa đơn đã được ghi nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThanhToan.Enabled = false;
                btnGhiNo.Enabled = false;
                dgvHoaDon.Rows.Clear();
                loadMaHD();
                hienThi();
            }
            catch
            {
                MessageBox.Show("LỖI RỒI");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            conn.Open();
            string mH = "SELECT mahoadon = MAX(maHoaDon) FROM hoaDon";
            SqlCommand cm = new SqlCommand(mH, conn);
            string MaHoaDon = (string)cm.ExecuteScalar();
            conn.Close();
            lblMaHD.Text = MaHoaDon;
            maHD = MaHoaDon;
            if (MessageBox.Show("Số tiền cần trả\n" + tongTien + " VND.\nBạn có muốn in hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                F_hoaDon.xemHD = false;
                RP_HoaDon r = new RP_HoaDon();
                r.ShowDialog();
            }
            btnThanhToan.Enabled = false;
            btnGhiNo.Enabled = false;
            dgvHoaDon.Rows.Clear();
            loadMaHD();
            hienThi();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            F_themKH f = new F_themKH();
            f.ShowDialog();
            themKH = true;
            hienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string noiDung = txtNoiDung.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
                conn.Open();
            }
            string sql = "SELECT * FROM khachHang WHERE dienThoai = '" + noiDung + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                MessageBox.Show("Khách hàng đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaKH.Focus();
                txtNoiDung.Text = "";
            }
            else
            {
                if (MessageBox.Show("Khách hàng không tồn tại.\nBạn có muốn thêm khách hàng?", "Đăng nhập thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    soDienThoai = txtNoiDung.Text;
                    F_themKH f = new F_themKH();
                    f.ShowDialog();
                }
                txtNoiDung.Text = "";
            }
        }
        public static string soDienThoai = "";
        private void loadKhachHang()
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
            var dap = new SqlDataAdapter("SELECT * FROM khachHang", conn);
            var kh = new DataTable();
            dap.Fill(kh);
            cboMaKH.DisplayMember = "tenKhachHang";
            cboMaKH.ValueMember = "maKhachHang";
            cboMaKH.DataSource = kh;
            lblMaKH.DataBindings.Clear();
            lblMaKH.DataBindings.Add("Text", cboMaKH.DataSource, "maKhachHang");
            lblDienThoai.DataBindings.Clear();
            lblDienThoai.DataBindings.Add("Text", cboMaKH.DataSource, "dienThoai");
            conn.Close();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            F_hoaDon f = new F_hoaDon();
            f.ShowDialog();
        }

        private void capNhatVatLieu(string maVL, string soLuongCo, string soLuongMua)
        {
            conn.Open();
            int soLuongCon = (int.Parse(soLuongCo) - int.Parse(soLuongMua));
            string sql = "UPDATE vatLieu SET soLuong ='" + soLuongCon + "' WHERE maVatLieu=N'" + maVL + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}