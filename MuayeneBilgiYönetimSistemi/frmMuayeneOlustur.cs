using Npgsql;
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
    public partial class frmMuayeneOlustur : Form
    {
        public frmMuayeneOlustur()
        {
            InitializeComponent();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;" +
                                      "Database=hastane;User Id=postgres;Password=1313");


        public void tabloGoster(string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = sorgu;
            NpgsqlDataReader dataReader = komut.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut.Dispose();
            baglanti.Close();
        }



        private void btnolustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

            komut_ekle.Parameters.AddWithValue("@tc", Convert.ToDouble(mskdTCNo.Text));
            komut_ekle.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            komut_ekle.Parameters.AddWithValue("@sikayet", txtsikayet.Text);
            

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into tblmuayene  (tc_no,tarihi, sikayeti) values (@tc,@tarih,@sikayet)";

            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            MessageBox.Show(Convert.ToDouble(mskdTCNo.Text)+ "TC no lu hastanın muayenesi eklenmiştir.");

            tabloGoster("select hasta_ad,hasta_soyad,tblmuayene.tc_no,hasta_dogum_tarihi,tarihi,sikayeti from tblhasta,tblmuayene   where tblhasta.hasta_tc=tblmuayene.tc_no");

            baglanti.Close();
            mskdTCNo.Text = "";            
            txtsikayet.Text = "";

        }

        private void btngoruntule_Click(object sender, EventArgs e)
        {
            tabloGoster("select hasta_ad,hasta_soyad,tblmuayene.tc_no,hasta_dogum_tarihi,tarihi,sikayeti from tblhasta,tblmuayene where tblhasta.hasta_tc=tblmuayene.tc_no");
                
                
        }

        private void frmMuayeneOlustur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnaSayfa anaSayfa = new frmAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
