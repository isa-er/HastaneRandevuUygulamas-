
namespace MuayeneBilgiYönetimSistemi
{
    partial class frmMuayeneOlustur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuayeneOlustur));
            this.btnolustur = new System.Windows.Forms.Button();
            this.txtsikayet = new System.Windows.Forms.RichTextBox();
            this.lbltarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblsikayet = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.mskdTCNo = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngoruntule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnolustur
            // 
            this.btnolustur.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnolustur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnolustur.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnolustur.Location = new System.Drawing.Point(15, 295);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(335, 71);
            this.btnolustur.TabIndex = 31;
            this.btnolustur.Text = "RANDEVU OLUŞTUR";
            this.btnolustur.UseVisualStyleBackColor = false;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // txtsikayet
            // 
            this.txtsikayet.Location = new System.Drawing.Point(109, 205);
            this.txtsikayet.Name = "txtsikayet";
            this.txtsikayet.Size = new System.Drawing.Size(253, 66);
            this.txtsikayet.TabIndex = 30;
            this.txtsikayet.Text = "";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarih.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbltarih.Location = new System.Drawing.Point(12, 44);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(176, 28);
            this.lbltarih.TabIndex = 27;
            this.lbltarih.Text = "MUAYENE  TARİHİ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // lblsikayet
            // 
            this.lblsikayet.AutoSize = true;
            this.lblsikayet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsikayet.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblsikayet.Location = new System.Drawing.Point(10, 224);
            this.lblsikayet.Name = "lblsikayet";
            this.lblsikayet.Size = new System.Drawing.Size(93, 28);
            this.lblsikayet.TabIndex = 29;
            this.lblsikayet.Text = "ŞİKAYETİ";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTC.Location = new System.Drawing.Point(9, 133);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(216, 28);
            this.lblTC.TabIndex = 32;
            this.lblTC.Text = "TC KİMLİK NUMARASI:";
            // 
            // mskdTCNo
            // 
            this.mskdTCNo.Location = new System.Drawing.Point(268, 140);
            this.mskdTCNo.Mask = "00000000000";
            this.mskdTCNo.Name = "mskdTCNo";
            this.mskdTCNo.Size = new System.Drawing.Size(111, 22);
            this.mskdTCNo.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 327);
            this.dataGridView1.TabIndex = 36;
            // 
            // btngoruntule
            // 
            this.btngoruntule.BackColor = System.Drawing.Color.DarkOrange;
            this.btngoruntule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngoruntule.Location = new System.Drawing.Point(15, 395);
            this.btngoruntule.Name = "btngoruntule";
            this.btngoruntule.Size = new System.Drawing.Size(335, 67);
            this.btngoruntule.TabIndex = 37;
            this.btngoruntule.Text = "RANDEVU GÖRÜNTÜLE";
            this.btngoruntule.UseVisualStyleBackColor = false;
            this.btngoruntule.Click += new System.EventHandler(this.btngoruntule_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(546, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 67);
            this.button1.TabIndex = 38;
            this.button1.Text = "ANA MENÜ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(888, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 395);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // frmMuayeneOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1282, 496);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngoruntule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.mskdTCNo);
            this.Controls.Add(this.btnolustur);
            this.Controls.Add(this.txtsikayet);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblsikayet);
            this.Name = "frmMuayeneOlustur";
            this.Text = "frmMuayeneOlustur";
            this.Load += new System.EventHandler(this.frmMuayeneOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.RichTextBox txtsikayet;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblsikayet;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.MaskedTextBox mskdTCNo;
        private System.Windows.Forms.Button btngoruntule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}