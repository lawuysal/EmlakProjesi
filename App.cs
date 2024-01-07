using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmlakProjesi.ClassLibrary;
using Newtonsoft.Json;


namespace EmlakProjesi

{
    
    internal class App
    {
        public static void logger(string mesaj)
        {
            string logString = mesaj + "  " + DateTime.Now.ToString();

            File.AppendAllText("log\\log.txt", logString);
            File.AppendAllText("log\\log.txt", Environment.NewLine); 
        }
        public static List<Ev> evListesi = new List<Ev>();
        public static List<KiralikEv> kiralikEvListesi = new List<KiralikEv>();
        public static List<SatilikEv> satilikEvListesi = new List<SatilikEv>();
        public static List<Ev> sorguListesi = new List<Ev>();
        public static void ilceleriYukle(ref ComboBox ilceComboBox, ref ComboBox semtComboBox)
        {
            string secilenIlce = ilceComboBox.SelectedItem.ToString() ?? "besiktas";
            List<string> semtler = new List<string>();

            using (StreamReader sr = new StreamReader("semtler\\" + secilenIlce + ".txt"))
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
        public static string evKaydet(Ev yeniEv)
        {
            if (evListesi.Any(ev => ev.EmlakNumarasi == yeniEv.EmlakNumarasi))
            {
                return "Bu emlak numarası zaten kayıtlı!";
            }
            if (yeniEv is KiralikEv)
            {
                kiralikEvListesi.Add((KiralikEv)yeniEv);
                evListesi.Add(yeniEv);
                evleriDosyayaYaz();
                return "Yeni ev başarıyla kaydedildi!";
            }
            else
            {
                satilikEvListesi.Add((SatilikEv)yeniEv);
                evListesi.Add(yeniEv);
                evleriDosyayaYaz();
                return "Yeni ev başarıyla kaydedildi!";
            }
            
        }
        public static void evleriDosyayaYaz()
        {
            string serializedKiralik = JsonConvert.SerializeObject(kiralikEvListesi);
            string serializedSatilik = JsonConvert.SerializeObject(satilikEvListesi);
            File.WriteAllText("kayıtlar\\kiralik.txt", serializedKiralik);
            File.WriteAllText("kayıtlar\\satilik.txt", serializedSatilik);
        }   
        public static string evleriDosyadanOku()
        {
            string deserializedKiralik = File.ReadAllText("kayıtlar\\kiralik.txt");
            string deserializedSatilik = File.ReadAllText("kayıtlar\\satilik.txt");
            kiralikEvListesi = JsonConvert.DeserializeObject<List<KiralikEv>>(deserializedKiralik) ?? new List<KiralikEv>();
            satilikEvListesi = JsonConvert.DeserializeObject<List<SatilikEv>>(deserializedSatilik) ?? new List<SatilikEv>();
            evListesi.AddRange(kiralikEvListesi);
            evListesi.AddRange(satilikEvListesi);
            if (evListesi.Count == 0)
            {
                evListesi = new List<Ev>();
                return "Kayıtlı ev bulunamadı!";
            }
            else
            {
                return "Kayıtlı evler başarıyla yüklendi!";
            }
        }
        public static void kiralikEvleriListele(
            ref Panel listePanel, 
            EventHandler ayrintiEventHandler, 
            EventHandler duzenleEventHandler, 
            bool aktifOlmayanGoster,
            ref bool isSorguSayfasi,
            EventHandler silmeEventHandler
            )
        {
            isSorguSayfasi = false;
            listePanel.AutoScroll = true;
            int i = 0;
            int k = 0;
            bool aktiflikGostermeDurumu = false;
            if (aktifOlmayanGoster)
            {
                aktiflikGostermeDurumu = true;
            }
            else
            {
                aktiflikGostermeDurumu = false;
            }

            while (i < kiralikEvListesi.Count )
            {
                if (kiralikEvListesi[i].IsAktif == true || aktiflikGostermeDurumu)
                {
                    Panel myPanel = new Panel();
                    myPanel.Name = "kiralikEv" + i.ToString();
                    myPanel.Size = new Size(750, 100);
                    myPanel.Location = new Point(100, 50 + (k * 130));
                    myPanel.BackColor = Color.White;
                    listePanel.Controls.Add(myPanel);
                    myPanel.Tag = new ListeEventArgs(kiralikEvListesi[i].EmlakNumarasi, kiralikEvListesi[i].KiraHesapla());
                    myPanel.Click += ayrintiEventHandler;

                    Label konum = new Label();
                    konum.Name = "konum" + i.ToString();
                    konum.Text = (k + 1) + "-) " + kiralikEvListesi[i].Ilce + ", " +
                        kiralikEvListesi[i].Semt + "  |  " + kiralikEvListesi[i].FiyatHesapla() + " TL";
                    konum.Size = new Size(450, 25);
                    konum.Location = new Point(10, 10);
                    konum.Font = new Font("Segue UI", 12);
                    myPanel.Controls.Add(konum);

                    Label odaSayisi = new Label();
                    odaSayisi.Name = "odaSayisi" + i.ToString();
                    if (kiralikEvListesi[i].OdaSayisi != 1)
                    {
                        odaSayisi.Text = "Oda Sayısı: " + (kiralikEvListesi[i].OdaSayisi - 1).ToString() + " + 1";
                    }
                    else
                    {
                        odaSayisi.Text = "Oda Sayısı: " + kiralikEvListesi[i].OdaSayisi.ToString() + " + 0";
                    }
                    odaSayisi.Size = new Size(150, 25);
                    odaSayisi.Location = new Point(10, 65);
                    odaSayisi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(odaSayisi);

                    Label evinAlani = new Label();
                    evinAlani.Name = "evinAlani" + i.ToString();
                    evinAlani.Text = "Ev Alanı: " + kiralikEvListesi[i].Alan.ToString() + " m²";
                    evinAlani.Size = new Size(150, 25);
                    evinAlani.Location = new Point(160, 65);
                    evinAlani.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(evinAlani);

                    Label evinCesidi = new Label();
                    evinCesidi.Name = "evinCesidi" + i.ToString();
                    evinCesidi.Text = "Ev Çeşidi: " + kiralikEvListesi[i].Cesit.ToString();
                    evinCesidi.Size = new Size(150, 25);
                    evinCesidi.Location = new Point(310, 65);
                    evinCesidi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(evinCesidi);

                    Label binaYasi = new Label();
                    binaYasi.Name = "binaYasi" + i.ToString();
                    binaYasi.Text = "Bina Yaşı: " + kiralikEvListesi[i].BinaYasi + " ";
                    binaYasi.Size = new Size(150, 25);
                    binaYasi.Location = new Point(480, 65);
                    binaYasi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(binaYasi);

                    Button sil = new Button();
                    sil.Name = "sil" + i.ToString();
                    sil.Text = "🗑";
                    sil.Size = new Size(80, 30);
                    sil.Location = new Point(600, 25);
                    sil.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(sil);
                    sil.Tag = new ListeEventArgs(kiralikEvListesi[i].EmlakNumarasi, kiralikEvListesi[i].KiraHesapla());
                    sil.Click += silmeEventHandler;

                    if (!kiralikEvListesi[i].IsAktif)
                    {
                        Label aktiflikDurumu = new Label();
                        aktiflikDurumu.Name = "aktiflikDurumu" + i.ToString();
                        aktiflikDurumu.Text = "Aktif Değil!";
                        aktiflikDurumu.Size = new Size(150, 25);
                        aktiflikDurumu.Location = new Point(480, 30);
                        aktiflikDurumu.Font = new Font("Segue UI", 8);
                        aktiflikDurumu.ForeColor = Color.Red;
                        myPanel.Controls.Add(aktiflikDurumu);
                    }

                    k++;
                }

                i++;
            }
        }

        public static void sorgulananEvleriListele(
            ref Panel listePanel, 
            EventHandler ayrintiEventHandler, 
            EventHandler duzenleEventHandler, 
            bool aktifOlmayanGoster, 
            ref bool isSorguSayfasi,
            EventHandler silmeEventHandler
            )
        {
            isSorguSayfasi = true;
            listePanel.AutoScroll = true;
            int i = 0;
            int k = 0;
            bool aktiflikGostermeDurumu = false;
            if (aktifOlmayanGoster)
            {
                aktiflikGostermeDurumu = true;
            }
            else
            {
                aktiflikGostermeDurumu = false;
            }

            while (i < sorguListesi.Count)
            {
                if (sorguListesi[i].IsAktif == true || aktiflikGostermeDurumu)
                {
                    Panel myPanel = new Panel();
                    myPanel.Name = "sorglananEv" + i.ToString();
                    myPanel.Size = new Size(750, 100);
                    myPanel.Location = new Point(100, 50 + (k * 130));
                    myPanel.BackColor = Color.White;
                    listePanel.Controls.Add(myPanel);
                    myPanel.Tag = new ListeEventArgs(sorguListesi[i].EmlakNumarasi, sorguListesi[i].FiyatHesapla());
                    myPanel.Click += ayrintiEventHandler;

                    Label konum = new Label();
                    konum.Name = "konum" + i.ToString();
                    if (sorguListesi[i] is KiralikEv)
                    {
                        KiralikEv tempEv = sorguListesi[i] as KiralikEv;
                        konum.Text = (k + 1) + "-) " + sorguListesi[i].Ilce + ", " +
                        sorguListesi[i].Semt + "  |  " + tempEv.KiraHesapla() + " TL";
                    }
                    else if (sorguListesi[i] is SatilikEv )
                    {
                        SatilikEv tempEv = sorguListesi[i] as SatilikEv;
                        konum.Text = (k + 1) + "-) " + sorguListesi[i].Ilce + ", " +
                        sorguListesi[i].Semt + "  |  " + tempEv.SatisFiyatHesapla() + " TL";
                    }

                    
                    konum.Size = new Size(450, 25);
                    konum.Location = new Point(10, 10);
                    konum.Font = new Font("Segue UI", 12);
                    myPanel.Controls.Add(konum);

                    Label odaSayisi = new Label();
                    odaSayisi.Name = "odaSayisi" + i.ToString();
                    if (sorguListesi[i].OdaSayisi != 1)
                    {
                        odaSayisi.Text = "Oda Sayısı: " + (sorguListesi[i].OdaSayisi - 1).ToString() + " + 1";
                    }
                    else
                    {
                        odaSayisi.Text = "Oda Sayısı: " + sorguListesi[i].OdaSayisi.ToString() + " + 0";
                    }
                    odaSayisi.Size = new Size(150, 25);
                    odaSayisi.Location = new Point(10, 65);
                    odaSayisi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(odaSayisi);

                    Label evinAlani = new Label();
                    evinAlani.Name = "evinAlani" + i.ToString();
                    evinAlani.Text = "Ev Alanı: " + sorguListesi[i].Alan.ToString() + " m²";
                    evinAlani.Size = new Size(150, 25);
                    evinAlani.Location = new Point(160, 65);
                    evinAlani.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(evinAlani);

                    Label evinCesidi = new Label();
                    evinCesidi.Name = "evinCesidi" + i.ToString();
                    evinCesidi.Text = "Ev Çeşidi: " + sorguListesi[i].Cesit.ToString();
                    evinCesidi.Size = new Size(150, 25);
                    evinCesidi.Location = new Point(310, 65);
                    evinCesidi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(evinCesidi);

                    Label binaYasi = new Label();
                    binaYasi.Name = "binaYasi" + i.ToString();
                    binaYasi.Text = "Bina Yaşı: " + sorguListesi[i].BinaYasi + " ";
                    binaYasi.Size = new Size(100, 25);
                    binaYasi.Location = new Point(460, 65);
                    binaYasi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(binaYasi);

                    Label binaTuru = new Label();   
                    binaTuru.Name = "binaTuru" + i.ToString();
                    if (sorguListesi[i] is KiralikEv)
                    {
                        binaTuru.Text = "Bina Türü: Kiralık";
                    }
                    else if (sorguListesi[i] is SatilikEv)
                    {
                        binaTuru.Text = "Bina Türü: Satılık";
                    }
                    binaTuru.Size = new Size(150, 25);
                    binaTuru.Location = new Point(570, 65);
                    binaTuru.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(binaTuru);

                    Button sil = new Button();
                    sil.Name = "sil" + i.ToString();
                    sil.Text = "🗑";
                    sil.Size = new Size(80, 30);
                    sil.Location = new Point(600, 25);
                    sil.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(sil);
                    sil.Tag = new ListeEventArgs(sorguListesi[i].EmlakNumarasi, sorguListesi[i].FiyatHesapla());
                    sil.Click += silmeEventHandler;



                    if (!sorguListesi[i].IsAktif)
                    {
                        Label aktiflikDurumu = new Label();
                        aktiflikDurumu.Name = "aktiflikDurumu" + i.ToString();
                        aktiflikDurumu.Text = "Aktif Değil!";
                        aktiflikDurumu.Size = new Size(150, 25);
                        aktiflikDurumu.Location = new Point(480, 30);
                        aktiflikDurumu.Font = new Font("Segue UI", 8);
                        aktiflikDurumu.ForeColor = Color.Red;
                        myPanel.Controls.Add(aktiflikDurumu);
                    }



                    k++;
                }

                i++;
            }
        }

        public static void satilikEvleriListele(
            ref Panel listePanel, 
            EventHandler ayrintiEventHandler, 
            EventHandler duzenleEventHandler, 
            bool aktifOlmayanGoster, 
            ref bool isSorguSayfasi,
            EventHandler silmeEventHandler)
        {
            isSorguSayfasi = false;
            listePanel.AutoScroll = true;
            int i = 0;
            int k = 0;
            bool aktiflikGostermeDurumu = false;
            if (aktifOlmayanGoster)
            {
                aktiflikGostermeDurumu = true;
            }
            else
            {
                aktiflikGostermeDurumu = false;
            }

            while (i < satilikEvListesi.Count)
            {
                if (satilikEvListesi[i].IsAktif == true || aktiflikGostermeDurumu)
                {
                    Panel myPanel = new Panel();
                    myPanel.Name = "satilikEv" + i.ToString();
                    myPanel.Size = new Size(750, 100);
                    myPanel.Location = new Point(100, 50 + (k * 130));
                    myPanel.BackColor = Color.White;
                    listePanel.Controls.Add(myPanel);
                    myPanel.Tag = new ListeEventArgs(satilikEvListesi[i].EmlakNumarasi, satilikEvListesi[i].SatisFiyatHesapla());
                    myPanel.Click += ayrintiEventHandler;

                    Label konum = new Label();
                    konum.Name = "konum" + i.ToString();
                    konum.Text = (k + 1) + "-) " + satilikEvListesi[i].Ilce + ", " +
                        satilikEvListesi[i].Semt + "  |  " + satilikEvListesi[i].SatisFiyatHesapla() + " TL";
                    konum.Size = new Size(450, 25);
                    konum.Location = new Point(10, 10);
                    konum.Font = new Font("Segue UI", 12);
                    myPanel.Controls.Add(konum);

                    Label odaSayisi = new Label();
                    odaSayisi.Name = "odaSayisi" + i.ToString();
                    if (satilikEvListesi[i].OdaSayisi != 1)
                    {
                        odaSayisi.Text = "Oda Sayısı: " + (satilikEvListesi[i].OdaSayisi - 1).ToString() + " + 1";
                    }
                    else
                    {
                        odaSayisi.Text = "Oda Sayısı: " + satilikEvListesi[i].OdaSayisi.ToString() + " + 0";
                    }
                    odaSayisi.Size = new Size(150, 25);
                    odaSayisi.Location = new Point(10, 65);
                    odaSayisi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(odaSayisi);

                    Label evinAlani = new Label();
                    evinAlani.Name = "evinAlani" + i.ToString();
                    evinAlani.Text = "Ev Alanı: " + satilikEvListesi[i].Alan.ToString() + " m²";
                    evinAlani.Size = new Size(150, 25);
                    evinAlani.Location = new Point(160, 65);
                    evinAlani.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(evinAlani);

                    Label evinCesidi = new Label();
                    evinCesidi.Name = "evinCesidi" + i.ToString();
                    evinCesidi.Text = "Ev Çeşidi: " + satilikEvListesi[i].Cesit.ToString();
                    evinCesidi.Size = new Size(150, 25);
                    evinCesidi.Location = new Point(310, 65);
                    evinCesidi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(evinCesidi);

                    Label binaYasi = new Label();
                    binaYasi.Name = "binaYasi" + i.ToString();
                    binaYasi.Text = "Bina Yaşı: " + satilikEvListesi[i].BinaYasi + " ";
                    binaYasi.Size = new Size(150, 25);
                    binaYasi.Location = new Point(480, 65);
                    binaYasi.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(binaYasi);

                    Button sil = new Button();
                    sil.Name = "sil" + i.ToString();
                    sil.Text = "🗑";
                    sil.Size = new Size(80, 30);
                    sil.Location = new Point(600, 25);
                    sil.Font = new Font("Segue UI", 8);
                    myPanel.Controls.Add(sil);
                    sil.Tag = new ListeEventArgs(satilikEvListesi[i].EmlakNumarasi, satilikEvListesi[i].SatisFiyatHesapla());
                    sil.Click += silmeEventHandler;

                    if (!satilikEvListesi[i].IsAktif)
                    {
                        Label aktiflikDurumu = new Label();
                        aktiflikDurumu.Name = "aktiflikDurumu" + i.ToString();
                        aktiflikDurumu.Text = "Aktif Değil!";
                        aktiflikDurumu.Size = new Size(150, 25);
                        aktiflikDurumu.Location = new Point(480, 30);
                        aktiflikDurumu.Font = new Font("Segue UI", 8);
                        aktiflikDurumu.ForeColor = Color.Red;
                        myPanel.Controls.Add(aktiflikDurumu);
                    }

                    k++;
                }

                i++;
            }
        }
        public static void evAyrintilariGoster(int _emlakNumarasi, double _fiyat, ref Panel evAyrintilariPanel, EventHandler duzenlemeEventHandler)
        {
            Ev ev = evListesi.Find(ev => ev.EmlakNumarasi == _emlakNumarasi);
            

            Label konum = new Label();
            konum.Name = "konum";
            konum.Text = $"Konum: {ev.Ilce}, { ev.Semt}";
            konum.Size = new Size(300, 25);
            konum.Location = new Point(190, 70);
            konum.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(konum);

            Label odaSayisi = new Label();
            odaSayisi.Name = "odaSayisi";
            odaSayisi.Text = $"Oda Sayısı: {ev.OdaSayisi}";
            odaSayisi.Size = new Size(300, 25);
            odaSayisi.Location = new Point(190, 115);
            odaSayisi.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(odaSayisi);

            Label evinAlani = new Label();
            evinAlani.Name = "evinAlani";
            evinAlani.Text = $"Ev Alanı: {ev.Alan} m²";
            evinAlani.Size = new Size(300, 25);
            evinAlani.Location = new Point(190, 160);
            evinAlani.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(evinAlani);

            Label evinCesidi = new Label();
            evinCesidi.Name = "evinCesidi";
            evinCesidi.Text = $"Ev Çeşidi: {ev.Cesit}";
            evinCesidi.Size = new Size(300, 25);
            evinCesidi.Location = new Point(190, 205);
            evinCesidi.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(evinCesidi);

            Label katNumarasi = new Label();
            katNumarasi.Name = "katNumarasi";
            katNumarasi.Text = $"Kat Numarası: {ev.KatNumarasi}";
            katNumarasi.Size = new Size(300, 25);
            katNumarasi.Location = new Point(190, 250);
            katNumarasi.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(katNumarasi);

            Label yapimTarihi = new Label();
            yapimTarihi.Name = "yapimTarihi";
            yapimTarihi.Text = $"Yapım Tarihi: {ev.YapimTarihi}";
            yapimTarihi.Size = new Size(300, 25);
            yapimTarihi.Location = new Point(190, 295);
            yapimTarihi.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(yapimTarihi);

            Label binaYasi = new Label();
            binaYasi.Name = "binaYasi";
            binaYasi.Text = $"Bina Yaşı: {ev.BinaYasi}";
            binaYasi.Size = new Size(300, 25);
            binaYasi.Location = new Point(190, 340);
            binaYasi.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(binaYasi);

            Label aktiflikDurumu = new Label();
            aktiflikDurumu.Name = "aktiflikDurumu";
            if (ev.IsAktif)
            {
                aktiflikDurumu.Text = $"Aktiflik Durumu: Aktif";
            }
            else
            {
                aktiflikDurumu.Text = $"Aktiflik Durumu: Aktif değil";
            }
            aktiflikDurumu.Size = new Size(300, 25);
            aktiflikDurumu.Location = new Point(490, 70);
            aktiflikDurumu.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(aktiflikDurumu);

            Label fiyat = new Label();
            fiyat.Name = "fiyat";
            fiyat.Text = $"Fiyat: {_fiyat} TL";
            fiyat.Size = new Size(300, 25);
            fiyat.Location = new Point(490, 115);
            fiyat.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(fiyat);

            Label emlakNumarasi = new Label();
            emlakNumarasi.Name = "emlakNumarasi";
            emlakNumarasi.Text = $"Emlak Numarası: {ev.EmlakNumarasi}";
            emlakNumarasi.Size = new Size(300, 25);
            emlakNumarasi.Location = new Point(490, 160);
            emlakNumarasi.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(emlakNumarasi);

            Label getiriOrani = new Label();
            getiriOrani.Name = "getiriOrani";
            getiriOrani.Text = $"Getiri Oranı: {ev.GetiriOrani}";
            getiriOrani.Size = new Size(300, 25);
            getiriOrani.Location = new Point(490, 205);
            getiriOrani.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(getiriOrani);

            Button evFotoKlasoruAc = new Button();
            evFotoKlasoruAc.Name = "evFotoKlasoruAc";
            evFotoKlasoruAc.Text = "Fotoğraflar";
            evFotoKlasoruAc.Size = new Size(200, 40);
            evFotoKlasoruAc.Location = new Point(490, 270);
            evFotoKlasoruAc.Font = new Font("Segue UI", 12);
            evFotoKlasoruAc.Click += (sender, e) =>
            {
                System.Diagnostics.Process.Start("explorer.exe", ev.EvinFotograflariKlasoru);
            };
            evAyrintilariPanel.Controls.Add(evFotoKlasoruAc);

            Button duzenleyeGit = new Button();
            duzenleyeGit.Name = "duzenleyeGit";
            duzenleyeGit.Text = "Düzenle";
            duzenleyeGit.Size = new Size(200, 40);
            duzenleyeGit.Location = new Point(490, 325);
            duzenleyeGit.Font = new Font("Segue UI", 12);
            evAyrintilariPanel.Controls.Add(duzenleyeGit);
            duzenleyeGit.Tag = new ListeEventArgs(ev.EmlakNumarasi, _fiyat);
            duzenleyeGit.Click += duzenlemeEventHandler;

        }
        public static void evDuzenle(
            int _emlakNumarasi, 
            double _fiyat, 
            ref Panel duzenlemePanel,
            ref NumericUpDown duzenleOdaSayisiBox,
            ref NumericUpDown duzenleKatNumarasiBox,
            ref ComboBox duzenleIlceBox,
            ref ComboBox duzenleSemtBox,
            ref NumericUpDown duzenleGetiriYuzdesiBox,
            ref TextBox duzenleEvAlaniBox,
            ref NumericUpDown duzenleYapimYiliBox,
            ref NumericUpDown duzenleEmlakNumarasiBox,
            ref ComboBox duzenleEvCesidiBox,
            ref ComboBox duzenleEvTuruBox,
            ref ComboBox duzenleAktiflikBox
            )
        {
            Ev ev = evListesi.Find(ev => ev.EmlakNumarasi == _emlakNumarasi);
            KiralikEv kiralikEv = new KiralikEv();
            SatilikEv satilikEv = new SatilikEv();
            if (ev != null)
            {
                if (ev is KiralikEv)
                {
                    kiralikEv  = ev as KiralikEv;
                    duzenleOdaSayisiBox.Value = kiralikEv.OdaSayisi;
                    duzenleKatNumarasiBox.Value = kiralikEv.KatNumarasi;
                    duzenleIlceBox.SelectedItem = kiralikEv.Ilce;
                    duzenleSemtBox.SelectedItem = kiralikEv.Semt;
                    duzenleGetiriYuzdesiBox.Value = (decimal)kiralikEv.GetiriOrani * 100;
                    duzenleEvAlaniBox.Text = kiralikEv.Alan.ToString();
                    duzenleYapimYiliBox.Value = kiralikEv.YapimTarihi;
                    duzenleEmlakNumarasiBox.Value = kiralikEv.EmlakNumarasi;
                    duzenleEvCesidiBox.SelectedItem = kiralikEv.Cesit.ToString();
                    duzenleEvTuruBox.SelectedItem = kiralikEv is KiralikEv ? "Kiralık" : "Satılık";
                    duzenleAktiflikBox.SelectedItem = kiralikEv.IsAktif ? "Aktif" : "Aktif değil";
                }
                else if (ev is SatilikEv)
                {
                    satilikEv = ev as SatilikEv;
                    duzenleOdaSayisiBox.Value = satilikEv.OdaSayisi;
                    duzenleKatNumarasiBox.Value = satilikEv.KatNumarasi;
                    duzenleIlceBox.SelectedItem = satilikEv.Ilce;
                    duzenleSemtBox.SelectedItem = satilikEv.Semt;
                    duzenleGetiriYuzdesiBox.Value = (decimal)satilikEv.GetiriOrani * 100;
                    duzenleEvAlaniBox.Text = satilikEv.Alan.ToString();
                    duzenleYapimYiliBox.Value = satilikEv.YapimTarihi;
                    duzenleEmlakNumarasiBox.Value = satilikEv.EmlakNumarasi;
                    duzenleEvCesidiBox.SelectedItem = satilikEv.Cesit.ToString();
                    duzenleEvTuruBox.SelectedItem = satilikEv is KiralikEv ? "Kiralık" : "Satılık";
                    duzenleAktiflikBox.SelectedItem = satilikEv.IsAktif ? "Aktif" : "Aktif değil";
                }
            }


            
            
            
        }

        public static void evDuzenlemeKaydet(
            int _emlakNumarasi,
            double _fiyat,
            ref Panel kiralikEvlerSayfasi,
            ref Panel duzenlemePanel,
            ref NumericUpDown duzenleOdaSayisiBox,
            ref NumericUpDown duzenleKatNumarasiBox,
            ref ComboBox duzenleIlceBox,
            ref ComboBox duzenleSemtBox,
            ref NumericUpDown duzenleGetiriYuzdesiBox,
            ref TextBox duzenleEvAlaniBox,
            ref NumericUpDown duzenleYapimYiliBox,
            ref NumericUpDown duzenleEmlakNumarasiBox,
            ref ComboBox duzenleEvCesidiBox,
            ref ComboBox duzenleEvTuruBox,
            ref ComboBox duzenleAktiflikBox)
        {
            Ev ev = evListesi.Find(ev => ev.EmlakNumarasi == _emlakNumarasi);
            KiralikEv kiralikEv = new KiralikEv();
            SatilikEv satilikEv = new SatilikEv();

            if (ev != null)
            {
                if (ev is KiralikEv)
                {
                    kiralikEv = kiralikEvListesi.Find(ev => ev.EmlakNumarasi == _emlakNumarasi);

                    kiralikEv.OdaSayisi = Convert.ToInt32(duzenleOdaSayisiBox.Value);
                    kiralikEv.KatNumarasi = Convert.ToInt32(duzenleKatNumarasiBox.Value);
                    kiralikEv.Semt = duzenleSemtBox.SelectedItem.ToString() ?? "Bilinmiyor";
                    kiralikEv.Ilce = duzenleIlceBox.SelectedItem.ToString() ?? "Bilinmiyor";
                    kiralikEv.Alan = Convert.ToDouble(duzenleEvAlaniBox.Text);
                    kiralikEv.Cesit = (Ev.EvCesidi)Enum.Parse(typeof(Ev.EvCesidi), duzenleEvCesidiBox.SelectedItem.ToString() ?? "Bilinmiyor");
                    kiralikEv.YapimTarihi = Convert.ToInt32(duzenleYapimYiliBox.Value);
                    kiralikEv.EmlakNumarasi = Convert.ToInt32(duzenleEmlakNumarasiBox.Value);
                    kiralikEv.GetiriOrani = Convert.ToDouble(duzenleGetiriYuzdesiBox.Value) / 100;
                    kiralikEv.IsAktif = duzenleAktiflikBox.SelectedItem.ToString() == "Aktif" ? true : false;

                    ev = kiralikEv;

                    evleriDosyayaYaz();
                    evListesi.Clear();
                    evleriDosyadanOku();
                    

                }
                else if (ev is SatilikEv)
                {
                    satilikEv = satilikEvListesi.Find(ev => ev.EmlakNumarasi == _emlakNumarasi);

                    satilikEv.OdaSayisi = Convert.ToInt32(duzenleOdaSayisiBox.Value);
                    satilikEv.KatNumarasi = Convert.ToInt32(duzenleKatNumarasiBox.Value);
                    satilikEv.Semt = duzenleSemtBox.SelectedItem.ToString() ?? "Bilinmiyor";
                    satilikEv.Ilce = duzenleIlceBox.SelectedItem.ToString() ?? "Bilinmiyor";
                    satilikEv.Alan = Convert.ToDouble(duzenleEvAlaniBox.Text);
                    satilikEv.Cesit = (Ev.EvCesidi)Enum.Parse(typeof(Ev.EvCesidi), duzenleEvCesidiBox.SelectedItem.ToString() ?? "Bilinmiyor");
                    satilikEv.YapimTarihi = Convert.ToInt32(duzenleYapimYiliBox.Value);
                    satilikEv.EmlakNumarasi = Convert.ToInt32(duzenleEmlakNumarasiBox.Value);
                    satilikEv.GetiriOrani = Convert.ToDouble(duzenleGetiriYuzdesiBox.Value) / 100;
                    satilikEv.IsAktif = duzenleAktiflikBox.SelectedItem.ToString() == "Aktif" ? true : false;

                    ev = satilikEv;

                    evleriDosyayaYaz();
                    evListesi.Clear();
                    evleriDosyadanOku();
                }
            }
        }

        public static void evKayidiSil(
            int emlakNumarasi, 
            ref Panel sorguSonucSayfasi,
            ref Panel sorguSonucPanel,
            ref Panel kiralikEvlerListePanel,
            ref Panel satilikEvlerListePanel,
            ref Panel satilikEvlerSayfasi,
            ref Panel kiralikEvlerSayfasi,
            ref Panel yeniEvKayitPanel,
            ref Panel yeniSorguPanel,
            ref Panel kiralikEvlerPanel,
            ref Panel satilikEvlerPanel,
            EventHandler DynamicPanel_Click,
            EventHandler duzenlemeSayfasinaGit_Click,
            EventHandler silmeIsleminiBaslat_Click,
            bool _isAktifOlmayanlariKiralikListedeGoster_,
            bool _isAktifOlmayanlariSatilikListedeGoster_,
            bool _isAktifOlmayanlariSorgulananListedeGoster_,
            bool isSorguSayfasi
            )
        {
            Ev ev = evListesi.Find(ev => ev.EmlakNumarasi == emlakNumarasi);
            KiralikEv kiralikEv = new KiralikEv();
            SatilikEv satilikEv = new SatilikEv();
            string evTuru = "Kiralık";

            if (!isSorguSayfasi)
            {
                if (ev is KiralikEv)
                {
                    kiralikEv = kiralikEvListesi.Find(ev => ev.EmlakNumarasi == emlakNumarasi);
                    kiralikEvListesi.Remove(kiralikEv);
                    evTuru = "Kiralık";

                }
                else if (ev is SatilikEv)
                {
                    satilikEv = satilikEvListesi.Find(ev => ev.EmlakNumarasi == emlakNumarasi);
                    satilikEvListesi.Remove(satilikEv);
                    evTuru = "Satılık";
                }
            }
            else if (isSorguSayfasi )
            {
                if (ev is KiralikEv)
                {
                    kiralikEv = kiralikEvListesi.Find(ev => ev.EmlakNumarasi == emlakNumarasi);
                    kiralikEvListesi.Remove(kiralikEv);
                    evTuru = "Sorgu";

                }
                else if (ev is SatilikEv)
                {
                    satilikEv = satilikEvListesi.Find(ev => ev.EmlakNumarasi == emlakNumarasi);
                    satilikEvListesi.Remove(satilikEv);
                    evTuru = "Sorgu";
                }
            }
            

            evListesi.Remove(ev);

            evleriDosyayaYaz();
            evListesi.Clear();
            evleriDosyadanOku();

            if (evTuru == "Kiralık")
            {
                kiralikEvleriListele(
                ref kiralikEvlerListePanel,
                DynamicPanel_Click,
                duzenlemeSayfasinaGit_Click,
                _isAktifOlmayanlariKiralikListedeGoster_,
                ref isSorguSayfasi,
                silmeIsleminiBaslat_Click);

                kiralikEvlerSayfasi.BringToFront();
                yeniEvKayitPanel.BackColor = Color.SeaGreen;
                yeniSorguPanel.BackColor = Color.SeaGreen;
                kiralikEvlerPanel.BackColor = Color.MediumAquamarine;
                satilikEvlerPanel.BackColor = Color.SeaGreen;
            }
            else if (evTuru == "Satılık")
            {
                satilikEvleriListele(
                ref satilikEvlerListePanel,
                DynamicPanel_Click,
                duzenlemeSayfasinaGit_Click,
                _isAktifOlmayanlariSatilikListedeGoster_,
                ref isSorguSayfasi,
                silmeIsleminiBaslat_Click);

                satilikEvlerSayfasi.BringToFront();
                yeniEvKayitPanel.BackColor = Color.SeaGreen;
                yeniSorguPanel.BackColor = Color.SeaGreen;
                kiralikEvlerPanel.BackColor = Color.SeaGreen;
                satilikEvlerPanel.BackColor = Color.MediumAquamarine;
            }
            else if (evTuru == "Sorgu")
            {
                sorgulananEvleriListele(
                ref sorguSonucPanel,
                DynamicPanel_Click,
                duzenlemeSayfasinaGit_Click,
                _isAktifOlmayanlariSorgulananListedeGoster_,
                ref isSorguSayfasi,
                silmeIsleminiBaslat_Click);

                sorguSonucSayfasi.BringToFront();
                yeniEvKayitPanel.BackColor = Color.SeaGreen;
                yeniSorguPanel.BackColor = Color.MediumAquamarine;
                kiralikEvlerPanel.BackColor = Color.SeaGreen;
                satilikEvlerPanel.BackColor = Color.SeaGreen;
            }
        }

        public static string sorguyuGonder(
            NumericUpDown sorgulamaMinFiyatNumeric,
            NumericUpDown sorgulamaMaxFiyatNumeric,
            //ComboBox sorgulamaAktiflikBox,
            ComboBox sorgulamaIlceBox,
            ComboBox sorgulamaSemtBox,
            ComboBox sorgulamaEvTuruBox,
            ComboBox sorgulamaEvCesidiBox,
            NumericUpDown sorgulamaOdaSayisiNumeric,
            NumericUpDown sorgulamaMinAlanNumeric,
            ref Panel sorguListePanel,
            EventHandler ayrintiEventHandler,
            EventHandler duzenleEventHandler,
            bool aktifOlmayanGoster,
            bool isSorguSayfasi,
            EventHandler silmeEventHandler
            )
        {
            sorguListesi.Clear();
            var yeniSorgu = evListesi.AsQueryable();
            
            //sorgulamaAktiflikBox.Sele

            int minFiyat = sorgulamaMinFiyatNumeric != null ? Convert.ToInt32(sorgulamaMinFiyatNumeric.Value) : 0;
            int maxFiyat = sorgulamaMaxFiyatNumeric != null ? Convert.ToInt32(sorgulamaMaxFiyatNumeric.Value) : 0;
            //string aktiflik = sorgulamaAktiflikBox.Text == "Farketmez" ? "Aktif" : sorgulamaAktiflikBox.SelectedItem.ToString();
            string ilce = sorgulamaIlceBox.Text == "Farketmez" ? "" : sorgulamaIlceBox.SelectedItem.ToString();
            string semt = sorgulamaSemtBox.Text == "Farketmez" ? "" : sorgulamaSemtBox.SelectedItem.ToString();
            string evTuru = sorgulamaEvTuruBox.Text == "Farketmez" ? "" : sorgulamaEvTuruBox.SelectedItem.ToString();
            string evCesidi = sorgulamaEvCesidiBox.Text == "Farketmez" ? "" : sorgulamaEvCesidiBox.SelectedItem.ToString();
            int odaSayisi = sorgulamaOdaSayisiNumeric != null ? Convert.ToInt32(sorgulamaOdaSayisiNumeric.Value) : 0;
            double minAlan = sorgulamaMinAlanNumeric != null ? Convert.ToDouble(sorgulamaMinAlanNumeric.Value) : 0;
            
            



            if (minFiyat != 0)
            {
                yeniSorgu = yeniSorgu.Where(e => e.FiyatHesapla() >= (double)minFiyat);
            }

            if (maxFiyat != 0)
            {
                yeniSorgu = yeniSorgu.Where(e => e.FiyatHesapla() <= (double)maxFiyat);
            }

            
            

            if (ilce != "")
            {
                yeniSorgu = yeniSorgu.Where(e => e.Ilce == ilce);
            }

            if (semt != "")
            {
                yeniSorgu = yeniSorgu.Where(e => e.Semt == semt);
            }

            if (evTuru != "")
            {
                if (evTuru == "Kiralık")
                {
                    yeniSorgu = yeniSorgu.Where(e => e is KiralikEv);
                }
                else if (evTuru == "Satılık")
                {
                    yeniSorgu = yeniSorgu.Where(e => e is SatilikEv);
                }
            }

            if (evCesidi != "")
            {
                yeniSorgu = yeniSorgu.Where(e => e.Cesit.ToString() == evCesidi);
            }

            if (odaSayisi != 0)
            {
                yeniSorgu = yeniSorgu.Where(e => e.OdaSayisi == odaSayisi);
            }

            if (minAlan != 0)
            {
                yeniSorgu = yeniSorgu.Where(e => e.Alan >= minAlan);
            }

            sorguListesi = yeniSorgu.ToList();

            if (sorguListesi.Count != 0)
            {
                
                sorgulananEvleriListele(
                    ref sorguListePanel,
                    ayrintiEventHandler,
                    duzenleEventHandler,
                    aktifOlmayanGoster,
                    ref isSorguSayfasi,
                    silmeEventHandler

                    );

                return $"{sorguListesi.Count} adet sonuç bulundu.";

            }
            else if (sorguListesi.Count == 0 || sorguListesi is null)
            {
                return "Sorgu sonucu bulunamadı.";
            }
            else
            {
                return "Sorguda bir hata oluştu.";
            }
        }
        
    }
}
