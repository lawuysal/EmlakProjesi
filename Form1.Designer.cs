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
            panel1 = new Panel();
            panel2 = new Panel();
            headerPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 501);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(21, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(111, 29);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 723);
            Controls.Add(panel1);
            Controls.Add(headerPanel);
            Name = "Form1";
            Text = "Form1";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label headerTitle;
        private Panel panel1;
        private Panel panel2;
    }
}