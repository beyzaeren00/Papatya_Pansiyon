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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost ; Database=papatya; Uid=root; Pwd=Soulsucker00; SslMode=none;");
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //101
            mysqlbaglan.Open();
            MySqlCommand komut1 = new MySqlCommand("select * from oda101", mysqlbaglan);
            MySqlDataReader oku1= komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["adi"].ToString()+" " + oku1["soyadi"].ToString();
            }
            mysqlbaglan.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.SkyBlue;
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
            }




        }
    }
}
