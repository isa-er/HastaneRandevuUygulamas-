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
    public partial class frmRecete : Form
    {
        public frmRecete()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;" +
                                       "Database=hastane;User Id=postgres;Password=1313");


        public void tabloGoster(string sorgu)
        {
            baglanti.Close();
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

        private void frmRecete_Load(object sender, EventArgs e)
        {
            
        }



        private void btnyazdir_Click(object sender, EventArgs e)
        {
            
            string tc = txttc.Text;
            string ilac1 = comboBox6.Text;
            string ilac2 = comboBox7.Text;
            string ilac3 = comboBox8.Text;
            string ilac4 = comboBox9.Text;


            tabloGoster("select tblhasta.hasta_ad, tblhasta.hasta_tc,tblmuayene.tarihi,muayenedetay.teshis, ilac1.ilac_adi, ilac1.sayisi, ilac2.kategori, ilac2.barkod_no from ilac1, ilac2, tblhasta, tblmuayene, muayenedetay where ilac1.ilac_adi = ilac2.ilac_adi and tblhasta.hasta_tc = tblmuayene.tc_no and tblmuayene.tc_no = muayenedetay.tc_no  and                                    (ilac1.ilac_adi= '" + ilac1 + "'   or ilac1.ilac_adi='" + ilac2 + "'  or  ilac1.ilac_adi='" + ilac3 + "'   or ilac1.ilac_adi='" + ilac4 + "'  )    and tblhasta.hasta_tc = '" + tc + "'");

            comboBox1.Text = "";
            comboBox6.Text = "";
            comboBox2.Text = "";
            comboBox7.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";

        }



        public static int sayac = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

             
            string tc = txttc.Text;
                      
            komut_ekle.Parameters.AddWithValue("@adi", comboBox6.Text);
            komut_ekle.Parameters.AddWithValue("@sayi", Convert.ToInt32(comboBox1.Text));
           
            sayac = Convert.ToInt32(comboBox1.Text);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilac1  (ilac_adi, sayisi ) values (@adi, @sayi)";
            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            baglanti.Close();


            MessageBox.Show(sayac.ToString()+"  adet    "+comboBox6.Text + "  adlı ilaç eklendi.\nKalan hakkınız:"+ (5-sayac).ToString()+"adet ilaç");
            tabloGoster("select  ilac1.ilac_adi,sayisi,kategori,barkod_no from ilac1, ilac2 where ilac1.ilac_adi = ilac2.ilac_adi");    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tc = txttc.Text;           
            tabloGoster2("select hasta_ad,hasta_dogum_tarihi,bulgular,teshis,tedavi from tblhasta,muayenedetay where tblhasta.hasta_tc=muayenedetay.tc_no and muayenedetay.tc_no='" + tc + "'");
            

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;          
            string tc = txttc.Text;


            komut_ekle.Parameters.AddWithValue("@adi", comboBox7.Text);
            komut_ekle.Parameters.AddWithValue("@sayi", Convert.ToInt32(comboBox2.Text));

            sayac += Convert.ToInt32(comboBox2.Text);
            if (sayac>=5)
            {
                comboBox3.Enabled = false;
                label3.Enabled = false;
                comboBox8.Enabled = false;
                btn3.Enabled = false;

                label4.Enabled = false;
                comboBox4.Enabled = false;
                comboBox9.Enabled = false;
                btn4.Enabled = false;

                comboBox5.Enabled = false;
                label5.Enabled = false;
                comboBox10.Enabled = false;
                btn5.Enabled = false;
            }


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilac1  (ilac_adi, sayisi ) values (@adi, @sayi)";
            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            baglanti.Close();


            MessageBox.Show(Convert.ToInt32(comboBox2.Text) + "  adet    " + comboBox7.Text + "  adlı ilaç eklendi.\nKalan hakkınız:" + (5 - sayac).ToString() + "adet ilaç");
            tabloGoster("select  ilac1.ilac_adi,sayisi,kategori,barkod_no from ilac1, ilac2 where ilac1.ilac_adi = ilac2.ilac_adi");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;


            string tc = txttc.Text;

            komut_ekle.Parameters.AddWithValue("@adi", comboBox8.Text);
            komut_ekle.Parameters.AddWithValue("@sayi", Convert.ToInt32(comboBox3.Text));

            sayac += Convert.ToInt32(comboBox3.Text);
            if (sayac >= 5)
            {
                
                comboBox4.Enabled = false;
                label4.Enabled = false;
                comboBox9.Enabled = false;
                btn4.Enabled = false;

                comboBox5.Enabled = false;
                label5.Enabled = false;
                comboBox10.Enabled = false;
                btn5.Enabled = false;
            }



            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilac1  (ilac_adi, sayisi ) values (@adi, @sayi)";
            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            baglanti.Close();


            MessageBox.Show(Convert.ToInt32(comboBox3.Text) +"  adet    " + comboBox8.Text + "  adlı ilaç eklendi.\nKalan hakkınız:" + (5 - sayac).ToString() + "adet ilaç");
            tabloGoster("select  ilac1.ilac_adi,sayisi,kategori,barkod_no from ilac1, ilac2 where ilac1.ilac_adi = ilac2.ilac_adi");


        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAnaSayfa anaSayfa = new frmAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMuayeneler muayeneler = new frmMuayeneler();
            muayeneler.Show();
            this.Hide();
        }
    }
}
