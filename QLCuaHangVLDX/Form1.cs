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

namespace QLCuaHangVLDX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(string_ketNoi.chuoiKN);
        private void Form1_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT maVatLieu,ten,donGia,soLuong FROM vatLieu", conn);
            var maVL = new DataTable();
            dap.Fill(maVL);
            Column1.DataSource = maVL;
            Column1.ValueMember = "maVatLieu";
            Column1.DisplayMember = "ten";
        }

        private void loadMaHD()
        {
            //conn.Open();
            //string mH = "SELECT mahoadon = MAX(maHoaDon) FROM hoaDon";
            //SqlCommand cm = new SqlCommand(mH, conn);
            //var MaHoaDon = (string)cm.ExecuteScalar();
            //conn.Close();
            string maMoi = "";
            string soMa;
            string maCong;
            if (textBox1.Text != "")
            {
                soMa = textBox1.Text.Substring(2, 4);
            }
            else
            {
                soMa = "0";
            }
            
            textBox2.Text = soMa;
            maCong = (int.Parse(soMa) + 1).ToString();
            textBox3.Text = maCong;
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
            textBox4.Text = maMoi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMaHD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dong = dataGridView1.RowCount - 1;
            dataGridView1.Rows.Clear();
        }
    }
}
