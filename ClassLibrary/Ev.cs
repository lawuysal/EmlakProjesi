using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProjesi.ClassLibrary
{
    public abstract class Ev
    {
        public enum EvCesidi
        {
            Daire,
            Bahceli,
            Mustakil,
            Dubleks,
            Studyo,
            Belirtilmemis
        };

        // Fields
        private int odaSayisi = -99;
        private int katNumarasi = -99;
        private string semt = "Bilinmiyor";
        private double alan = -99.0;
        private int yapimTarihi = 2999;
        private bool isAktif = true;
        private int emlakNumarasi = -99;
        static private List<int> emlakNumarasiListesi = new List<int>();
        private EvCesidi cesit = EvCesidi.Belirtilmemis;
        private double getiriOrani = 1.0d;
        private string evinFotograflariKlasorYolu = "Yok.";


        // Properties
        public int OdaSayisi
        {
            get
            {
                return odaSayisi;
            }
            set
            {
                if (value <= 0)
                {
                    odaSayisi = 0;
                }
                else
                {
                    odaSayisi = value;
                }

                //TODO: Log the Entered Value
            }
        }
        public int KatNumarasi
        {
            get
            {
                return katNumarasi;
            }
            set
            {
                if (value < -1)
                {
                    katNumarasi = 0;
                }
                else
                {
                    katNumarasi = value;
                }

                //TODO: Log the Entered Value
            }
        }
        public string Semt
        {
            get
            {
                return semt;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    semt = "Bilinmiyor";
                }
                else
                {
                    semt = value;
                }

                //TODO: Log the Entered Value
            }
        }
        public double Alan
        {
            get
            {
                return alan;
            }
            set
            {
                if (value <= 0)
                {
                    alan = 0;
                }
                else
                {
                    alan = value;
                }

                //TODO: Log the Entered Value
            }
        }
        public int YapimTarihi
        {
            get
            {
                return yapimTarihi;
            }
            set
            {
                if (value <= 1850 || value > DateTime.Now.Year)
                {
                    yapimTarihi = 2999;
                }
                else
                {
                    yapimTarihi = value;
                }

                //TODO: Log the Entered Value
            }
        }
        public bool IsAktif
        {
            get
            {
                return isAktif;
            }
            set
            {
                isAktif = value;

                //TODO: Log the Entered Value
            }
        }
        public int EmlakNumarasi
        {
            get
            {
                return emlakNumarasi;
            }
            set
            {
                if (value <= 100000 || value >= 99999)
                {
                    emlakNumarasi = -99;
                }
                if (!emlakNumarasiListesi.Contains(value))
                {
                    emlakNumarasi = value;
                }

                //TODO: Log the Entered Value
            }
        }
        public EvCesidi Cesit
        {
            get
            {
                return cesit;
            }
            set
            {
                cesit = value;

                //TODO: Log the Entered Value
            }
        }
        public int BinaYasi
        {      
        get
            {
                return DateTime.Now.Year - yapimTarihi;
            }
        }
        public double GetiriOrani
        {
            get
            {
                return getiriOrani;
            }
            set
            {
                if (value < 0.05 || value > 0.15 )
                {
                    getiriOrani = 1.0;
                }
                else
                {
                    getiriOrani = value;
                }
            }
        }
        public string EvinFotograflariKlasoru
        {
            get
            {
                return evinFotograflariKlasorYolu;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    evinFotograflariKlasorYolu = "Yok.";
                    // TODO: Log the entered value
                }
                else
                {
                    evinFotograflariKlasorYolu = value;
                }
            }
        }
        

        // Constructors
        public Ev ()
        { }
        public Ev (int odaSayisi, int katNumarasi, string semt, double alan, int yapimTarihi)
        {
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semt = semt;
            Alan = alan;
            YapimTarihi = yapimTarihi;
            // TODO: Log the created house
        }
        public Ev(int katNumarasi, string semt, double alan)
        {
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semt = semt;
            Alan = alan;

            // TODO: Log the created house
        } 
        public Ev(int odaSayisi, int katNumarasi,  double alan)
        {
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semt = semt;
            Alan = alan;

            // TODO: Log the created house
        }

        // Methods
        protected string EvCesidiParser()
        {
            switch (Cesit)
            {
                case EvCesidi.Daire:
                    return "Daire";
                case EvCesidi.Bahceli:
                    return "Bahceli";
                case EvCesidi.Mustakil:
                    return "Mustakil";
                case EvCesidi.Dubleks:
                    return "Dubleks";
                case EvCesidi.Studyo:
                    return "Studyo";
                case EvCesidi.Belirtilmemis:
                    return "Belirtilmemis";
                default:
                    return "Ev Cesidi Yok Hatasi";
            }
        }
        public abstract string EvBilgileri();
        public double FiyatHesapla()
        {
            // TODO: Log the function call
            int katSayi = 200;
            // Reading the file
            try
            {
                katSayi = int.Parse(System.IO.File.ReadAllText("room_cost.txt"));
            }
            catch (Exception ex)
            {
               // TODO: Log the exception
            }

            return (katSayi * odaSayisi * alan)/10;
        }
    }
}
