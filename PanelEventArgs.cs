﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProjesi
{
    class ListeEventArgs : EventArgs
    {
        public int EmlakNumarasi { get; set; }
        public double Fiyat { get; set; }

        public ListeEventArgs(int emlakNumarasi, double fiyat)
        {
            EmlakNumarasi = emlakNumarasi;
            Fiyat = fiyat;
        }
    }
}
