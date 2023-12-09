using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakProjesi.ClassLibrary;
using Newtonsoft.Json;


namespace EmlakProjesi

{
    
    internal class App
    {
        public static List<Ev> evListesi = new List<Ev>();
        public static List<KiralikEv> kiralikEvListesi = new List<KiralikEv>();
        public static List<SatilikEv> satilikEvListesi = new List<SatilikEv>();
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
        public static void kiralikEvleriListele(ref Panel listePanel, EventHandler eventHandler)
        {
            listePanel.AutoScroll = true;
            int i = 0;
            while (i < kiralikEvListesi.Count)
            {
                Panel myPanel = new Panel();
                myPanel.Name = "kiralikEv" + i.ToString();
                myPanel.Size = new Size(750, 100);
                myPanel.Location = new Point(100, 50 + (i * 130));
                myPanel.BackColor = Color.White;
                listePanel.Controls.Add(myPanel);
                myPanel.Tag = new ListeEventArgs(kiralikEvListesi[i].EmlakNumarasi);
                myPanel.Click += eventHandler;

                Label konum = new Label();
                konum.Name = "konum" + i.ToString();
                konum.Text = (i+1) + "-) " + kiralikEvListesi[i].Ilce + ", " + 
                    kiralikEvListesi[i].Semt + "  |  " + kiralikEvListesi[i].FiyatHesapla() + " TL";
                konum.Size = new Size(600, 25);
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

                i++;
            }
        }
        public static void evAyrintilariGoster(int emlakNumarasi, ref Panel evAyrintilariLabel)
        {
            Ev ev = evListesi.Find(ev => ev.EmlakNumarasi == emlakNumarasi);
            evAyrintilariLabel.Text = ev.EvBilgileri();
        }
         
    }
}
