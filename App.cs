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
         
    }
}
