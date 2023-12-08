namespace EmlakProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void headerTitle_Click(object sender, EventArgs e)
        {

        }

        private void yeniEvKayitLabel_Click(object sender, EventArgs e)
        {
            yeniKayitSayfasi.BringToFront();
            yeniEvKayitPanel.BackColor = Color.MediumAquamarine;
            yeniSorguPanel.BackColor = Color.SeaGreen;
            kiralikEvlerPanel.BackColor = Color.SeaGreen;
            satilikEvlerPanel.BackColor = Color.SeaGreen;
        }

        private void yeniSorguLabel_Click(object sender, EventArgs e)
        {
            yeniSorguSayfasi.BringToFront();
            yeniEvKayitPanel.BackColor = Color.SeaGreen;
            yeniSorguPanel.BackColor = Color.MediumAquamarine;
            kiralikEvlerPanel.BackColor = Color.SeaGreen;
            satilikEvlerPanel.BackColor = Color.SeaGreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenIlce = ilceComboBox.SelectedItem.ToString() ?? "besiktas";
            List<string> semtler = new List<string>();

            using (StreamReader sr = new StreamReader("semtler\\" + secilenIlce+".txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    semtler.Add(line);
                }
            }

            semtComboBox.Items.Clear(); 

            foreach (string semt in semtler)
            {
                semtComboBox.Items.Add(semt);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}