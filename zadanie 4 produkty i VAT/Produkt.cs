using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static zadanie_4_produkty_i_VAT.IProdukt;

namespace zadanie_4_produkty_i_VAT
{
    public abstract class Produkt : IProdukt
    {
        public string Nazwa { get; set; }
        public decimal CenaNetto { get; set; }
        public abstract decimal VAT { get; }
        public decimal CenaBrutto => CenaNetto * (1 + VAT / 100);
        public string KrajPochodzenia { get; set; }
        public string KategoriaVAT { get; set; }

        protected static Dictionary<string, decimal> VATDictionary = new Dictionary<string, decimal>()
    {
        { "0%", 0 },
        { "5%", 5 },
        { "8%", 8 },
        { "23%", 23 }
    };
    }

    public class ProduktSpozywczy : Produkt
    {
        public override decimal VAT => VATDictionary[KategoriaVAT];
    }

    public class ProduktSpozywczyNaWage : ProduktSpozywczy
    {
        public decimal Waga { get; set; }
    }

    public class ProduktSpozywczyPaczka : ProduktSpozywczy
    {
        public decimal Waga { get; set; }
    }

    public class ProduktSpozywczyNapoj<T> : ProduktSpozywczyPaczka
    {
        public T Objetosc { get; set; }
    }

    public class Wielopak<T> : IWielopak<T> where T : IProdukt
    {
        public T Produkt { get; set; }
        public ushort Ilosc { get; set; }
        public decimal CenaNetto { get; set; }

        public decimal CenaBrutto => Produkt.CenaNetto * Ilosc * (1 + Produkt.VAT / 100);
        public string KategoriaVAT => Produkt.KategoriaVAT;
        public string KrajPochodzenia => Produkt.KrajPochodzenia;
    }

}
