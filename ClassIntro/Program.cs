class Program
{
    static void Main(string[] args)
    {
        //string adi = "engin";
        //byte yas = 100;

        Kurs kurs1 = new Kurs();   //bu objeninin tipi kurs.. 
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "busra ckmakc";
        kurs1.IzlenmeOrani = 33;


        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "java";
        kurs2.Egitmen = "busra ckmakc";
        kurs2.IzlenmeOrani = 63;


        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "phyton";
        kurs3.Egitmen = "busra ckmakc";
        kurs3.IzlenmeOrani = 80;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "javascript";
        kurs4.Egitmen = "Murat kurtboğan";
        kurs4.IzlenmeOrani = 45897;


        Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
        }

        ////Ternary Operator

        //int x = 10;
        //int y = 5;


        //int result;

        //result = x < y ? y : x;
        //Console.WriteLine(result);

        ////haftasonu hangi gün

        //Console.WriteLine("lütfen bir sayı giriniz");
        //int sayi = Int32.Parse(Console.ReadLine());

        //switch (sayi)
        //{
        //    case 1:
        //        Console.WriteLine("cumartesi"); break;
        //    case 2:
        //        Console.WriteLine("pazar"); break;
        //    default:
        //        Console.WriteLine("böyle bir gün yok"); break;

        //}

    }
}



class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}
