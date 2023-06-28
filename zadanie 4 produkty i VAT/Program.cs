using System;
using System.Collections.Generic;
using zadanie_4_produkty_i_VAT;

class Program
{
    static void Main()
    {
        var produktSpozywczy = new ProduktSpozywczy()
        {
            Nazwa = "Chleb",
            CenaNetto = 3.5m,
            KrajPochodzenia = "Polska",
            Kalorie = 200,
            Alergeny = new HashSet<string> { "Gluten" }
        };

        var wielopak = new Wielopak<ProduktSpozywczy>()
        {
            Produkt = produktSpozywczy,
            Ilosc = 10,
            CenaNetto = 30
        };

        Console.WriteLine("Informacje o produkcie:");
        Console.WriteLine($"Nazwa: {wielopak.Produkt.Nazwa}");
        Console.WriteLine($"Cena netto pojedynczego produktu: {wielopak.Produkt.CenaNetto}");
        Console.WriteLine($"Kategoria VAT: {wielopak.Produkt.KategoriaVAT}");
        Console.WriteLine($"Cena brutto wielopaku: {wielopak.CenaBrutto}");
        Console.WriteLine($"Kraj pochodzenia: {wielopak.Produkt.KrajPochodzenia}");
        Console.WriteLine($"Kalorie: {wielopak.Produkt.Kalorie}");
        Console.WriteLine("Alergeny:");
        foreach (var alergen in wielopak.Produkt.Alergeny)
        {
            Console.WriteLine(alergen);
        }
    }
}

