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
            App.ilceleriYukle(ref ilceComboBox, ref semtComboBox);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string evTuru = evTuruComboBox.SelectedItem.ToString() ?? "Kiralýk";

            if (evTuru == "Kiralýk") 
            {                 
                KiralikEv kiralikEv = new KiralikEv();
                kiralikEv.OdaSayisi = Convert.ToInt32(odaSayisiNumericUpDown.Value);
                kiralikEv.KatNumarasi = Convert.ToInt32(katNumarasiNumericUpDown.Value);
                kiralikEv.Semt = semtComboBox.SelectedItem.ToString();
                kiralikEv.Alan = Convert.ToDouble(alanNumericUpDown.Value);
                kiralikEv.YapimTarihi = Convert.ToInt32(yapimTarihiNumericUpDown.Value);
                kiralikEv.EmlakNumarasi = Convert.ToInt32(emlakNumarasiNumericUpDown.Value);
                kiralikEv.Cesit = (Ev.EvCesidi)Enum.Parse(typeof(Ev.EvCesidi), evCesidiComboBox.SelectedItem.ToString());
                kiralikEv.GetiriOrani = Convert.ToDouble(getiriOraniNumericUpDown.Value);
                kiralikEv.EvinFotograflariKlasorYolu = evinFotograflariKlasorYoluTextBox.Text;
                kiralikEv.KiraciAdi = kiraciAdiTextBox.Text;
                kiralikEv.KiraSuresi = Convert.ToInt32(kiraSuresiNumericUpDown.Value);
                kiralikEv.Depozito = Convert.ToInt32(depozitoNumericUpDown.Value);
                kiralikEv.DepozitoDurumu = depozitoDurumuCheckBox.Checked;
            
                kiralikEvler.Add(kiralikEv);
            }
            
        }
    }
}