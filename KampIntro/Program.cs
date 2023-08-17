using System;

class MyClass
{
    public static void Main(string[] args)
    {
        string kategoriEtiket = "kategori";
        int ogrenciSayisi = 132376374;
        double faizOrani = 1.45;
        bool sistemeGirisYapmismi = false;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("aşağıya ok");
        }
        else if(dolarDun < dolarBugun)
        {
            Console.WriteLine("artış");
        }
        else
        {
            Console.WriteLine("equal");
        }

        if (sistemeGirisYapmismi== true)
        {
            Console.WriteLine("Kullanıcı ayarlar butonu");
        }
        else {
            Console.WriteLine("giriş yap");
        }
        Console.WriteLine(kategoriEtiket);



    }   
}
