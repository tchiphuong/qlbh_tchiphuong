using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangVLDX.report
{
    public partial class R_nguoiDung : Form
    {
        public R_nguoiDung()
        {
            InitializeComponent();
        }

        private void R_nguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'D_nguoiDung.nguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.D_nguoiDung.nguoiDung);

            this.reportViewer1.RefreshReport();
        }
    }
}
