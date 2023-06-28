using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_produkty_i_VAT
{
    public class Wielopak<T> : IWielopak<T> where T : IProdukt
    {
        public T Produkt { get; set; }
        public ushort Ilosc { get; set; }
        public decimal CenaNetto { get; set; }

        public decimal CenaBrutto => Produkt.CenaBrutto * Ilosc;
        public string KategoriaVAT => Produkt.KategoriaVAT;
        public string KrajPochodzenia => Produkt.KrajPochodzenia;
    }
}
