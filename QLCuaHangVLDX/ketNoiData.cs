using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangVLDX
{
    public class ketNoiData
    {
        public static SqlConnection connect;

        public void moKetNoi()
        {
            if (ketNoiData.connect == null)
            {
                ketNoiData.connect = new SqlConnection(@"Data Source=DESKTOP-NJR1G1M\SQLEXPRESS01;Initial Catalog=CH_VLXD_Data;Integrated Security=True");
            }
            if (ketNoiData.connect.State != ConnectionState.Open)
            {
                ketNoiData.connect.Open();
            }
        }

        public void dongKetNoi()
        {
            if (ketNoiData.connect != null)
            {
                if (ketNoiData.connect.State == ConnectionState.Open)
                {
                    ketNoiData.connect.Close();
                }
            }
        }
    }

}
