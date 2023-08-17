
class Program
{
    static void Main(string[] args)
    {
        string kurs1 = "yazılım geliştrime kampı";
        string kurs2 = "programlamaya başlangıç için temel kurs";
        string kurs3 = "java";
        int fiyat = 99;

        //array - dizi 

        string[] kurslar = new string[] { "yazılım geliştrime kampı", 
            "programlamaya başlangıç için temel kurs", "java" };


        for (int i = 0; i <kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("--------------------------");
        //foreach dizileri tek tek dolaşmaya yarar.
        foreach (string item in kurslar)
        {
            Console.WriteLine(item);
        }
    }
}
