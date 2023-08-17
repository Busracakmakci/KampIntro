namespace Metotlar
{
    class Program
    {
        static void Main(string[] atgs)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyati = 67889;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.fiyati = 109;
            urun2.Aciklama = "atça karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("---------------Metotlar---------------");

            //instance
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,7);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 13, 7);
            sepetManager.Ekle2("elma", "amasya elması", 47,2);

        }
    }
}
