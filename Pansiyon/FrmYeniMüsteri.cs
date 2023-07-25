using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Pansiyon
{
    public partial class FrmYeniMüsteri : Form
    {
        public FrmYeniMüsteri()
        {
            mysqlbaglan.Open();
            InitializeComponent();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost ; Database=papatya; Uid=root; Pwd=Soulsucker00; SslMode=none;");
        
        private void btn101_Click(object sender, EventArgs e)
        {
            txtoda.Text = "101";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda101(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();    
        }
        
        private void btn102_Click(object sender, EventArgs e)
        {
            txtoda.Text = "102";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda102(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtoda.Text = "103";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda103(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtoda.Text = "104";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda104(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtoda.Text = "105";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda105(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtoda.Text = "106";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda106(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtoda.Text = "107";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda107(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtoda.Text = "108";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda108(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtoda.Text = "109";
            mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda109(adi,soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", mysqlbaglan);
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

        private void btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koyu mavi renkli butonlar dolu odaları gösterir.");
        }

        private void btnboş_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Açık mavi renkli butonlar boş odaları gösterir.");
        }

        private void txtücret_TextChanged(object sender, EventArgs e)
        {

        }

        private void cikistarihi_ValueChanged(object sender, EventArgs e)
        {
            int ücret;
            DateTime kücüktarih = Convert.ToDateTime(giristarihi.Text);
            DateTime büyüktarih = Convert.ToDateTime(cikistarihi.Text);
            TimeSpan Sonuc = büyüktarih - kücüktarih;
            label11.Text = Sonuc.TotalDays.ToString();
            ücret = Convert.ToInt32(label11.Text) * 200;
            txtücret.Text = ücret.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string baglanti_adresi = "Server=localhost ; Database=papatya; Uid=root; Pwd=Soulsucker00; SslMode=none;";
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                

                MySqlCommand cmd = new MySqlCommand($"INSERT INTO müsteri_ekle(adi,soyadi,cinsiyet,telefon,mail,tc,odano,giristarihi,cikistarihi,ücret ) VALUES (@adi,@soyadi ,@cinsiyet,@telefon,@mail,@tcno,@odano,@giristarihi,cikistarihi,@ücret)");
                cmd.Parameters.AddWithValue("@adi", txtad.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtsoyad.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
                cmd.Parameters.AddWithValue("@telefon", msktelefon.Text);
                cmd.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd.Parameters.AddWithValue("@tcno", txttcno.Text);
                cmd.Parameters.AddWithValue("@odano", txtoda.Text);
                cmd.Parameters.AddWithValue("@giristarihi",DateTime.Parse(giristarihi.Text));
                cmd.Parameters.AddWithValue("@cikistarihi",DateTime.Parse(cikistarihi.Text));
                cmd.Parameters.AddWithValue("@ücret", txtücret.Text);
                cmd.Connection = connection;
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    label12.Text = "eklendi";

                }
                else
                {
                    label12.Text = "ekleme hatalı";
                    label12.Visible = true;
                }
                connection.Close();




            }
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void FrmYeniMüsteri_Load(object sender, EventArgs e)
        {
            //101
            
            MySqlCommand komut1 = new MySqlCommand("select * from oda101", mysqlbaglan);
            MySqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.SkyBlue;
                btn101.Enabled= false;
            }
            //102
            mysqlbaglan.Open();
            MySqlCommand komut2 = new MySqlCommand("select * from oda102", mysqlbaglan);
            MySqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.SkyBlue;
                btn102.Enabled = false;
            }
            //103
            mysqlbaglan.Open();
            MySqlCommand komut3 = new MySqlCommand("select * from oda103", mysqlbaglan);
            MySqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.SkyBlue;
                btn103.Enabled = false;
            }
            //104
            mysqlbaglan.Open();
            MySqlCommand komut4 = new MySqlCommand("select * from oda104", mysqlbaglan);
            MySqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.SkyBlue;
                btn104.Enabled = false;
            }
            //105
            mysqlbaglan.Open();
            MySqlCommand komut5 = new MySqlCommand("select * from oda105", mysqlbaglan);
            MySqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn105.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.SkyBlue;
                btn105.Enabled = false;
            }
            //106
            mysqlbaglan.Open();
            MySqlCommand komut6 = new MySqlCommand("select * from oda106", mysqlbaglan);
            MySqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btn106.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.SkyBlue;
                btn106.Enabled = false;
            }
            //107
            mysqlbaglan.Open();
            MySqlCommand komut7 = new MySqlCommand("select * from oda107", mysqlbaglan);
            MySqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btn107.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.SkyBlue;
                btn107.Enabled = false;
            }
            //108
            mysqlbaglan.Open();
            MySqlCommand komut8 = new MySqlCommand("select * from oda108", mysqlbaglan);
            MySqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btn108.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.SkyBlue;
                btn108.Enabled = false;
            }
            //109
            mysqlbaglan.Open();
            MySqlCommand komut9 = new MySqlCommand("select * from oda109", mysqlbaglan);
            MySqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btn109.Text = oku9["adi"].ToString() + " " + oku9["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.SkyBlue;
                btn109.Enabled = false;
            }
        }
    }
}
