
namespace MuayeneBilgiYönetimSistemi
{
    partial class frmHastaEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaEkle));
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblMedeniDurumu = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.mskdTCNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.mskdDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mskdTelNo = new System.Windows.Forms.MaskedTextBox();
            this.btnrandevuolustur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnanamenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.Crimson;
            this.lblTC.Location = new System.Drawing.Point(7, 86);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(183, 23);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC KİMLİK NUMARASI:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdi.Location = new System.Drawing.Point(6, 122);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(100, 23);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "HASTA ADI:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.ForeColor = System.Drawing.Color.Crimson;
            this.lblSoyadi.Location = new System.Drawing.Point(6, 160);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(128, 23);
            this.lblSoyadi.TabIndex = 2;
            this.lblSoyadi.Text = "HASTA SOYADI";
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumYeri.ForeColor = System.Drawing.Color.Crimson;
            this.lblDogumYeri.Location = new System.Drawing.Point(7, 256);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(112, 23);
            this.lblDogumYeri.TabIndex = 3;
            this.lblDogumYeri.Text = "DOĞUM YERİ";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.ForeColor = System.Drawing.Color.Crimson;
            this.lblDogumTarihi.Location = new System.Drawing.Point(7, 302);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(131, 23);
            this.lblDogumTarihi.TabIndex = 4;
            this.lblDogumTarihi.Text = "DOĞUM TARİHİ";
            // 
            // lblMedeniDurumu
            // 
            this.lblMedeniDurumu.AutoSize = true;
            this.lblMedeniDurumu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMedeniDurumu.ForeColor = System.Drawing.Color.Crimson;
            this.lblMedeniDurumu.Location = new System.Drawing.Point(7, 351);
            this.lblMedeniDurumu.Name = "lblMedeniDurumu";
            this.lblMedeniDurumu.Size = new System.Drawing.Size(149, 23);
            this.lblMedeniDurumu.TabIndex = 5;
            this.lblMedeniDurumu.Text = "MEDENİ DURUMU";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdres.Location = new System.Drawing.Point(5, 418);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(66, 23);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "ADRESİ";
            // 
            // mskdTCNo
            // 
            this.mskdTCNo.Location = new System.Drawing.Point(213, 86);
            this.mskdTCNo.Mask = "00000000000";
            this.mskdTCNo.Name = "mskdTCNo";
            this.mskdTCNo.Size = new System.Drawing.Size(117, 22);
            this.mskdTCNo.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(201, 117);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(117, 22);
            this.txtAd.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(201, 160);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(117, 22);
            this.txtSoyad.TabIndex = 10;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(201, 256);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(117, 22);
            this.txtDogumYeri.TabIndex = 11;
            // 
            // mskdDogumTarihi
            // 
            this.mskdDogumTarihi.Location = new System.Drawing.Point(201, 302);
            this.mskdDogumTarihi.Mask = "00/00/0000";
            this.mskdDogumTarihi.Name = "mskdDogumTarihi";
            this.mskdDogumTarihi.Size = new System.Drawing.Size(117, 22);
            this.mskdDogumTarihi.TabIndex = 12;
            this.mskdDogumTarihi.ValidatingType = typeof(System.DateTime);
            this.mskdDogumTarihi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdDogumTarihi_MaskInputRejected);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(142, 395);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(188, 70);
            this.txtAdres.TabIndex = 16;
            this.txtAdres.Text = "";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Khaki;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(13, 494);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(338, 79);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "HASTAYI EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKadin.Location = new System.Drawing.Point(256, 350);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(74, 24);
            this.rdKadin.TabIndex = 14;
            this.rdKadin.TabStop = true;
            this.rdKadin.Text = "Bekar";
            this.rdKadin.UseVisualStyleBackColor = true;
            this.rdKadin.CheckedChanged += new System.EventHandler(this.rdKadin_CheckedChanged);
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdErkek.Location = new System.Drawing.Point(174, 350);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(57, 24);
            this.rdErkek.TabIndex = 13;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Evli";
            this.rdErkek.UseVisualStyleBackColor = true;
            this.rdErkek.CheckedChanged += new System.EventHandler(this.rdErkek_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNo.ForeColor = System.Drawing.Color.Crimson;
            this.lblNo.Location = new System.Drawing.Point(6, 46);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(80, 23);
            this.lblNo.TabIndex = 20;
            this.lblNo.Text = "SIRA NO:";
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(202, 49);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(117, 22);
            this.txtSira.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 300);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.mskdTelNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAdi);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.lblSoyadi);
            this.groupBox1.Controls.Add(this.lblDogumYeri);
            this.groupBox1.Controls.Add(this.lblDogumTarihi);
            this.groupBox1.Controls.Add(this.txtSira);
            this.groupBox1.Controls.Add(this.lblMedeniDurumu);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.mskdTCNo);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtDogumYeri);
            this.groupBox1.Controls.Add(this.rdKadin);
            this.groupBox1.Controls.Add(this.mskdDogumTarihi);
            this.groupBox1.Controls.Add(this.rdErkek);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 476);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HASTA BİLGİLERİ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.Crimson;
            this.lblTelefon.Location = new System.Drawing.Point(7, 199);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(170, 23);
            this.lblTelefon.TabIndex = 22;
            this.lblTelefon.Text = "TELEFON NUMARASI";
            // 
            // mskdTelNo
            // 
            this.mskdTelNo.Location = new System.Drawing.Point(202, 199);
            this.mskdTelNo.Mask = "00000000000";
            this.mskdTelNo.Name = "mskdTelNo";
            this.mskdTelNo.Size = new System.Drawing.Size(117, 22);
            this.mskdTelNo.TabIndex = 23;
            // 
            // btnrandevuolustur
            // 
            this.btnrandevuolustur.BackColor = System.Drawing.Color.LightBlue;
            this.btnrandevuolustur.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevuolustur.Location = new System.Drawing.Point(815, 354);
            this.btnrandevuolustur.Name = "btnrandevuolustur";
            this.btnrandevuolustur.Size = new System.Drawing.Size(325, 90);
            this.btnrandevuolustur.TabIndex = 27;
            this.btnrandevuolustur.Text = "RANDEVU OLUŞTURMAK İÇİN TIKLAYINIZ";
            this.btnrandevuolustur.UseVisualStyleBackColor = false;
            this.btnrandevuolustur.Click += new System.EventHandler(this.btnrandevuolustur_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(491, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 90);
            this.button1.TabIndex = 28;
            this.button1.Text = "KAYITLI HASTALARI LİSTELE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnanamenu
            // 
            this.btnanamenu.BackColor = System.Drawing.Color.LightBlue;
            this.btnanamenu.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanamenu.Location = new System.Drawing.Point(1146, 354);
            this.btnanamenu.Name = "btnanamenu";
            this.btnanamenu.Size = new System.Drawing.Size(325, 90);
            this.btnanamenu.TabIndex = 29;
            this.btnanamenu.Text = "ANA MENÜYE DÖN";
            this.btnanamenu.UseVisualStyleBackColor = false;
            this.btnanamenu.Click += new System.EventHandler(this.btnanamenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(357, 509);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // frmHastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1667, 585);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnanamenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrandevuolustur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Name = "frmHastaEkle";
            this.Text = "frmHastaEkle";
            this.Load += new System.EventHandler(this.frmHastaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblMedeniDurumu;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox mskdTelNo;
        private System.Windows.Forms.Button btnrandevuolustur;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MaskedTextBox mskdTCNo;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.MaskedTextBox mskdDogumTarihi;
        private System.Windows.Forms.Button btnanamenu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}