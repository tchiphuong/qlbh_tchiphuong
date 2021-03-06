using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangVLDX.control;
using QLCuaHangVLDX.form;

namespace QLCuaHangVLDX.report
{
    public partial class RP_HoaDon : Form
    {
        public RP_HoaDon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string maHD = "";
            if (F_hoaDon.xemHD == false)
            {
                maHD = UC_hoaDon.maHD;
            }
            else
            {
                maHD = F_hoaDon.maHoaDon;
            }
            // TODO: This line of code loads data into the 'DataSetHoaDon.DataTableHoaDon' table. You can move, or remove it, as needed.
            DataSetHoaDon.DataTableHoaDon.Clear();
            DataSetHoaDon.EnforceConstraints = false;
            DataTableHoaDonTableAdapter.Fill(DataSetHoaDon.DataTableHoaDon, maHD);
            this.uSP_tongTienTableAdapter.Fill(this.dataSetTongTien.USP_tongTien, maHD);
            this.reportViewer1.RefreshReport();
        }
    }
}
