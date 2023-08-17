using System;
using static System.Formats.Asn1.AsnWriter;

class Product
{
    static void Main(string[] args)
    {
        Scooter Scooter1 = new Scooter();
        Scooter1.ScooterAdi = "onvo";
        Scooter1.Kargo = "kargo bedava";
        Scooter1.Fiyat = "19.773 Tl";

        Scooter Scooter2 = new Scooter();
        Scooter2.ScooterAdi = "vsett";
        Scooter2.Kargo = "kargo bedava";
        Scooter2.Fiyat = "37.373 Tl";

        Scooter[] scooterlar = new Scooter[] { Scooter1, Scooter2 };

       
        /*
        for (int i = 0; i< scooterlar.Length;i++)
        {
            Console.WriteLine("Scooter Adı: " + scooterlar[i].ScooterAdi);
            Console.WriteLine("Kargo: " + scooterlar[i].Kargo);
            Console.WriteLine("Fiyat: " + scooterlar[i].Fiyat);
            Console.WriteLine("---------------------");
        }

        */

     int i = 0;
     while (i < scooterlar.Length)
        {
         
       Console.WriteLine("Scooter Adı: " + scooterlar[i].ScooterAdi);
       Console.WriteLine("Kargo: " + scooterlar[i].Kargo);
       Console.WriteLine("Fiyat: " + scooterlar[i].Fiyat);
       Console.WriteLine("---------------------");
            i++;
        };    



        foreach (var scoot in scooterlar)
        {
            Console.WriteLine("Scooter Adı: " + scoot.ScooterAdi);
            Console.WriteLine("Kargo: " + scoot.Kargo);
            Console.WriteLine("Fiyat: " + scoot.Fiyat);
            Console.WriteLine("---------------------");
        }
    }
}

class Scooter
{
    public string ScooterAdi { get; set; }
    public string Kargo { get; set; }
    public string Fiyat { get; set; }
}



