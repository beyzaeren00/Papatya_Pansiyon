using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pansiyon
{
    public partial class FrmAdminGiriş : Form
    {
        public FrmAdminGiriş()
        {
            InitializeComponent();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost ; Database=papatya; Uid=root; Pwd=Soulsucker00; SslMode=none;");
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlbaglan.Open();
                string mysql = "select * from admin_giris where kullanıcı=@kullanıcı and sifre=@sifre ";
                MySqlParameter prm1 = new MySqlParameter("kullanıcı",txtkullaniciadi.Text);
                MySqlParameter prm2 = new MySqlParameter("sifre", txtsifre.Text);
                MySqlCommand komut = new MySqlCommand(mysql, mysqlbaglan);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt= new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr= new FrmAnaForm();
                    fr.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
