namespace EmlakProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            headerTitle = new Label();
            navBarPanel = new Panel();
            menuLabel = new Label();
            satilikEvlerPanel = new Panel();
            satilikEvlerLabel = new Label();
            kiralikEvlerPanel = new Panel();
            kiralikEvlerLabel = new Label();
            yeniSorguPanel = new Panel();
            yeniSorguLabel = new Label();
            yeniEvKayitPanel = new Panel();
            yeniEvKayitLabel = new Label();
            yeniKayitSayfasi = new Panel();
            button2 = new Button();
            button1 = new Button();
            kayitOlusturButton = new Button();
            label12 = new Label();
            evTuruComboBox = new ComboBox();
            getiriYuzdesiNumeric = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            evCesidiComboBox = new ComboBox();
            label9 = new Label();
            emlakNumarasiNumeric = new NumericUpDown();
            label8 = new Label();
            yapimYiliNumeric = new NumericUpDown();
            label7 = new Label();
            evAlaniTextBox = new TextBox();
            label6 = new Label();
            semtComboBox = new ComboBox();
            label5 = new Label();
            ilceComboBox = new ComboBox();
            label4 = new Label();
            katNumarasiSeciciNumeric = new NumericUpDown();
            label3 = new Label();
            odaSayisiSeciciNumeric = new NumericUpDown();
            label2 = new Label();
            kiralikEvlerSayfasi = new Panel();
            button4 = new Button();
            label1 = new Label();
            kiralikEvlerListePanel = new Panel();
            ayrintiSayfasi = new Panel();
            label13 = new Label();
            ayrintiSayfasiPanel = new Panel();
            duzenlemeSayfasi = new Panel();
            button3 = new Button();
            label14 = new Label();
            duzenlemeSayfasiPanel = new Panel();
            label25 = new Label();
            duzenleAktiflikBox = new ComboBox();
            duzenlemeKaydetButton = new Button();
            label15 = new Label();
            duzenleEvTuruBox = new ComboBox();
            duzenleGetiriYuzdesiBox = new NumericUpDown();
            label16 = new Label();
            label17 = new Label();
            duzenleEvCesidiBox = new ComboBox();
            label18 = new Label();
            duzenleEmlakNumarasiBox = new NumericUpDown();
            label19 = new Label();
            duzenleYapimYiliBox = new NumericUpDown();
            label20 = new Label();
            duzenleEvAlaniBox = new TextBox();
            label21 = new Label();
            duzenleSemtBox = new ComboBox();
            label22 = new Label();
            duzenleIlceBox = new ComboBox();
            label23 = new Label();
            duzenleKatNumarasiBox = new NumericUpDown();
            label24 = new Label();
            duzenleOdaSayisiBox = new NumericUpDown();
            hosGeldinizSayfasi = new Panel();
            hosGeldinizLabel = new Label();
            panel2 = new Panel();
            headerPanel.SuspendLayout();
            navBarPanel.SuspendLayout();
            satilikEvlerPanel.SuspendLayout();
            kiralikEvlerPanel.SuspendLayout();
            yeniSorguPanel.SuspendLayout();
            yeniEvKayitPanel.SuspendLayout();
            yeniKayitSayfasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)getiriYuzdesiNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emlakNumarasiNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yapimYiliNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)katNumarasiSeciciNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)odaSayisiSeciciNumeric).BeginInit();
            kiralikEvlerSayfasi.SuspendLayout();
            ayrintiSayfasi.SuspendLayout();
            duzenlemeSayfasi.SuspendLayout();
            duzenlemeSayfasiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)duzenleGetiriYuzdesiBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duzenleEmlakNumarasiBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duzenleYapimYiliBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duzenleKatNumarasiBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duzenleOdaSayisiBox).BeginInit();
            hosGeldinizSayfasi.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.SteelBlue;
            headerPanel.Controls.Add(headerTitle);
            headerPanel.Location = new Point(12, 12);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1148, 67);
            headerPanel.TabIndex = 0;
            // 
            // headerTitle
            // 
            headerTitle.AutoSize = true;
            headerTitle.BackColor = Color.SteelBlue;
            headerTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            headerTitle.ForeColor = Color.White;
            headerTitle.Location = new Point(469, 9);
            headerTitle.Name = "headerTitle";
            headerTitle.Size = new Size(272, 46);
            headerTitle.TabIndex = 0;
            headerTitle.Text = "I Ş I K   E M L A K";
            headerTitle.Click += headerTitle_Click;
            // 
            // navBarPanel
            // 
            navBarPanel.BackColor = Color.MediumSeaGreen;
            navBarPanel.Controls.Add(menuLabel);
            navBarPanel.Controls.Add(satilikEvlerPanel);
            navBarPanel.Controls.Add(kiralikEvlerPanel);
            navBarPanel.Controls.Add(yeniSorguPanel);
            navBarPanel.Controls.Add(yeniEvKayitPanel);
            navBarPanel.Location = new Point(12, 85);
            navBarPanel.Name = "navBarPanel";
            navBarPanel.Size = new Size(150, 500);
            navBarPanel.TabIndex = 1;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.ForeColor = Color.White;
            menuLabel.Location = new Point(52, 20);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(51, 20);
            menuLabel.TabIndex = 2;
            menuLabel.Text = "MENÜ";
            // 
            // satilikEvlerPanel
            // 
            satilikEvlerPanel.BackColor = Color.SeaGreen;
            satilikEvlerPanel.Controls.Add(satilikEvlerLabel);
            satilikEvlerPanel.Location = new Point(14, 196);
            satilikEvlerPanel.Name = "satilikEvlerPanel";
            satilikEvlerPanel.Size = new Size(122, 29);
            satilikEvlerPanel.TabIndex = 1;
            // 
            // satilikEvlerLabel
            // 
            satilikEvlerLabel.AutoSize = true;
            satilikEvlerLabel.ForeColor = Color.White;
            satilikEvlerLabel.Location = new Point(16, 4);
            satilikEvlerLabel.Name = "satilikEvlerLabel";
            satilikEvlerLabel.Size = new Size(85, 20);
            satilikEvlerLabel.TabIndex = 0;
            satilikEvlerLabel.Text = "Satılık Evler";
            // 
            // kiralikEvlerPanel
            // 
            kiralikEvlerPanel.BackColor = Color.SeaGreen;
            kiralikEvlerPanel.Controls.Add(kiralikEvlerLabel);
            kiralikEvlerPanel.Location = new Point(14, 151);
            kiralikEvlerPanel.Name = "kiralikEvlerPanel";
            kiralikEvlerPanel.Size = new Size(122, 29);
            kiralikEvlerPanel.TabIndex = 1;
            // 
            // kiralikEvlerLabel
            // 
            kiralikEvlerLabel.AutoSize = true;
            kiralikEvlerLabel.ForeColor = Color.White;
            kiralikEvlerLabel.Location = new Point(16, 4);
            kiralikEvlerLabel.Name = "kiralikEvlerLabel";
            kiralikEvlerLabel.Size = new Size(86, 20);
            kiralikEvlerLabel.TabIndex = 0;
            kiralikEvlerLabel.Text = "Kiralık Evler";
            kiralikEvlerLabel.Click += kiralikEvlerLabel_Click;
            // 
            // yeniSorguPanel
            // 
            yeniSorguPanel.BackColor = Color.SeaGreen;
            yeniSorguPanel.Controls.Add(yeniSorguLabel);
            yeniSorguPanel.Location = new Point(14, 107);
            yeniSorguPanel.Name = "yeniSorguPanel";
            yeniSorguPanel.Size = new Size(122, 29);
            yeniSorguPanel.TabIndex = 1;
            // 
            // yeniSorguLabel
            // 
            yeniSorguLabel.AutoSize = true;
            yeniSorguLabel.ForeColor = Color.White;
            yeniSorguLabel.Location = new Point(20, 4);
            yeniSorguLabel.Name = "yeniSorguLabel";
            yeniSorguLabel.Size = new Size(79, 20);
            yeniSorguLabel.TabIndex = 0;
            yeniSorguLabel.Text = "Yeni Sorgu";
            yeniSorguLabel.Click += yeniSorguLabel_Click;
            // 
            // yeniEvKayitPanel
            // 
            yeniEvKayitPanel.BackColor = Color.SeaGreen;
            yeniEvKayitPanel.Controls.Add(yeniEvKayitLabel);
            yeniEvKayitPanel.Location = new Point(14, 63);
            yeniEvKayitPanel.Name = "yeniEvKayitPanel";
            yeniEvKayitPanel.Size = new Size(122, 29);
            yeniEvKayitPanel.TabIndex = 0;
            // 
            // yeniEvKayitLabel
            // 
            yeniEvKayitLabel.AutoSize = true;
            yeniEvKayitLabel.ForeColor = Color.White;
            yeniEvKayitLabel.Location = new Point(16, 4);
            yeniEvKayitLabel.Name = "yeniEvKayitLabel";
            yeniEvKayitLabel.Size = new Size(92, 20);
            yeniEvKayitLabel.TabIndex = 0;
            yeniEvKayitLabel.Text = "Yeni Ev Kayıt";
            yeniEvKayitLabel.Click += yeniEvKayitLabel_Click;
            // 
            // yeniKayitSayfasi
            // 
            yeniKayitSayfasi.BackColor = Color.Gray;
            yeniKayitSayfasi.Controls.Add(button2);
            yeniKayitSayfasi.Controls.Add(button1);
            yeniKayitSayfasi.Controls.Add(kayitOlusturButton);
            yeniKayitSayfasi.Controls.Add(label12);
            yeniKayitSayfasi.Controls.Add(evTuruComboBox);
            yeniKayitSayfasi.Controls.Add(getiriYuzdesiNumeric);
            yeniKayitSayfasi.Controls.Add(label11);
            yeniKayitSayfasi.Controls.Add(label10);
            yeniKayitSayfasi.Controls.Add(evCesidiComboBox);
            yeniKayitSayfasi.Controls.Add(label9);
            yeniKayitSayfasi.Controls.Add(emlakNumarasiNumeric);
            yeniKayitSayfasi.Controls.Add(label8);
            yeniKayitSayfasi.Controls.Add(yapimYiliNumeric);
            yeniKayitSayfasi.Controls.Add(label7);
            yeniKayitSayfasi.Controls.Add(evAlaniTextBox);
            yeniKayitSayfasi.Controls.Add(label6);
            yeniKayitSayfasi.Controls.Add(semtComboBox);
            yeniKayitSayfasi.Controls.Add(label5);
            yeniKayitSayfasi.Controls.Add(ilceComboBox);
            yeniKayitSayfasi.Controls.Add(label4);
            yeniKayitSayfasi.Controls.Add(katNumarasiSeciciNumeric);
            yeniKayitSayfasi.Controls.Add(label3);
            yeniKayitSayfasi.Controls.Add(odaSayisiSeciciNumeric);
            yeniKayitSayfasi.Controls.Add(label2);
            yeniKayitSayfasi.Location = new Point(168, 85);
            yeniKayitSayfasi.Name = "yeniKayitSayfasi";
            yeniKayitSayfasi.Size = new Size(992, 656);
            yeniKayitSayfasi.TabIndex = 2;
            yeniKayitSayfasi.Paint += yeniKayitSayfasi_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(37, 379);
            button2.Name = "button2";
            button2.Size = new Size(192, 29);
            button2.TabIndex = 24;
            button2.Text = "read records";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 306);
            button1.Name = "button1";
            button1.Size = new Size(192, 29);
            button1.TabIndex = 23;
            button1.Text = "show record count";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // kayitOlusturButton
            // 
            kayitOlusturButton.BackColor = Color.SteelBlue;
            kayitOlusturButton.ForeColor = Color.White;
            kayitOlusturButton.Location = new Point(401, 500);
            kayitOlusturButton.Name = "kayitOlusturButton";
            kayitOlusturButton.Size = new Size(151, 29);
            kayitOlusturButton.TabIndex = 22;
            kayitOlusturButton.Text = "Kayıdı Oluştur";
            kayitOlusturButton.UseVisualStyleBackColor = false;
            kayitOlusturButton.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(543, 388);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 21;
            label12.Text = "Ev Türü:";
            // 
            // evTuruComboBox
            // 
            evTuruComboBox.FormattingEnabled = true;
            evTuruComboBox.Items.AddRange(new object[] { "Kiralık", "Satılık" });
            evTuruComboBox.Location = new Point(543, 411);
            evTuruComboBox.Name = "evTuruComboBox";
            evTuruComboBox.Size = new Size(151, 28);
            evTuruComboBox.TabIndex = 20;
            // 
            // getiriYuzdesiNumeric
            // 
            getiriYuzdesiNumeric.Location = new Point(263, 411);
            getiriYuzdesiNumeric.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            getiriYuzdesiNumeric.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            getiriYuzdesiNumeric.Name = "getiriYuzdesiNumeric";
            getiriYuzdesiNumeric.Size = new Size(150, 27);
            getiriYuzdesiNumeric.TabIndex = 19;
            getiriYuzdesiNumeric.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(263, 388);
            label11.Name = "label11";
            label11.Size = new Size(102, 20);
            label11.TabIndex = 18;
            label11.Text = "Getiri Yüzdesi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(543, 315);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 16;
            label10.Text = "Ev Çeşidi:";
            // 
            // evCesidiComboBox
            // 
            evCesidiComboBox.FormattingEnabled = true;
            evCesidiComboBox.Items.AddRange(new object[] { "Daire", "Bahçeli", "Müstakil", "Dubleks", "Stüdyo", "Belirtilmemiş" });
            evCesidiComboBox.Location = new Point(543, 338);
            evCesidiComboBox.Name = "evCesidiComboBox";
            evCesidiComboBox.Size = new Size(151, 28);
            evCesidiComboBox.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(543, 248);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 14;
            label9.Text = "Emlak Numarasi:";
            label9.Click += label9_Click;
            // 
            // emlakNumarasiNumeric
            // 
            emlakNumarasiNumeric.Location = new Point(543, 271);
            emlakNumarasiNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            emlakNumarasiNumeric.Minimum = new decimal(new int[] { 100001, 0, 0, 0 });
            emlakNumarasiNumeric.Name = "emlakNumarasiNumeric";
            emlakNumarasiNumeric.Size = new Size(150, 27);
            emlakNumarasiNumeric.TabIndex = 13;
            emlakNumarasiNumeric.Value = new decimal(new int[] { 100001, 0, 0, 0 });
            emlakNumarasiNumeric.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(543, 180);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 12;
            label8.Text = "Yapim Yılı:";
            // 
            // yapimYiliNumeric
            // 
            yapimYiliNumeric.Location = new Point(543, 203);
            yapimYiliNumeric.Maximum = new decimal(new int[] { 2040, 0, 0, 0 });
            yapimYiliNumeric.Minimum = new decimal(new int[] { 1850, 0, 0, 0 });
            yapimYiliNumeric.Name = "yapimYiliNumeric";
            yapimYiliNumeric.Size = new Size(150, 27);
            yapimYiliNumeric.TabIndex = 11;
            yapimYiliNumeric.Value = new decimal(new int[] { 1850, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(543, 116);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 10;
            label7.Text = "Evin Alanı:";
            // 
            // evAlaniTextBox
            // 
            evAlaniTextBox.Location = new Point(543, 139);
            evAlaniTextBox.Name = "evAlaniTextBox";
            evAlaniTextBox.Size = new Size(150, 27);
            evAlaniTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(263, 315);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 8;
            label6.Text = "Semt:";
            // 
            // semtComboBox
            // 
            semtComboBox.FormattingEnabled = true;
            semtComboBox.Location = new Point(263, 338);
            semtComboBox.Name = "semtComboBox";
            semtComboBox.Size = new Size(151, 28);
            semtComboBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(263, 248);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 6;
            label5.Text = "İlçe:";
            // 
            // ilceComboBox
            // 
            ilceComboBox.FormattingEnabled = true;
            ilceComboBox.Items.AddRange(new object[] { "Fatih", "Beşiktaş", "Beyoğlu", "Üsküdar", "Kadıköy", "Sarıyer", "Şişli", "Zeytinburnu", "Eyüpsultan", "Bakırköy", "Kağıthane", "Maltepe", "Bayrampaşa", "Gaziosmanpaşa", "Sultangazi", "Bahçelievler", "Pendik", "Kartal" });
            ilceComboBox.Location = new Point(263, 271);
            ilceComboBox.Name = "ilceComboBox";
            ilceComboBox.Size = new Size(151, 28);
            ilceComboBox.TabIndex = 5;
            ilceComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(263, 180);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 4;
            label4.Text = "Kat Numarasi:";
            label4.Click += label4_Click;
            // 
            // katNumarasiSeciciNumeric
            // 
            katNumarasiSeciciNumeric.Location = new Point(263, 203);
            katNumarasiSeciciNumeric.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            katNumarasiSeciciNumeric.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            katNumarasiSeciciNumeric.Name = "katNumarasiSeciciNumeric";
            katNumarasiSeciciNumeric.Size = new Size(150, 27);
            katNumarasiSeciciNumeric.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(263, 116);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Oda Sayısı:";
            // 
            // odaSayisiSeciciNumeric
            // 
            odaSayisiSeciciNumeric.Location = new Point(263, 139);
            odaSayisiSeciciNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            odaSayisiSeciciNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            odaSayisiSeciciNumeric.Name = "odaSayisiSeciciNumeric";
            odaSayisiSeciciNumeric.Size = new Size(150, 27);
            odaSayisiSeciciNumeric.TabIndex = 1;
            odaSayisiSeciciNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(313, 20);
            label2.Name = "label2";
            label2.Size = new Size(340, 46);
            label2.TabIndex = 0;
            label2.Text = "Yeni Ev Kayıdı Oluştur";
            // 
            // kiralikEvlerSayfasi
            // 
            kiralikEvlerSayfasi.BackColor = Color.RosyBrown;
            kiralikEvlerSayfasi.Controls.Add(button4);
            kiralikEvlerSayfasi.Controls.Add(label1);
            kiralikEvlerSayfasi.Controls.Add(kiralikEvlerListePanel);
            kiralikEvlerSayfasi.Location = new Point(168, 85);
            kiralikEvlerSayfasi.Name = "kiralikEvlerSayfasi";
            kiralikEvlerSayfasi.Size = new Size(992, 656);
            kiralikEvlerSayfasi.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(16, 72);
            button4.Name = "button4";
            button4.Size = new Size(247, 29);
            button4.TabIndex = 26;
            button4.Text = "Aktif Olmayanları Göster";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(395, 20);
            label1.Name = "label1";
            label1.Size = new Size(190, 46);
            label1.TabIndex = 25;
            label1.Text = "Kiralık Evler";
            // 
            // kiralikEvlerListePanel
            // 
            kiralikEvlerListePanel.BackColor = Color.Gainsboro;
            kiralikEvlerListePanel.Location = new Point(16, 107);
            kiralikEvlerListePanel.Name = "kiralikEvlerListePanel";
            kiralikEvlerListePanel.Size = new Size(960, 474);
            kiralikEvlerListePanel.TabIndex = 0;
            // 
            // ayrintiSayfasi
            // 
            ayrintiSayfasi.BackColor = Color.Tan;
            ayrintiSayfasi.Controls.Add(label13);
            ayrintiSayfasi.Controls.Add(ayrintiSayfasiPanel);
            ayrintiSayfasi.Location = new Point(168, 85);
            ayrintiSayfasi.Name = "ayrintiSayfasi";
            ayrintiSayfasi.Size = new Size(992, 656);
            ayrintiSayfasi.TabIndex = 26;
            ayrintiSayfasi.Paint += ayrintiSayfasi_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(338, 20);
            label13.Name = "label13";
            label13.Size = new Size(282, 46);
            label13.TabIndex = 25;
            label13.Text = "Ayrıntılı Görünüm";
            // 
            // ayrintiSayfasiPanel
            // 
            ayrintiSayfasiPanel.BackColor = Color.Gainsboro;
            ayrintiSayfasiPanel.Location = new Point(16, 107);
            ayrintiSayfasiPanel.Name = "ayrintiSayfasiPanel";
            ayrintiSayfasiPanel.Size = new Size(960, 474);
            ayrintiSayfasiPanel.TabIndex = 0;
            // 
            // duzenlemeSayfasi
            // 
            duzenlemeSayfasi.BackColor = Color.DarkSeaGreen;
            duzenlemeSayfasi.Controls.Add(button3);
            duzenlemeSayfasi.Controls.Add(label14);
            duzenlemeSayfasi.Controls.Add(duzenlemeSayfasiPanel);
            duzenlemeSayfasi.Location = new Point(168, 85);
            duzenlemeSayfasi.Name = "duzenlemeSayfasi";
            duzenlemeSayfasi.Size = new Size(992, 656);
            duzenlemeSayfasi.TabIndex = 27;
            // 
            // button3
            // 
            button3.Location = new Point(16, 72);
            button3.Name = "button3";
            button3.Size = new Size(181, 29);
            button3.TabIndex = 26;
            button3.Text = "Ayrıntılara Geri Dön";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(338, 20);
            label14.Name = "label14";
            label14.Size = new Size(298, 46);
            label14.TabIndex = 25;
            label14.Text = "Düzenleme Sayfası";
            // 
            // duzenlemeSayfasiPanel
            // 
            duzenlemeSayfasiPanel.BackColor = Color.Gainsboro;
            duzenlemeSayfasiPanel.Controls.Add(label25);
            duzenlemeSayfasiPanel.Controls.Add(duzenleAktiflikBox);
            duzenlemeSayfasiPanel.Controls.Add(duzenlemeKaydetButton);
            duzenlemeSayfasiPanel.Controls.Add(label15);
            duzenlemeSayfasiPanel.Controls.Add(duzenleEvTuruBox);
            duzenlemeSayfasiPanel.Controls.Add(duzenleGetiriYuzdesiBox);
            duzenlemeSayfasiPanel.Controls.Add(label16);
            duzenlemeSayfasiPanel.Controls.Add(label17);
            duzenlemeSayfasiPanel.Controls.Add(duzenleEvCesidiBox);
            duzenlemeSayfasiPanel.Controls.Add(label18);
            duzenlemeSayfasiPanel.Controls.Add(duzenleEmlakNumarasiBox);
            duzenlemeSayfasiPanel.Controls.Add(label19);
            duzenlemeSayfasiPanel.Controls.Add(duzenleYapimYiliBox);
            duzenlemeSayfasiPanel.Controls.Add(label20);
            duzenlemeSayfasiPanel.Controls.Add(duzenleEvAlaniBox);
            duzenlemeSayfasiPanel.Controls.Add(label21);
            duzenlemeSayfasiPanel.Controls.Add(duzenleSemtBox);
            duzenlemeSayfasiPanel.Controls.Add(label22);
            duzenlemeSayfasiPanel.Controls.Add(duzenleIlceBox);
            duzenlemeSayfasiPanel.Controls.Add(label23);
            duzenlemeSayfasiPanel.Controls.Add(duzenleKatNumarasiBox);
            duzenlemeSayfasiPanel.Controls.Add(label24);
            duzenlemeSayfasiPanel.Controls.Add(duzenleOdaSayisiBox);
            duzenlemeSayfasiPanel.Location = new Point(16, 107);
            duzenlemeSayfasiPanel.Name = "duzenlemeSayfasiPanel";
            duzenlemeSayfasiPanel.Size = new Size(960, 474);
            duzenlemeSayfasiPanel.TabIndex = 0;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Black;
            label25.Location = new Point(667, 32);
            label25.Name = "label25";
            label25.Size = new Size(115, 20);
            label25.TabIndex = 45;
            label25.Text = "Aktiflik Durumu:";
            // 
            // duzenleAktiflikBox
            // 
            duzenleAktiflikBox.FormattingEnabled = true;
            duzenleAktiflikBox.Items.AddRange(new object[] { "Aktif", "Aktif değil" });
            duzenleAktiflikBox.Location = new Point(667, 55);
            duzenleAktiflikBox.Name = "duzenleAktiflikBox";
            duzenleAktiflikBox.Size = new Size(151, 28);
            duzenleAktiflikBox.TabIndex = 44;
            // 
            // duzenlemeKaydetButton
            // 
            duzenlemeKaydetButton.BackColor = Color.SteelBlue;
            duzenlemeKaydetButton.ForeColor = Color.White;
            duzenlemeKaydetButton.Location = new Point(403, 415);
            duzenlemeKaydetButton.Name = "duzenlemeKaydetButton";
            duzenlemeKaydetButton.Size = new Size(151, 29);
            duzenlemeKaydetButton.TabIndex = 43;
            duzenlemeKaydetButton.Text = "Kaydet";
            duzenlemeKaydetButton.UseVisualStyleBackColor = false;
            duzenlemeKaydetButton.Click += duzenlemeKaydetButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(402, 304);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 42;
            label15.Text = "Ev Türü:";
            // 
            // duzenleEvTuruBox
            // 
            duzenleEvTuruBox.Enabled = false;
            duzenleEvTuruBox.FormattingEnabled = true;
            duzenleEvTuruBox.Items.AddRange(new object[] { "Kiralık", "Satılık" });
            duzenleEvTuruBox.Location = new Point(402, 327);
            duzenleEvTuruBox.Name = "duzenleEvTuruBox";
            duzenleEvTuruBox.Size = new Size(151, 28);
            duzenleEvTuruBox.TabIndex = 41;
            // 
            // duzenleGetiriYuzdesiBox
            // 
            duzenleGetiriYuzdesiBox.Location = new Point(122, 327);
            duzenleGetiriYuzdesiBox.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            duzenleGetiriYuzdesiBox.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            duzenleGetiriYuzdesiBox.Name = "duzenleGetiriYuzdesiBox";
            duzenleGetiriYuzdesiBox.Size = new Size(150, 27);
            duzenleGetiriYuzdesiBox.TabIndex = 40;
            duzenleGetiriYuzdesiBox.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(122, 304);
            label16.Name = "label16";
            label16.Size = new Size(102, 20);
            label16.TabIndex = 39;
            label16.Text = "Getiri Yüzdesi:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Black;
            label17.Location = new Point(402, 231);
            label17.Name = "label17";
            label17.Size = new Size(71, 20);
            label17.TabIndex = 38;
            label17.Text = "Ev Çeşidi:";
            // 
            // duzenleEvCesidiBox
            // 
            duzenleEvCesidiBox.FormattingEnabled = true;
            duzenleEvCesidiBox.Items.AddRange(new object[] { "Daire", "Bahçeli", "Müstakil", "Dubleks", "Stüdyo", "Belirtilmemiş" });
            duzenleEvCesidiBox.Location = new Point(402, 254);
            duzenleEvCesidiBox.Name = "duzenleEvCesidiBox";
            duzenleEvCesidiBox.Size = new Size(151, 28);
            duzenleEvCesidiBox.TabIndex = 37;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Black;
            label18.Location = new Point(402, 164);
            label18.Name = "label18";
            label18.Size = new Size(119, 20);
            label18.TabIndex = 36;
            label18.Text = "Emlak Numarasi:";
            // 
            // duzenleEmlakNumarasiBox
            // 
            duzenleEmlakNumarasiBox.Enabled = false;
            duzenleEmlakNumarasiBox.Location = new Point(402, 187);
            duzenleEmlakNumarasiBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            duzenleEmlakNumarasiBox.Minimum = new decimal(new int[] { 100001, 0, 0, 0 });
            duzenleEmlakNumarasiBox.Name = "duzenleEmlakNumarasiBox";
            duzenleEmlakNumarasiBox.Size = new Size(150, 27);
            duzenleEmlakNumarasiBox.TabIndex = 35;
            duzenleEmlakNumarasiBox.Value = new decimal(new int[] { 100001, 0, 0, 0 });
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Black;
            label19.Location = new Point(402, 96);
            label19.Name = "label19";
            label19.Size = new Size(77, 20);
            label19.TabIndex = 34;
            label19.Text = "Yapim Yılı:";
            // 
            // duzenleYapimYiliBox
            // 
            duzenleYapimYiliBox.Location = new Point(402, 119);
            duzenleYapimYiliBox.Maximum = new decimal(new int[] { 2040, 0, 0, 0 });
            duzenleYapimYiliBox.Minimum = new decimal(new int[] { 1850, 0, 0, 0 });
            duzenleYapimYiliBox.Name = "duzenleYapimYiliBox";
            duzenleYapimYiliBox.Size = new Size(150, 27);
            duzenleYapimYiliBox.TabIndex = 33;
            duzenleYapimYiliBox.Value = new decimal(new int[] { 1850, 0, 0, 0 });
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Black;
            label20.Location = new Point(402, 32);
            label20.Name = "label20";
            label20.Size = new Size(77, 20);
            label20.TabIndex = 32;
            label20.Text = "Evin Alanı:";
            // 
            // duzenleEvAlaniBox
            // 
            duzenleEvAlaniBox.Location = new Point(402, 55);
            duzenleEvAlaniBox.Name = "duzenleEvAlaniBox";
            duzenleEvAlaniBox.Size = new Size(150, 27);
            duzenleEvAlaniBox.TabIndex = 31;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Black;
            label21.Location = new Point(122, 231);
            label21.Name = "label21";
            label21.Size = new Size(46, 20);
            label21.TabIndex = 30;
            label21.Text = "Semt:";
            // 
            // duzenleSemtBox
            // 
            duzenleSemtBox.FormattingEnabled = true;
            duzenleSemtBox.Location = new Point(122, 254);
            duzenleSemtBox.Name = "duzenleSemtBox";
            duzenleSemtBox.Size = new Size(151, 28);
            duzenleSemtBox.TabIndex = 29;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Black;
            label22.Location = new Point(122, 164);
            label22.Name = "label22";
            label22.Size = new Size(35, 20);
            label22.TabIndex = 28;
            label22.Text = "İlçe:";
            // 
            // duzenleIlceBox
            // 
            duzenleIlceBox.FormattingEnabled = true;
            duzenleIlceBox.Items.AddRange(new object[] { "Fatih", "Beşiktaş", "Beyoğlu", "Üsküdar", "Kadıköy", "Sarıyer", "Şişli", "Zeytinburnu", "Eyüpsultan", "Bakırköy", "Kağıthane", "Maltepe", "Bayrampaşa", "Gaziosmanpaşa", "Sultangazi", "Bahçelievler", "Pendik", "Kartal" });
            duzenleIlceBox.Location = new Point(122, 187);
            duzenleIlceBox.Name = "duzenleIlceBox";
            duzenleIlceBox.Size = new Size(151, 28);
            duzenleIlceBox.TabIndex = 27;
            duzenleIlceBox.SelectedIndexChanged += duzenleIlceBox_SelectedIndexChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Black;
            label23.Location = new Point(122, 96);
            label23.Name = "label23";
            label23.Size = new Size(101, 20);
            label23.TabIndex = 26;
            label23.Text = "Kat Numarasi:";
            // 
            // duzenleKatNumarasiBox
            // 
            duzenleKatNumarasiBox.Location = new Point(122, 119);
            duzenleKatNumarasiBox.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            duzenleKatNumarasiBox.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            duzenleKatNumarasiBox.Name = "duzenleKatNumarasiBox";
            duzenleKatNumarasiBox.Size = new Size(150, 27);
            duzenleKatNumarasiBox.TabIndex = 25;
            duzenleKatNumarasiBox.ValueChanged += duzenleKatNumarasiBox_ValueChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.Black;
            label24.Location = new Point(122, 32);
            label24.Name = "label24";
            label24.Size = new Size(81, 20);
            label24.TabIndex = 24;
            label24.Text = "Oda Sayısı:";
            // 
            // duzenleOdaSayisiBox
            // 
            duzenleOdaSayisiBox.Location = new Point(122, 55);
            duzenleOdaSayisiBox.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            duzenleOdaSayisiBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            duzenleOdaSayisiBox.Name = "duzenleOdaSayisiBox";
            duzenleOdaSayisiBox.Size = new Size(150, 27);
            duzenleOdaSayisiBox.TabIndex = 23;
            duzenleOdaSayisiBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // hosGeldinizSayfasi
            // 
            hosGeldinizSayfasi.BackColor = Color.MidnightBlue;
            hosGeldinizSayfasi.Controls.Add(hosGeldinizLabel);
            hosGeldinizSayfasi.Controls.Add(panel2);
            hosGeldinizSayfasi.Location = new Point(167, 85);
            hosGeldinizSayfasi.Name = "hosGeldinizSayfasi";
            hosGeldinizSayfasi.Size = new Size(992, 656);
            hosGeldinizSayfasi.TabIndex = 26;
            hosGeldinizSayfasi.Paint += panel1_Paint;
            // 
            // hosGeldinizLabel
            // 
            hosGeldinizLabel.AutoSize = true;
            hosGeldinizLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            hosGeldinizLabel.ForeColor = Color.White;
            hosGeldinizLabel.Location = new Point(395, 20);
            hosGeldinizLabel.Name = "hosGeldinizLabel";
            hosGeldinizLabel.Size = new Size(206, 46);
            hosGeldinizLabel.TabIndex = 25;
            hosGeldinizLabel.Text = "Hoş Geldiniz";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(16, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 474);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 753);
            Controls.Add(navBarPanel);
            Controls.Add(headerPanel);
            Controls.Add(kiralikEvlerSayfasi);
            Controls.Add(yeniKayitSayfasi);
            Controls.Add(duzenlemeSayfasi);
            Controls.Add(ayrintiSayfasi);
            Controls.Add(hosGeldinizSayfasi);
            Name = "Form1";
            Text = "Form1";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            navBarPanel.ResumeLayout(false);
            navBarPanel.PerformLayout();
            satilikEvlerPanel.ResumeLayout(false);
            satilikEvlerPanel.PerformLayout();
            kiralikEvlerPanel.ResumeLayout(false);
            kiralikEvlerPanel.PerformLayout();
            yeniSorguPanel.ResumeLayout(false);
            yeniSorguPanel.PerformLayout();
            yeniEvKayitPanel.ResumeLayout(false);
            yeniEvKayitPanel.PerformLayout();
            yeniKayitSayfasi.ResumeLayout(false);
            yeniKayitSayfasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)getiriYuzdesiNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)emlakNumarasiNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)yapimYiliNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)katNumarasiSeciciNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)odaSayisiSeciciNumeric).EndInit();
            kiralikEvlerSayfasi.ResumeLayout(false);
            kiralikEvlerSayfasi.PerformLayout();
            ayrintiSayfasi.ResumeLayout(false);
            ayrintiSayfasi.PerformLayout();
            duzenlemeSayfasi.ResumeLayout(false);
            duzenlemeSayfasi.PerformLayout();
            duzenlemeSayfasiPanel.ResumeLayout(false);
            duzenlemeSayfasiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)duzenleGetiriYuzdesiBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)duzenleEmlakNumarasiBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)duzenleYapimYiliBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)duzenleKatNumarasiBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)duzenleOdaSayisiBox).EndInit();
            hosGeldinizSayfasi.ResumeLayout(false);
            hosGeldinizSayfasi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label headerTitle;
        private Panel navBarPanel;
        private Panel yeniEvKayitPanel;
        private Label yeniEvKayitLabel;
        private Panel satilikEvlerPanel;
        private Label satilikEvlerLabel;
        private Panel kiralikEvlerPanel;
        private Label kiralikEvlerLabel;
        private Panel yeniSorguPanel;
        private Label yeniSorguLabel;
        private Panel yeniKayitSayfasi;
        private Label menuLabel;
        private Panel kiralikEvlerSayfasi;
        private Label label2;
        private Label label3;
        private NumericUpDown odaSayisiSeciciNumeric;
        private Label label4;
        private NumericUpDown katNumarasiSeciciNumeric;
        private ComboBox ilceComboBox;
        private Label label5;
        private Label label6;
        private ComboBox semtComboBox;
        private Label label8;
        private NumericUpDown yapimYiliNumeric;
        private Label label7;
        private TextBox evAlaniTextBox;
        private Label label9;
        private NumericUpDown emlakNumarasiNumeric;
        private Label label10;
        private ComboBox evCesidiComboBox;
        private Label label12;
        private ComboBox evTuruComboBox;
        private NumericUpDown getiriYuzdesiNumeric;
        private Label label11;
        private Button kayitOlusturButton;
        private Button button1;
        private Button button2;
        private Label label1;
        private Panel kiralikEvlerListePanel;
        private Panel ayrintiSayfasi;
        private Label label13;
        private Panel ayrintiSayfasiPanel;
        private Panel duzenlemeSayfasi;
        private Label label14;
        private Panel duzenlemeSayfasiPanel;
        private Button button3;
        private Button duzenlemeKaydetButton;
        private Label label15;
        private ComboBox duzenleEvTuruBox;
        private NumericUpDown duzenleGetiriYuzdesiBox;
        private Label label16;
        private Label label17;
        private ComboBox duzenleEvCesidiBox;
        private Label label18;
        private NumericUpDown duzenleEmlakNumarasiBox;
        private Label label19;
        private NumericUpDown duzenleYapimYiliBox;
        private Label label20;
        private TextBox duzenleEvAlaniBox;
        private Label label21;
        private ComboBox duzenleSemtBox;
        private Label label22;
        private ComboBox duzenleIlceBox;
        private Label label23;
        private NumericUpDown duzenleKatNumarasiBox;
        private Label label24;
        private NumericUpDown duzenleOdaSayisiBox;
        private Label label25;
        private ComboBox duzenleAktiflikBox;
        private Panel hosGeldinizSayfasi;
        private Label hosGeldinizLabel;
        private Panel panel2;
        private Button button4;
    }
}