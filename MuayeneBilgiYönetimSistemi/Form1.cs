using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneBilgiYönetimSistemi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            frmMuayeneler muayeneler = new frmMuayeneler();
            muayeneler.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            frmHastaEkle hastaEkle = new frmHastaEkle();
            hastaEkle.Show();
            this.Hide();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
