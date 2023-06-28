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
        public abstract string KategoriaVAT { get; }
        public abstract decimal CenaBrutto { get; }
        public string KrajPochodzenia { get; set; }
    }
}