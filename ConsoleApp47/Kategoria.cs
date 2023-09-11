using System;
using System.Collections.Generic;
using System.Text;

namespace _230905
{
    internal class Kategoria
    {
        public string KategoriaNeve { get; set; }
        public int TulelokSzama { get; set; }
        public int EltuntekSzama { get; set; }


        public Kategoria(string beolvasottSor)
        {
            var darabok = beolvasottSor.Split(';');
            this.KategoriaNeve = darabok[0];
            this.TulelokSzama = int.Parse(darabok[1]);
            this.EltuntekSzama = int.Parse(darabok[2]);
        }
    }
}