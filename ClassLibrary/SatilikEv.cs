using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProjesi.ClassLibrary
{
    public class SatilikEv : Ev
    {
        // Extra Fields
        private string evSahibiAdi = "Bilinmiyor";

        // Extra Properties
        public string EvSahibiAdi
        {
            set
            {
                evSahibiAdi = value;
            }
            get
            {
                return evSahibiAdi;
            }
        }

        // Constructorlar
        public SatilikEv()
        {
        }
        public SatilikEv(int odaSayisi, int katNumarasi, string semt, double alan, int yapimTarihi)
            : base(odaSayisi, katNumarasi, semt, alan, yapimTarihi)
        {
        }
        public SatilikEv(int katNumarasi, string semt, double alan) : base(katNumarasi, semt, alan)
        {
        }
        public SatilikEv(int odaSayisi, int katNumarasi, double alan) : base(odaSayisi, katNumarasi, alan)
        {
        }

        // Metodlar
        public override string EvBilgileri()
        {
            // TODO: Log that the house information requested
            string aktiflikDurumu;
            if (IsAktif)
            {
                aktiflikDurumu = "Aktif";
            }
            else
            {
                aktiflikDurumu = "Aktif değil";
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
                "Ev Sahibi Adi: {9}\n" +
                OdaSayisi,
                KatNumarasi,
                Semt,
                Alan,
                YapimTarihi,
                BinaYasi,
                aktiflikDurumu,
                EmlakNumarasi,
                EvCesidiParser(),
                EvSahibiAdi
                );
            return bilgiler;
        }
        public double SatisFiyatHesapla ()
        {
            double kira = FiyatHesapla();
            return (kira*12)/GetiriOrani;
        }
    }   
}
