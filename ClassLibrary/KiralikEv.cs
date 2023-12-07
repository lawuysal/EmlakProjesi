using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProjesi.ClassLibrary
{
    public class KiralikEv : Ev
    {
        // Extra Fields
        private string kiraciAdi = "Bilinmiyor";
        private int kiraSuresi = 0;
        private int depozito = 20000;
        private bool depozitoDurumu = false;

        // Extra Properties
        public string KiraciAdi
        {
            get
            {
                return kiraciAdi;
            }
            set
            {
                kiraciAdi = value;
            }
        }
        public int KiraSuresi
        {
            get
            {
                return kiraSuresi;
            }
            set
            {
                if (value <= 0)
                {
                    // TODO: Log the error
                    kiraSuresi = 0;
                }
                else
                {
                    kiraSuresi = value;
                }
            }
        }
        public int Depozito
        {
            get
            {
                return depozito;
            }
            set
            {
                if (value <= 0)
                {
                    // TODO: Log the error
                }
                else
                {
                    depozito = value;
                }
            }
        }
        private bool DepozitoDurumu
        {
            get
            {
                return depozitoDurumu;
            }
            set
            {
                depozitoDurumu = value;
            }
        }

        // Constructors
        public KiralikEv()
        {
        }
        public KiralikEv(int odaSayisi, int katNumarasi, string semt, double alan, int yapimTarihi)
            : base(odaSayisi, katNumarasi, semt, alan, yapimTarihi)
        {
        }
        public KiralikEv(int katNumarasi, string semt, double alan): base(katNumarasi, semt, alan)
        {
        }
        public KiralikEv(int odaSayisi, int katNumarasi, double alan) : base(odaSayisi, katNumarasi, alan)
        {
        }

        // Methods
        
        // Overriding the base class method EvBilgileri()
        public override string EvBilgileri()
        {
            // TODO: Log that the house information requested
            string aktiflikDurumu;
            string depozitoDurumuString;
            if (IsAktif)
            {
                aktiflikDurumu = "Aktif";
            }
            else
            {
                aktiflikDurumu = "Aktif değil";
            }
            if (DepozitoDurumu)
            {
                depozitoDurumuString = "Depozito alindi";
            }
            else
            {
                depozitoDurumuString = "Depozito alinmadi";
            }
            string bilgiler = string.Format(
                "Oda Sayisi: {0}\n" +
                "Kat Numarasi {1}\n" +
                "Semt: {2}\n" +
                "Alani: {3}\n" +
                "Yapim Tarihi: {4}\n" +
                "Bina Yasi: {5}\n" +
                "Aktflik Durumu: {6}\n" +
                "Emlak Numarasi: {7}\n" +
                "Ev Cesidi: {8}\n" +
                "Kiraci Adi: {9}\n" +
                "Kira Suresi: {10}\n" +
                "Depozito: {11}\n" +
                "Depozito Durumu: {12}\n",
                OdaSayisi,
                KatNumarasi,
                Semt,
                Alan,
                YapimTarihi,
                BinaYasi,
                aktiflikDurumu,
                EmlakNumarasi,
                EvCesidiParser(),
                KiraciAdi,
                KiraSuresi,
                Depozito,
                depozitoDurumuString
                );
            return bilgiler;
        }
        public double KiraHesapla()
        {
            double kira = FiyatHesapla();
            return kira;
        }

    }
}
