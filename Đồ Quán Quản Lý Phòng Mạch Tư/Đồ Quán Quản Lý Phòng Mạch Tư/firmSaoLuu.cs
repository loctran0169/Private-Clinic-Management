using MySql.Data.MySqlClient;
using QLPKBUS;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmSaoLuu : Form
    {
        MySqlConnection conn;
        public firmSaoLuu()
        {
            InitializeComponent();
        }

        private void bt_ketnoi_Click(object sender, EventArgs e)
        {
            string connString = "SERVER="+cbb_server.Text+";PORT=10001;DATABASE=QLKP;UID=loctran0169;PASSWORD=angel1999;Charset = utf8";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt = conn.GetSchema("Databases");
            if (dt != null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    string databasename = dr.Field<string>("database_name");
                    short dbID = dr.Field<short>("dbid");
                    cbb_server.Items.Add(databasename);
                }
            }
        }
    }
}
