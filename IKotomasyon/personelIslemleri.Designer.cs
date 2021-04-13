namespace IKotomasyon
{
    partial class personelIslemleri
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
            this.txtIseGiris = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtByDepartman = new System.Windows.Forms.TextBox();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.personelID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelTc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelDepartman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtByAdres = new System.Windows.Forms.TextBox();
            this.txtByTelefon = new System.Windows.Forms.TextBox();
            this.txtBySoyadi = new System.Windows.Forms.TextBox();
            this.txtByAdi = new System.Windows.Forms.TextBox();
            this.txtByTCKN = new System.Windows.Forms.TextBox();
            this.txtByID = new System.Windows.Forms.TextBox();
            this.txtSabitMaas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.gbKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.txtIstenCikis = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpIstenCikis = new System.Windows.Forms.DateTimePicker();
            this.cbDurum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIseGiris = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.gbUcretBilgileri = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.personelDogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbKisiBilgileri.SuspendLayout();
            this.gbUcretBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIseGiris
            // 
            this.txtIseGiris.Location = new System.Drawing.Point(151, 42);
            this.txtIseGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIseGiris.Name = "txtIseGiris";
            this.txtIseGiris.Size = new System.Drawing.Size(115, 22);
            this.txtIseGiris.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Sabit Maaş:";
            // 
            // txtByDepartman
            // 
            this.txtByDepartman.Location = new System.Drawing.Point(853, 450);
            this.txtByDepartman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByDepartman.Name = "txtByDepartman";
            this.txtByDepartman.Size = new System.Drawing.Size(92, 22);
            this.txtByDepartman.TabIndex = 48;
            // 
            // lvPersonel
            // 
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personelID,
            this.personelTc,
            this.personelAdi,
            this.personelSoyadi,
            this.personelTel,
            this.personelAdres,
            this.personelDepartman,
            this.personelDurum,
            this.personelDogumTarihi});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.HideSelection = false;
            this.lvPersonel.Location = new System.Drawing.Point(329, 482);
            this.lvPersonel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(723, 224);
            this.lvPersonel.TabIndex = 41;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.SelectedIndexChanged += new System.EventHandler(this.lvPersonel_SelectedIndexChanged);
            // 
            // personelID
            // 
            this.personelID.Text = "ID";
            this.personelID.Width = 28;
            // 
            // personelTc
            // 
            this.personelTc.Text = "TCKN";
            this.personelTc.Width = 74;
            // 
            // personelAdi
            // 
            this.personelAdi.Text = "Adı";
            this.personelAdi.Width = 70;
            // 
            // personelSoyadi
            // 
            this.personelSoyadi.Text = "Soyadı";
            this.personelSoyadi.Width = 77;
            // 
            // personelTel
            // 
            this.personelTel.Text = "Telefon";
            this.personelTel.Width = 63;
            // 
            // personelAdres
            // 
            this.personelAdres.Text = "Adres";
            this.personelAdres.Width = 78;
            // 
            // personelDepartman
            // 
            this.personelDepartman.Text = "Departman";
            this.personelDepartman.Width = 73;
            // 
            // personelDurum
            // 
            this.personelDurum.Text = "Durum";
            this.personelDurum.Width = 75;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(912, 325);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 63);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(743, 325);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 63);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(912, 242);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(141, 63);
            this.btnDegistir.TabIndex = 38;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(743, 242);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(141, 63);
            this.btnYeni.TabIndex = 37;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // txtByAdres
            // 
            this.txtByAdres.Location = new System.Drawing.Point(751, 450);
            this.txtByAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByAdres.Name = "txtByAdres";
            this.txtByAdres.Size = new System.Drawing.Size(97, 22);
            this.txtByAdres.TabIndex = 47;
            // 
            // txtByTelefon
            // 
            this.txtByTelefon.Location = new System.Drawing.Point(671, 450);
            this.txtByTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByTelefon.Name = "txtByTelefon";
            this.txtByTelefon.Size = new System.Drawing.Size(75, 22);
            this.txtByTelefon.TabIndex = 46;
            // 
            // txtBySoyadi
            // 
            this.txtBySoyadi.Location = new System.Drawing.Point(573, 450);
            this.txtBySoyadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBySoyadi.Name = "txtBySoyadi";
            this.txtBySoyadi.Size = new System.Drawing.Size(91, 22);
            this.txtBySoyadi.TabIndex = 45;
            // 
            // txtByAdi
            // 
            this.txtByAdi.Location = new System.Drawing.Point(473, 450);
            this.txtByAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByAdi.Name = "txtByAdi";
            this.txtByAdi.Size = new System.Drawing.Size(93, 22);
            this.txtByAdi.TabIndex = 44;
            // 
            // txtByTCKN
            // 
            this.txtByTCKN.Location = new System.Drawing.Point(371, 450);
            this.txtByTCKN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByTCKN.Name = "txtByTCKN";
            this.txtByTCKN.Size = new System.Drawing.Size(96, 22);
            this.txtByTCKN.TabIndex = 43;
            // 
            // txtByID
            // 
            this.txtByID.Location = new System.Drawing.Point(329, 450);
            this.txtByID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByID.Name = "txtByID";
            this.txtByID.Size = new System.Drawing.Size(36, 22);
            this.txtByID.TabIndex = 42;
            // 
            // txtSabitMaas
            // 
            this.txtSabitMaas.Location = new System.Drawing.Point(151, 107);
            this.txtSabitMaas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSabitMaas.Name = "txtSabitMaas";
            this.txtSabitMaas.Size = new System.Drawing.Size(133, 22);
            this.txtSabitMaas.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 418);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(390, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "* Aşağıdaki arama kutuları ile filtreleme işlemini yapabilirsiniz.";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(151, 74);
            this.txtIBAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(133, 22);
            this.txtIBAN.TabIndex = 23;
            // 
            // gbKisiBilgileri
            // 
            this.gbKisiBilgileri.Controls.Add(this.txtIstenCikis);
            this.gbKisiBilgileri.Controls.Add(this.txtID);
            this.gbKisiBilgileri.Controls.Add(this.label5);
            this.gbKisiBilgileri.Controls.Add(this.dtpIstenCikis);
            this.gbKisiBilgileri.Controls.Add(this.cbDurum);
            this.gbKisiBilgileri.Controls.Add(this.label9);
            this.gbKisiBilgileri.Controls.Add(this.label6);
            this.gbKisiBilgileri.Controls.Add(this.txtDepartman);
            this.gbKisiBilgileri.Controls.Add(this.label7);
            this.gbKisiBilgileri.Controls.Add(this.txtAdres);
            this.gbKisiBilgileri.Controls.Add(this.label8);
            this.gbKisiBilgileri.Controls.Add(this.txtTelefon);
            this.gbKisiBilgileri.Controls.Add(this.label4);
            this.gbKisiBilgileri.Controls.Add(this.txtSoyadi);
            this.gbKisiBilgileri.Controls.Add(this.label3);
            this.gbKisiBilgileri.Controls.Add(this.txtAdi);
            this.gbKisiBilgileri.Controls.Add(this.label2);
            this.gbKisiBilgileri.Controls.Add(this.txtTCKN);
            this.gbKisiBilgileri.Controls.Add(this.label1);
            this.gbKisiBilgileri.Location = new System.Drawing.Point(331, 53);
            this.gbKisiBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKisiBilgileri.Name = "gbKisiBilgileri";
            this.gbKisiBilgileri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKisiBilgileri.Size = new System.Drawing.Size(284, 335);
            this.gbKisiBilgileri.TabIndex = 35;
            this.gbKisiBilgileri.TabStop = false;
            this.gbKisiBilgileri.Text = "Kişi Bilgileri";
            // 
            // txtIstenCikis
            // 
            this.txtIstenCikis.Location = new System.Drawing.Point(143, 299);
            this.txtIstenCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIstenCikis.Name = "txtIstenCikis";
            this.txtIstenCikis.Size = new System.Drawing.Size(112, 22);
            this.txtIstenCikis.TabIndex = 26;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(143, 38);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Personel ID:";
            // 
            // dtpIstenCikis
            // 
            this.dtpIstenCikis.Location = new System.Drawing.Point(252, 299);
            this.dtpIstenCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpIstenCikis.Name = "dtpIstenCikis";
            this.dtpIstenCikis.Size = new System.Drawing.Size(23, 22);
            this.dtpIstenCikis.TabIndex = 23;
            // 
            // cbDurum
            // 
            this.cbDurum.FormattingEnabled = true;
            this.cbDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cbDurum.Location = new System.Drawing.Point(143, 262);
            this.cbDurum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(132, 24);
            this.cbDurum.TabIndex = 22;
            this.cbDurum.Text = "Aktif";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "İşten Çıkış Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durum:";
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(143, 230);
            this.txtDepartman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(132, 22);
            this.txtDepartman.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Departman:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(143, 198);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(132, 22);
            this.txtAdres.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adres:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(143, 166);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(132, 22);
            this.txtTelefon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(143, 134);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(132, 22);
            this.txtSoyadi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(143, 102);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(132, 22);
            this.txtAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı:";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(143, 70);
            this.txtTCKN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(132, 22);
            this.txtTCKN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Kimlik No:";
            // 
            // dtpIseGiris
            // 
            this.dtpIseGiris.Location = new System.Drawing.Point(263, 42);
            this.dtpIseGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpIseGiris.Name = "dtpIseGiris";
            this.dtpIseGiris.Size = new System.Drawing.Size(21, 22);
            this.dtpIseGiris.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "İşe Giriş Tarihi:";
            // 
            // gbUcretBilgileri
            // 
            this.gbUcretBilgileri.Controls.Add(this.txtIseGiris);
            this.gbUcretBilgileri.Controls.Add(this.txtSabitMaas);
            this.gbUcretBilgileri.Controls.Add(this.label11);
            this.gbUcretBilgileri.Controls.Add(this.txtIBAN);
            this.gbUcretBilgileri.Controls.Add(this.label13);
            this.gbUcretBilgileri.Controls.Add(this.dtpIseGiris);
            this.gbUcretBilgileri.Controls.Add(this.label12);
            this.gbUcretBilgileri.Location = new System.Drawing.Point(743, 53);
            this.gbUcretBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUcretBilgileri.Name = "gbUcretBilgileri";
            this.gbUcretBilgileri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUcretBilgileri.Size = new System.Drawing.Size(311, 155);
            this.gbUcretBilgileri.TabIndex = 36;
            this.gbUcretBilgileri.TabStop = false;
            this.gbUcretBilgileri.Text = "Ücret Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "IBAN:";
            // 
            // personelDogumTarihi
            // 
            this.personelDogumTarihi.Text = "Doğum Tarihi";
            // 
            // personelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 746);
            this.Controls.Add(this.txtByDepartman);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtByAdres);
            this.Controls.Add(this.txtByTelefon);
            this.Controls.Add(this.txtBySoyadi);
            this.Controls.Add(this.txtByAdi);
            this.Controls.Add(this.txtByTCKN);
            this.Controls.Add(this.txtByID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbKisiBilgileri);
            this.Controls.Add(this.gbUcretBilgileri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "personelIslemleri";
            this.Text = "personelIslemleri";
            this.gbKisiBilgileri.ResumeLayout(false);
            this.gbKisiBilgileri.PerformLayout();
            this.gbUcretBilgileri.ResumeLayout(false);
            this.gbUcretBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIseGiris;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtByDepartman;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader personelID;
        private System.Windows.Forms.ColumnHeader personelTc;
        private System.Windows.Forms.ColumnHeader personelAdi;
        private System.Windows.Forms.ColumnHeader personelSoyadi;
        private System.Windows.Forms.ColumnHeader personelTel;
        private System.Windows.Forms.ColumnHeader personelAdres;
        private System.Windows.Forms.ColumnHeader personelDepartman;
        private System.Windows.Forms.ColumnHeader personelDurum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtByAdres;
        private System.Windows.Forms.TextBox txtByTelefon;
        private System.Windows.Forms.TextBox txtBySoyadi;
        private System.Windows.Forms.TextBox txtByAdi;
        private System.Windows.Forms.TextBox txtByTCKN;
        private System.Windows.Forms.TextBox txtByID;
        private System.Windows.Forms.TextBox txtSabitMaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.GroupBox gbKisiBilgileri;
        private System.Windows.Forms.TextBox txtIstenCikis;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpIstenCikis;
        private System.Windows.Forms.ComboBox cbDurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIseGiris;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbUcretBilgileri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader personelDogumTarihi;
    }
}