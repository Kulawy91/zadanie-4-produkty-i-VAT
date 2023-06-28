using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_produkty_i_VAT
{
    public class ProduktSpozywczyNapoj<T> : ProduktSpozywczyPaczka
    {
        public T Objetosc { get; set; }
    }
}
