using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_produkty_i_VAT
{
    public abstract class Produkt : IProdukt
    {
        public string Nazwa { get; set; }
        public decimal CenaNetto { get; set; }
        public abstract decimal VAT { get; }
        public decimal CenaBrutto => CenaNetto * (1 + VAT / 100);
        public string KrajPochodzenia { get; set; }
        public abstract string KategoriaVAT { get; }
    }

    public class ProduktSpozywczy : Produkt
    {
        public override decimal VAT => 23;
        public override string KategoriaVAT => "23%";
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

        public decimal CenaBrutto => Produkt.CenaBrutto * Ilosc;
        public string KategoriaVAT => Produkt.KategoriaVAT;
        public string KrajPochodzenia => Produkt.KrajPochodzenia;
    }

}
