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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost ; Database=papatya; Uid=root; Pwd=Soulsucker00; SslMode=none;");
        private void button1_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            MySqlCommand cmd = new MySqlCommand("Select sum(ücret) as Toplam from müsteri_ekle", mysqlbaglan);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lblkasatoplam.Text = dr["Toplam"].ToString();
            }
            mysqlbaglan.Close();

            int personel;
            personel = Convert.ToInt16(txtpersonelsayısı.Text);
            lblpersonel.Text = (personel * 700).ToString();

            int sonuc;
            sonuc= Convert.ToInt16(lblkasatoplam.Text)- (Convert.ToInt16(lblpersonel.Text)+ Convert.ToInt16(lblalınantutar.Text)+Convert.ToInt16(lblfaturalar.Text));
            lblsonuç.Text=Convert.ToString(sonuc);
        }
    }
}
