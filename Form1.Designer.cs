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
            label6 = new Label();
            semtComboBox = new ComboBox();
            label5 = new Label();
            ilceComboBox = new ComboBox();
            label4 = new Label();
            katNumarasiSeciciNumeric = new NumericUpDown();
            label3 = new Label();
            odaSayisiSeciciNumeric = new NumericUpDown();
            label2 = new Label();
            yeniSorguSayfasi = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            numericUpDown3 = new NumericUpDown();
            label12 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            headerPanel.SuspendLayout();
            navBarPanel.SuspendLayout();
            satilikEvlerPanel.SuspendLayout();
            kiralikEvlerPanel.SuspendLayout();
            yeniSorguPanel.SuspendLayout();
            yeniEvKayitPanel.SuspendLayout();
            yeniKayitSayfasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)katNumarasiSeciciNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)odaSayisiSeciciNumeric).BeginInit();
            yeniSorguSayfasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
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
            menuLabel.Location = new Point(47, 20);
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
            yeniKayitSayfasi.Controls.Add(button1);
            yeniKayitSayfasi.Controls.Add(label12);
            yeniKayitSayfasi.Controls.Add(comboBox2);
            yeniKayitSayfasi.Controls.Add(numericUpDown3);
            yeniKayitSayfasi.Controls.Add(label11);
            yeniKayitSayfasi.Controls.Add(label10);
            yeniKayitSayfasi.Controls.Add(comboBox1);
            yeniKayitSayfasi.Controls.Add(label9);
            yeniKayitSayfasi.Controls.Add(numericUpDown2);
            yeniKayitSayfasi.Controls.Add(label8);
            yeniKayitSayfasi.Controls.Add(numericUpDown1);
            yeniKayitSayfasi.Controls.Add(label7);
            yeniKayitSayfasi.Controls.Add(textBox1);
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
            semtComboBox.Items.AddRange(new object[] { "Fatih", "Beşiktaş", "Beyoğlu", "Üsküdar", "Kadıköy", "Sarıyer", "Şişli", "Zeytinburnu", "Eyüpsultan", "Bakırköy", "Kağıthane", "Maltepe", "Bayrampaşa", "Gaziosmanpaşa", "Sultangazi", "Bahçelievler", "Pendik", "Kartal" });
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
            // yeniSorguSayfasi
            // 
            yeniSorguSayfasi.BackColor = Color.RosyBrown;
            yeniSorguSayfasi.Controls.Add(label1);
            yeniSorguSayfasi.Location = new Point(1207, 85);
            yeniSorguSayfasi.Name = "yeniSorguSayfasi";
            yeniSorguSayfasi.Size = new Size(992, 656);
            yeniSorguSayfasi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(543, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 9;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(543, 203);
            numericUpDown1.Maximum = new decimal(new int[] { 2040, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1850, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 1850, 0, 0, 0 });
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
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(543, 271);
            numericUpDown2.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 100001, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 13;
            numericUpDown2.Value = new decimal(new int[] { 100001, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Daire", "Bahçeli", "Müstakil", "Dubleks", "Stüdyo", "Belirtilmemiş" });
            comboBox1.Location = new Point(543, 338);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(263, 388);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 18;
            label11.Text = "Getiri Oranı:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(263, 411);
            numericUpDown3.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 19;
            numericUpDown3.Value = new decimal(new int[] { 5, 0, 0, 0 });
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kiralık", "Satılık" });
            comboBox2.Location = new Point(543, 411);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(401, 500);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 22;
            button1.Text = "Kayıdı Oluştur";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 753);
            Controls.Add(yeniSorguSayfasi);
            Controls.Add(yeniKayitSayfasi);
            Controls.Add(navBarPanel);
            Controls.Add(headerPanel);
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
            ((System.ComponentModel.ISupportInitialize)katNumarasiSeciciNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)odaSayisiSeciciNumeric).EndInit();
            yeniSorguSayfasi.ResumeLayout(false);
            yeniSorguSayfasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
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
        private Label label1;
        private Panel yeniSorguSayfasi;
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
        private NumericUpDown numericUpDown1;
        private Label label7;
        private TextBox textBox1;
        private Label label9;
        private NumericUpDown numericUpDown2;
        private Label label10;
        private ComboBox comboBox1;
        private Label label12;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown3;
        private Label label11;
        private Button button1;
    }
}