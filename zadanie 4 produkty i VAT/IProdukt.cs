﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_produkty_i_VAT
{
    public interface IProdukt
    {
        string Nazwa { get; set; }
        decimal CenaNetto { get; set; }
        string KategoriaVAT { get; }
        decimal CenaBrutto { get; }
        string KrajPochodzenia { get; set; }
    }

    public interface IWielopak<T> where T : IProdukt
    {
        T Produkt { get; set; }
        ushort Ilosc { get; set; }
        decimal CenaNetto { get; set; }
        decimal CenaBrutto { get; }
        string KategoriaVAT { get; }
        string KrajPochodzenia { get; }
    }

}

