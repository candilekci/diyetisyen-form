
namespace Yazilim_Mimarisi_Project
{
    partial class FrmDiyetisyen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHastalik = new System.Windows.Forms.ComboBox();
            this.cmbDiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridHasta = new System.Windows.Forms.DataGridView();
            this.dataGridDiyet = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbGUN = new System.Windows.Forms.ComboBox();
            this.rtxtKahvalti = new System.Windows.Forms.RichTextBox();
            this.rtxtOgle = new System.Windows.Forms.RichTextBox();
            this.rtxtAksam = new System.Windows.Forms.RichTextBox();
            this.lbls = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOgunKaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYeniHastalik = new System.Windows.Forms.TextBox();
            this.txtYeniDiyet = new System.Windows.Forms.TextBox();
            this.btnEkleHastalik = new System.Windows.Forms.Button();
            this.btnEkleDiyet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiyet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblTC);
            this.panel1.Controls.Add(this.lblAdSoyad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 89);
            this.panel1.TabIndex = 0;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(3, 55);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(40, 25);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "TC";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(3, 13);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(142, 25);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "İSİM SOYİSİM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA KAYIT";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(36, 215);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 30);
            this.txtID.TabIndex = 2;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(36, 281);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(137, 30);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(36, 415);
            this.txtTC.Mask = "00000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(137, 30);
            this.txtTC.TabIndex = 3;
            this.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTC.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(36, 348);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(137, 30);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "AD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SOYAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(90, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TC";
            // 
            // cmbHastalik
            // 
            this.cmbHastalik.FormattingEnabled = true;
            this.cmbHastalik.Location = new System.Drawing.Point(36, 484);
            this.cmbHastalik.Name = "cmbHastalik";
            this.cmbHastalik.Size = new System.Drawing.Size(137, 33);
            this.cmbHastalik.TabIndex = 10;
            // 
            // cmbDiyet
            // 
            this.cmbDiyet.FormattingEnabled = true;
            this.cmbDiyet.Location = new System.Drawing.Point(36, 557);
            this.cmbDiyet.Name = "cmbDiyet";
            this.cmbDiyet.Size = new System.Drawing.Size(137, 33);
            this.cmbDiyet.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(67, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "HASTALIK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(74, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "DİYET";
            // 
            // dataGridHasta
            // 
            this.dataGridHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHasta.Location = new System.Drawing.Point(227, 12);
            this.dataGridHasta.Name = "dataGridHasta";
            this.dataGridHasta.RowHeadersWidth = 51;
            this.dataGridHasta.RowTemplate.Height = 24;
            this.dataGridHasta.Size = new System.Drawing.Size(479, 333);
            this.dataGridHasta.TabIndex = 14;
            this.dataGridHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHasta_CellClick);
            // 
            // dataGridDiyet
            // 
            this.dataGridDiyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDiyet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDiyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiyet.Location = new System.Drawing.Point(726, 12);
            this.dataGridDiyet.Name = "dataGridDiyet";
            this.dataGridDiyet.RowHeadersWidth = 51;
            this.dataGridDiyet.RowTemplate.Height = 24;
            this.dataGridDiyet.Size = new System.Drawing.Size(472, 333);
            this.dataGridDiyet.TabIndex = 15;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(20, 626);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(183, 40);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(20, 672);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 43);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(143, 672);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 43);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbGUN
            // 
            this.cmbGUN.FormattingEnabled = true;
            this.cmbGUN.Items.AddRange(new object[] {
            "PAZARTESİ",
            "SALI",
            "ÇARŞAMBA",
            "PERŞEMBE",
            "CUMA",
            "HAFTASONU"});
            this.cmbGUN.Location = new System.Drawing.Point(310, 455);
            this.cmbGUN.Name = "cmbGUN";
            this.cmbGUN.Size = new System.Drawing.Size(158, 33);
            this.cmbGUN.TabIndex = 21;
            // 
            // rtxtKahvalti
            // 
            this.rtxtKahvalti.Location = new System.Drawing.Point(474, 392);
            this.rtxtKahvalti.Name = "rtxtKahvalti";
            this.rtxtKahvalti.Size = new System.Drawing.Size(158, 96);
            this.rtxtKahvalti.TabIndex = 22;
            this.rtxtKahvalti.Text = "";
            // 
            // rtxtOgle
            // 
            this.rtxtOgle.Location = new System.Drawing.Point(673, 392);
            this.rtxtOgle.Name = "rtxtOgle";
            this.rtxtOgle.Size = new System.Drawing.Size(158, 96);
            this.rtxtOgle.TabIndex = 23;
            this.rtxtOgle.Text = "";
            // 
            // rtxtAksam
            // 
            this.rtxtAksam.Location = new System.Drawing.Point(880, 392);
            this.rtxtAksam.Name = "rtxtAksam";
            this.rtxtAksam.Size = new System.Drawing.Size(158, 96);
            this.rtxtAksam.TabIndex = 24;
            this.rtxtAksam.Text = "";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbls.Location = new System.Drawing.Point(508, 369);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(90, 20);
            this.lbls.TabIndex = 25;
            this.lbls.Text = "KAHVALTI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(688, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "ÖĞLE YEMEĞİ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(893, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "AKŞAM YEMEĞİ";
            // 
            // btnOgunKaydet
            // 
            this.btnOgunKaydet.Location = new System.Drawing.Point(596, 525);
            this.btnOgunKaydet.Name = "btnOgunKaydet";
            this.btnOgunKaydet.Size = new System.Drawing.Size(235, 34);
            this.btnOgunKaydet.TabIndex = 28;
            this.btnOgunKaydet.Text = "ÖĞÜNLERİ KAYDET";
            this.btnOgunKaydet.UseVisualStyleBackColor = true;
            this.btnOgunKaydet.Click += new System.EventHandler(this.btnOgunKaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(351, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "GÜNLER";
            // 
            // txtHasta
            // 
            this.txtHasta.Enabled = false;
            this.txtHasta.Location = new System.Drawing.Point(310, 392);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(158, 30);
            this.txtHasta.TabIndex = 31;
            this.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(365, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "HASTA";
            // 
            // txtYeniHastalik
            // 
            this.txtYeniHastalik.Location = new System.Drawing.Point(412, 649);
            this.txtYeniHastalik.Name = "txtYeniHastalik";
            this.txtYeniHastalik.Size = new System.Drawing.Size(137, 30);
            this.txtYeniHastalik.TabIndex = 33;
            this.txtYeniHastalik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYeniDiyet
            // 
            this.txtYeniDiyet.Location = new System.Drawing.Point(828, 648);
            this.txtYeniDiyet.Name = "txtYeniDiyet";
            this.txtYeniDiyet.Size = new System.Drawing.Size(137, 30);
            this.txtYeniDiyet.TabIndex = 34;
            this.txtYeniDiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEkleHastalik
            // 
            this.btnEkleHastalik.Location = new System.Drawing.Point(464, 685);
            this.btnEkleHastalik.Name = "btnEkleHastalik";
            this.btnEkleHastalik.Size = new System.Drawing.Size(85, 35);
            this.btnEkleHastalik.TabIndex = 35;
            this.btnEkleHastalik.Text = "Ekle";
            this.btnEkleHastalik.UseVisualStyleBackColor = true;
            this.btnEkleHastalik.Click += new System.EventHandler(this.btnEkleHastalik_Click);
            // 
            // btnEkleDiyet
            // 
            this.btnEkleDiyet.Location = new System.Drawing.Point(880, 689);
            this.btnEkleDiyet.Name = "btnEkleDiyet";
            this.btnEkleDiyet.Size = new System.Drawing.Size(85, 35);
            this.btnEkleDiyet.TabIndex = 36;
            this.btnEkleDiyet.Text = "Ekle";
            this.btnEkleDiyet.UseVisualStyleBackColor = true;
            this.btnEkleDiyet.Click += new System.EventHandler(this.btnEkleDiyet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(442, 626);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Yeni Hastalık";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(880, 622);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Yeni Diyet";
            // 
            // FrmDiyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 739);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEkleDiyet);
            this.Controls.Add(this.btnEkleHastalik);
            this.Controls.Add(this.txtYeniDiyet);
            this.Controls.Add(this.txtYeniHastalik);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOgunKaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.rtxtAksam);
            this.Controls.Add(this.rtxtOgle);
            this.Controls.Add(this.rtxtKahvalti);
            this.Controls.Add(this.cmbGUN);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridDiyet);
            this.Controls.Add(this.dataGridHasta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDiyet);
            this.Controls.Add(this.cmbHastalik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDiyetisyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DİYETİSYEN PANELİ";
            this.Load += new System.EventHandler(this.FrmDiyetisyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox txtTC;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHastalik;
        private System.Windows.Forms.ComboBox cmbDiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridHasta;
        private System.Windows.Forms.DataGridView dataGridDiyet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbGUN;
        private System.Windows.Forms.RichTextBox rtxtKahvalti;
        private System.Windows.Forms.RichTextBox rtxtOgle;
        private System.Windows.Forms.RichTextBox rtxtAksam;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOgunKaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYeniHastalik;
        private System.Windows.Forms.TextBox txtYeniDiyet;
        private System.Windows.Forms.Button btnEkleHastalik;
        private System.Windows.Forms.Button btnEkleDiyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

