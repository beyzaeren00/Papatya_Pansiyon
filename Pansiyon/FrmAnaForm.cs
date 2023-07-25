using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiriş fr= new FrmAdminGiriş();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMüsteri fr= new FrmYeniMüsteri();    
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr= new FrmOdalar();  
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriler fr= new FrmMüsteriler();
            fr.Show();
        }

        private void btnpersmaaş_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr= new FrmGelirGider();
            fr.Show();
        }
    }
}
