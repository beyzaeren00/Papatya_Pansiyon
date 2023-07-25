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
using Newtonsoft.Json;

namespace Pansiyon
{
    public partial class FrmMüsteriler : Form
    {
        public FrmMüsteriler()
        {
            
            InitializeComponent();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost ; Database=papatya; Uid=root; Pwd=Soulsucker00; SslMode=none;");

        private void verilergoster()
        {
            mysqlbaglan.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from müsteri_ekle", mysqlbaglan);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            mysqlbaglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mysqlbaglan.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from müsteri_ekle", mysqlbaglan);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            mysqlbaglan.Close();
        }
        
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //txtad.Text = dataGridView1.
            //txtsoyad.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //cmbcinsiyet.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //msktelefon.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //txtmail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //txttcno.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //txtoda.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            //giristarihi.Text= dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            //cikistarihi.Text= dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            //txtücret.Text= dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtoda.Text=="101")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda101", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "102")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda102", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "103")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda103", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "104")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda104", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "105")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda105", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "106")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda106", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "107")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda107", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "108")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda108", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }
            if (txtoda.Text == "109")
            {
                mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda109", mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();
                verilergoster();
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            cmbcinsiyet.Text = "";
            msktelefon.Clear();
            txtmail.Clear();
            txttcno.Clear();
            txtoda.Clear();
            giristarihi.Text = "";
            cikistarihi.Text = "";
            txtücret.Clear();
            
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            
            MySqlCommand komut = new MySqlCommand("update müsteri_ekle set adi=@adi,soyadi=@soyadi,cinsiyet=@cinsiyet,telefon=@telefon, mail=@mail, tc=@tc,odano=@odano, giristarihi=@giristarihi, cikistarihi=@cikistarihi ,ücret=@ücret where müsteri_id=("+id+")", mysqlbaglan);
            komut.Parameters.AddWithValue("@adi", txtad.Text);
            komut.Parameters.AddWithValue("@soyadi", txtsoyad.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", msktelefon.Text);
            komut.Parameters.AddWithValue("@mail", txtmail.Text);
            komut.Parameters.AddWithValue("@tc", txttcno.Text);
            komut.Parameters.AddWithValue("@odano", txtoda.Text);
            komut.Parameters.AddWithValue("@giristarihi", giristarihi.Value);
            komut.Parameters.AddWithValue("@cikistarihi", cikistarihi.Value);
            komut.Parameters.AddWithValue("@ücret", Convert.ToString(txtücret.Text));
            mysqlbaglan.Open();
            komut.ExecuteNonQuery();
            mysqlbaglan.Close();
            verilergoster();

        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //cmbcinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //msktelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //txtmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //txttcno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //txtoda.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //giristarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //cikistarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //txtücret.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
        int id = 0;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbcinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            msktelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txttcno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtoda.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            giristarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cikistarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtücret.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from müsteri_ekle where adi like '%"+txtara.Text+"%'", mysqlbaglan);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            mysqlbaglan.Close();
        }
    }
}
// MySqlCommand komut= new MySqlCommand("delete from müsteri_ekle where müsteri_id=("+id+")",mysqlbaglan);
