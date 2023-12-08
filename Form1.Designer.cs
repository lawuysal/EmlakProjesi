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
            yeniEvKayitPanel = new Panel();
            yeniEvKayitLabel = new Label();
            yeniSorguPanel = new Panel();
            yeniSorguLabel = new Label();
            kiralikEvlerPanel = new Panel();
            kiralikEvlerLabel = new Label();
            satilikEvlerPanel = new Panel();
            satilikEvlerLabel = new Label();
            yeniKayitSayfasi = new Panel();
            headerPanel.SuspendLayout();
            navBarPanel.SuspendLayout();
            yeniEvKayitPanel.SuspendLayout();
            yeniSorguPanel.SuspendLayout();
            kiralikEvlerPanel.SuspendLayout();
            satilikEvlerPanel.SuspendLayout();
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
            navBarPanel.Controls.Add(satilikEvlerPanel);
            navBarPanel.Controls.Add(kiralikEvlerPanel);
            navBarPanel.Controls.Add(yeniSorguPanel);
            navBarPanel.Controls.Add(yeniEvKayitPanel);
            navBarPanel.Location = new Point(12, 85);
            navBarPanel.Name = "navBarPanel";
            navBarPanel.Size = new Size(150, 500);
            navBarPanel.TabIndex = 1;
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
            // yeniKayitSayfasi
            // 
            yeniKayitSayfasi.BackColor = Color.Gray;
            yeniKayitSayfasi.Location = new Point(168, 85);
            yeniKayitSayfasi.Name = "yeniKayitSayfasi";
            yeniKayitSayfasi.Size = new Size(992, 656);
            yeniKayitSayfasi.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 753);
            Controls.Add(yeniKayitSayfasi);
            Controls.Add(navBarPanel);
            Controls.Add(headerPanel);
            Name = "Form1";
            Text = "Form1";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            navBarPanel.ResumeLayout(false);
            yeniEvKayitPanel.ResumeLayout(false);
            yeniEvKayitPanel.PerformLayout();
            yeniSorguPanel.ResumeLayout(false);
            yeniSorguPanel.PerformLayout();
            kiralikEvlerPanel.ResumeLayout(false);
            kiralikEvlerPanel.PerformLayout();
            satilikEvlerPanel.ResumeLayout(false);
            satilikEvlerPanel.PerformLayout();
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
    }
}