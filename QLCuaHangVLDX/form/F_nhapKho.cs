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
    public partial class F_nhapKho : Form
    {
        public F_nhapKho()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);
        private void F_nhapKho_Load(object sender, EventArgs e)
        {
            hienThi();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void hienThi()
        {
            conn.Open();
            string sql = "SELECT ten FROM dbo.nguoiDung WHERE tenDangNhap =N'" + F_dangNhap.tenDangNhap + "'";
            SqlCommand cm = new SqlCommand(sql, conn);
            string ten = (string)cm.ExecuteScalar();
            conn.Close();
            lalNhanVien.Text = ten;
            var dap = new SqlDataAdapter("SELECT maVatLieu,ten,donGia,soLuong FROM vatLieu", conn);
            var maVL = new DataTable();
            dap.Fill(maVL);
            cboVL.DataSource = maVL;
            cboVL.ValueMember = "maVatLieu";
            cboVL.DisplayMember = "ten";
            lblMaVL.DataBindings.Clear();
            lblMaVL.DataBindings.Add("Text", cboVL.DataSource, "maVatLieu");

        }

        private void themVL()
        {

            dataGridView.Rows.Add(lblMaVL.Text, cboVL.Text, txtSL.Text, txtNN.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "" || txtNN.Text == "")
            {
                MessageBox.Show("Chưa chọn điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                themVL();
                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        private void themNhapKho()
        {
            conn.Open();
            string sql = "SET DATEFORMAT DMY INSERT INTO dbo.nhapKho (ngayNhap,nhanVien) VALUES ('" + cboNN.Text + "' , '" + F_dangNhap.tenDangNhap + "' )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void themChiTiet(string maNK, string maVL, string SL, string noiNhap)
        {
            conn.Open();
            string sql = "INSERT INTO phieuNhapKho (maNhapKho, vatLieu, soLuong, noiNhap) VALUES (N'" + maNK + "',N'" + maVL + "','" + SL + "',N'" + noiNhap + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void capNhatVatLieu(string maVL, string soLuong)
        {
            conn.Open();
            string sql = "UPDATE vatLieu SET soLuong = soLuong + " + soLuong + " WHERE maVatLieu=N'" + maVL + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void themChiTiet()
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string MaVatLieu = dataGridView.Rows[i].Cells[0].Value.ToString();
                string SoLuong = dataGridView.Rows[i].Cells[2].Value.ToString();
                string NoiNhap = dataGridView.Rows[i].Cells[3].Value.ToString();
                
                conn.Open();
                string mH = "SELECT maNhapKho = MAX(maNhapKho) FROM nhapKho";
                SqlCommand cm = new SqlCommand(mH, conn);
                var maNhapKho = (string)cm.ExecuteScalar();
                conn.Close();
                themChiTiet(maNhapKho, MaVatLieu, SoLuong, NoiNhap);
                capNhatVatLieu(MaVatLieu, SoLuong);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell oneCell in dataGridView.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridView.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn đối tượng cần xóa","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            themNhapKho();
            themChiTiet();
            MessageBox.Show("Nhập kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView.Rows.Clear();
            lblMaVL.Text = "";
            cboVL.Text = "";
            txtSL.Text = "";
            txtNN.Text = "";
        }
    }
}
