using EmlakProjesi.ClassLibrary;
using Newtonsoft.Json;

namespace EmlakProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string readingRecordsFileAnswer = App.evleriDosyadanOku();
            MessageBox.Show(readingRecordsFileAnswer);

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
            /*
            kiralikEvlerSayfasi.BringToFront();
            yeniEvKayitPanel.BackColor = Color.SeaGreen;
            yeniSorguPanel.BackColor = Color.MediumAquamarine;
            kiralikEvlerPanel.BackColor = Color.SeaGreen;
            satilikEvlerPanel.BackColor = Color.SeaGreen;
            */
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

        // Create a new Ev object and save it to the list
        private void button1_Click(object sender, EventArgs e)
        {
            string evTuru = evTuruComboBox.SelectedItem.ToString() ?? "Kiralýk";
            Ev yeniEv;

            if (evTuru == "Kiralýk")
            {
                yeniEv = new KiralikEv();
            }
            else
            {
                yeniEv = new SatilikEv();
            }

            yeniEv.OdaSayisi = Convert.ToInt32(odaSayisiSeciciNumeric.Value);
            yeniEv.KatNumarasi = Convert.ToInt32(katNumarasiSeciciNumeric.Value);
            yeniEv.Semt = semtComboBox.SelectedItem.ToString() ?? "Bilinmiyor";
            yeniEv.Ilce = ilceComboBox.SelectedItem.ToString() ?? "Bilinmiyor";
            yeniEv.Alan = Convert.ToDouble(evAlaniTextBox.Text);
            yeniEv.YapimTarihi = Convert.ToInt32(yapimYiliNumeric.Value);
            yeniEv.EmlakNumarasi = Convert.ToInt32(emlakNumarasiNumeric.Value);
            yeniEv.Cesit = (Ev.EvCesidi)Enum.Parse(typeof(Ev.EvCesidi), evCesidiComboBox.SelectedItem.ToString() ?? "Bilinmiyor");
            yeniEv.GetiriOrani = Convert.ToDouble(getiriYuzdesiNumeric.Value);

            string sonuc = App.evKaydet(yeniEv);
            MessageBox.Show(sonuc);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(App.evListesi.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string readingRecordsFileAnswer = App.evleriDosyadanOku();
            //MessageBox.Show(readingRecordsFileAnswer);
        }

        private void kiralikEvlerLabel_Click(object sender, EventArgs e)
        {
            kiralikEvlerSayfasi.BringToFront();
            yeniEvKayitPanel.BackColor = Color.SeaGreen;
            yeniSorguPanel.BackColor = Color.SeaGreen;
            kiralikEvlerPanel.BackColor = Color.MediumAquamarine;
            satilikEvlerPanel.BackColor = Color.SeaGreen;
        }
    }
}