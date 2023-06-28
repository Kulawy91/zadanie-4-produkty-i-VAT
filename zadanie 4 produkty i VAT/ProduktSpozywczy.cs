using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_produkty_i_VAT
{
    public class ProduktSpozywczy : Produkt
    {
        public override string KategoriaVAT => "Spozywczy";
        public override decimal CenaBrutto => CenaNetto * 1.23m;
        public decimal Kalorie { get; set; }
        public HashSet<string> Alergeny { get; set; }
    }
}
