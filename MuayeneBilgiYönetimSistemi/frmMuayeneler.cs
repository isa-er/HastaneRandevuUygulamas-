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
    public partial class frmMuayeneler : Form
    {
        public frmMuayeneler()
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

        public void tabloGoster2(string sorgu)
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
                dataGridView2.DataSource = dataTable;
            }
            komut.Dispose();
            baglanti.Close();
        }


       
        private void frmMuayeneler_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txttc.Text=="")
            {
                MessageBox.Show("TC Kimlik No Boş Geçilmez.");
                return;
            }
          
            string tc = txttc.Text;

            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

            komut_ekle.Parameters.AddWithValue("@tc", Convert.ToDouble(txttc.Text));
            komut_ekle.Parameters.AddWithValue("@bulgu", txtbulgular.Text);
            komut_ekle.Parameters.AddWithValue("@teshis", txtteshis.Text);
            komut_ekle.Parameters.AddWithValue("@tedavi", txttedavi.Text);
            

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into muayenedetay  (tc_no,bulgular,teshis, tedavi) values (@tc,@bulgu, @teshis, @tedavi)";


            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView2.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            MessageBox.Show("bulgular eklendi");


            tabloGoster2("SELECT tarihi,concat(hasta_ad,'   ',hasta_soyad) as ad_soyad,concat(hasta_dogum_tarihi,' / ',hasta_dogum_yeri) as dogumyeri_tarihi,bulgular,teshis,tedavi from tblmuayene,muayenedetay,tblhasta where tblmuayene.tc_no=muayenedetay.tc_no and tblhasta.hasta_tc=tblmuayene.tc_no and tblmuayene.tc_no='" + tc + "' ");



            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnrecetegoster_Click(object sender, EventArgs e)
        {


            tabloGoster("delete from ilac1");
            frmRecete recete = new frmRecete();         
            recete.txttc.Text = txttc.Text;         
            recete.Show();               
            this.Hide();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {

            string tc = txttc.Text;
            
            tabloGoster("select hasta_ad,hasta_soyad,tblmuayene.tc_no,hasta_dogum_tarihi,tarihi,sikayeti from tblhasta,tblmuayene   where tblhasta.hasta_tc=tblmuayene.tc_no ");
             //and tblmuayene.tc_no='"+tc+"'
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            tabloGoster2("SELECT tarihi,concat(hasta_ad,'   ',hasta_soyad) as ad_soyad,concat(hasta_dogum_tarihi,' / ',hasta_dogum_yeri) as dogumyeri_tarihi,bulgular,teshis,tedavi from tblmuayene,muayenedetay,tblhasta where tblmuayene.tc_no=muayenedetay.tc_no and tblhasta.hasta_tc=tblmuayene.tc_no ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
