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
    public partial class frmHastaEkle : Form
    {
        public frmHastaEkle()
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



        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

            komut_ekle.Parameters.AddWithValue("@sira", Convert.ToInt32(txtSira.Text));
            komut_ekle.Parameters.AddWithValue("@tc",Convert.ToDouble(mskdTCNo.Text));
            komut_ekle.Parameters.AddWithValue("@adi", txtAd.Text);
            komut_ekle.Parameters.AddWithValue("@soyadi", txtSoyad.Text);
            komut_ekle.Parameters.AddWithValue("@dogumyeri", txtDogumYeri.Text);
            komut_ekle.Parameters.AddWithValue("@dogumtarihi", mskdDogumTarihi.Text);       
            komut_ekle.Parameters.AddWithValue("@medenidurum",label1.Text);
            komut_ekle.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut_ekle.Parameters.AddWithValue("@telefonno", Convert.ToDouble(mskdTelNo.Text));


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into TblHasta  (hasta_id,hasta_tc, hasta_ad, hasta_soyad, hasta_dogum_yeri," +
            "hasta_dogum_tarihi,hasta_medeni_durumu,hasta_adresi,hasta_telefonu) values (@sira," +
            " @tc, @adi, @soyadi, @dogumyeri,@dogumtarihi,@medenidurum,@adres,@telefonno)";

            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            MessageBox.Show(txtAd.Text.ToUpper() +"   "+txtSoyad.Text.ToUpper()+ "    Adlı hasta başarılı bir şekilde eklenmiştir.");

            tabloGoster("select * from tblhasta");
            baglanti.Close();

            txtSira.Text = "";         
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtDogumYeri.Text = "";
            mskdDogumTarihi.Text = "";
            txtAdres.Text = "";
            mskdTelNo.Text = "";

        }

        private void rdErkek_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rdErkek.Text;
        }

        private void rdKadin_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rdKadin.Text;
        }


        private void btnrandevuolustur_Click(object sender, EventArgs e)
        {
            frmMuayeneOlustur muayeneOlustur = new frmMuayeneOlustur();
            muayeneOlustur.Show();
            this.Hide();
           
            muayeneOlustur.mskdTCNo.Text =this.mskdTCNo.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabloGoster("select * from tblhasta");
        }

        private void btnanamenu_Click(object sender, EventArgs e)
        {
            frmAnaSayfa anaSayfa = new frmAnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }

        private void mskdDogumTarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void frmHastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
