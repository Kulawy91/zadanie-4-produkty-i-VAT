using System;
using System.Collections.Generic;
using zadanie_4_produkty_i_VAT;

class Program
{
    static void Main()
    {
        // Przykładowe użycie klas i interfejsów
        var produktSpozywczy = new ProduktSpozywczy()
        {
            Nazwa = "Jabłko",
            CenaNetto = 2.5m,
            KrajPochodzenia = "Polska"
        };

        var wielopak = new Wielopak<ProduktSpozywczy>()
        {
            Produkt = produktSpozywczy,
            Ilosc = 5,
            CenaNetto = 10
        };

        Console.WriteLine($"Nazwa produktu: {wielopak.Produkt.Nazwa}");
        Console.WriteLine($"Cena brutto wielopaku: {wielopak.CenaBrutto}");
        Console.WriteLine($"Kraj: {wielopak.KrajPochodzenia}");
        Console.WriteLine($"Vat: {wielopak.KategoriaVAT}");

        Console.ReadLine();
    }
}
