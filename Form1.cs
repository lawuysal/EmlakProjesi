using EmlakProjesi.ClassLibrary;
using Newtonsoft.Json;

namespace EmlakProjesi
{

    public partial class Form1 : Form
    {
        ListeEventArgs _ARGS_ = new ListeEventArgs(1, 1);
        bool _isAktifOlmayanlariKiralikListedeGoster_ = false;
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
            kiralikEvlerListePanel.Controls.Clear();
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
            string evTuru = evTuruComboBox.SelectedItem.ToString() ?? "Kiral�k";
            Ev yeniEv;

            if (evTuru == "Kiral�k")
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
            // Changes its value to decimal point number like if its 5, it will be 0.05
            yeniEv.GetiriOrani = Convert.ToDouble(getiriYuzdesiNumeric.Value) / 100;
            Directory.CreateDirectory("foto�raflar\\" + yeniEv.EmlakNumarasi.ToString());
            yeniEv.EvinFotograflariKlasoru = "foto�raflar\\" + yeniEv.EmlakNumarasi.ToString();



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
            App.kiralikEvleriListele(
                ref kiralikEvlerListePanel,
                DynamicPanel_Click,
                duzenlemeSayfasinaGit_Click,
                _isAktifOlmayanlariKiralikListedeGoster_
                );
            kiralikEvlerSayfasi.BringToFront();
            yeniEvKayitPanel.BackColor = Color.SeaGreen;
            yeniSorguPanel.BackColor = Color.SeaGreen;
            kiralikEvlerPanel.BackColor = Color.MediumAquamarine;
            satilikEvlerPanel.BackColor = Color.SeaGreen;
        }

        // For navigating to detailed view
        private void DynamicPanel_Click(object sender, EventArgs e)
        {

            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null && clickedPanel.Tag is ListeEventArgs listeEventArgs)
            {
                ayrintiSayfasiPanel.Controls.Clear();
                App.evAyrintilariGoster(listeEventArgs.EmlakNumarasi, listeEventArgs.Fiyat, ref ayrintiSayfasiPanel, duzenlemeSayfasinaGit_Click);
                ayrintiSayfasi.BringToFront();
                kiralikEvlerListePanel.Controls.Clear();

                //MessageBox.Show("Clicked: " + clickedPanel.Name + " " + listeEventArgs.EmlakNumarasi);
            }
        }

        private void duzenlemeSayfasinaGit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            _ARGS_ = button.Tag as ListeEventArgs;
            if (button != null && button.Tag is ListeEventArgs listeEventArgs)
            {
                //duzenlemeSayfasiPanel.Controls.Clear();

                App.evDuzenle(
                    listeEventArgs.EmlakNumarasi,
                    listeEventArgs.Fiyat,
                    ref duzenlemeSayfasiPanel,
                    ref duzenleOdaSayisiBox,
                    ref duzenleKatNumarasiBox,
                    ref duzenleIlceBox,
                    ref duzenleSemtBox,
                    ref duzenleGetiriYuzdesiBox,
                    ref duzenleEvAlaniBox,
                    ref duzenleYapimYiliBox,
                    ref duzenleEmlakNumarasiBox,
                    ref duzenleEvCesidiBox,
                    ref duzenleEvTuruBox,
                    ref duzenleAktiflikBox
                    );
                duzenlemeSayfasi.BringToFront();
                //ayrintiSayfasiPanel.Controls.Clear();
            }
        }

        private void ayrintiSayfasi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ayrintiSayfasi.BringToFront();
        }

        private void yeniKayitSayfasi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void duzenleKatNumarasiBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void duzenleIlceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.ilceleriYukle(ref duzenleIlceBox, ref duzenleSemtBox);
        }

        private void duzenlemeKaydetButton_Click(object sender, EventArgs e)
        {
            App.evDuzenlemeKaydet(
                _ARGS_.EmlakNumarasi,
                _ARGS_.Fiyat,
                ref kiralikEvlerSayfasi,
                ref duzenlemeSayfasiPanel,
                ref duzenleOdaSayisiBox,
                ref duzenleKatNumarasiBox,
                ref duzenleIlceBox,
                ref duzenleSemtBox,
                ref duzenleGetiriYuzdesiBox,
                ref duzenleEvAlaniBox,
                ref duzenleYapimYiliBox,
                ref duzenleEmlakNumarasiBox,
                ref duzenleEvCesidiBox,
                ref duzenleEvTuruBox,
                ref duzenleAktiflikBox
                );

            hosGeldinizSayfasi.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _isAktifOlmayanlariKiralikListedeGoster_ = !_isAktifOlmayanlariKiralikListedeGoster_;
            if (_isAktifOlmayanlariKiralikListedeGoster_)
            {
                button4.Text = "Aktif Olmayanlar� Gizle";
            }
            else
            {
                button4.Text = "Aktif Olmayanlar� G�ster";
            }

            kiralikEvlerListePanel.Controls.Clear();
            App.kiralikEvleriListele(
                ref kiralikEvlerListePanel,
                DynamicPanel_Click,
                duzenlemeSayfasinaGit_Click,
                _isAktifOlmayanlariKiralikListedeGoster_
                );
            kiralikEvlerSayfasi.BringToFront();
            yeniEvKayitPanel.BackColor = Color.SeaGreen;
            yeniSorguPanel.BackColor = Color.SeaGreen;
            kiralikEvlerPanel.BackColor = Color.MediumAquamarine;
            satilikEvlerPanel.BackColor = Color.SeaGreen;
        }
    }
}