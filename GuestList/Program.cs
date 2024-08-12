using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ziyaretçilerin isimlerini tutan bir liste oluşturuyoruz.
        List<string> guestNames = new List<string>
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        // Listeyi ekrana yazdırıyoruz.
        Console.WriteLine("Gala gecesine davetli ziyaretçiler:");
        foreach (string guestName in guestNames)
        {
            Console.WriteLine(guestName);
        }
    }
}
