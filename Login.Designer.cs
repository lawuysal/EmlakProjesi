namespace EmlakProjesi
{
    partial class Login
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
            girisKullanicAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            girisSifre = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // girisKullanicAdi
            // 
            girisKullanicAdi.Location = new Point(263, 168);
            girisKullanicAdi.Name = "girisKullanicAdi";
            girisKullanicAdi.Size = new Size(125, 27);
            girisKullanicAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(263, 145);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(263, 214);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // girisSifre
            // 
            girisSifre.Location = new Point(263, 237);
            girisSifre.Name = "girisSifre";
            girisSifre.Size = new Size(125, 27);
            girisSifre.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(263, 304);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(girisKullanicAdi);
            panel1.Controls.Add(girisSifre);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(93, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 368);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(144, 20);
            label3.Name = "label3";
            label3.Size = new Size(380, 41);
            label3.TabIndex = 5;
            label3.Text = "IŞIK EMLAK OTOMASYONU";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox girisKullanicAdi;
        private Label label1;
        private Label label2;
        private TextBox girisSifre;
        private Button button1;
        private Panel panel1;
        private Label label3;
    }
}