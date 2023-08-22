using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ornek
{
    class Dictionary //Girilen kelimedeki farklı harf sayısını vermek
    {
        static void Main(string[] args)
        { 
        Dictionary<string, int> Authorlist = new Dictionary<string, int>();
            Authorlist.Add("Peyami Safa", 89);
            Authorlist.Add("Dostoyevski", 34);
            Authorlist.Remove("Dostoyevski");
            Authorlist.Add("Cemal Süreyya", 17);
           // Authorlist.Clear();

            Console.WriteLine("Authorlist");
            foreach (KeyValuePair<string, int> author in Authorlist)
            {
                Console.WriteLine("Key: {0}, Value : {1}" , author.Key, author.Value );
            }

        }
     
    }
}
//ContainsKey(Aranan_Key) –> True veya False döner.
//ContainsValue(Aranan_Value) –> True veya False döner.
//Clear(); –> Dictionary içindeki tüm değerleri siler
//Count; –> Dictionary içeriğindeki veri çiftlerinin sayısını döner.
//Remove(Key_Değeri) –> yazılan key i bulup siler. key varsa ve silindi ise True yoksa False Döner.
//Keys
//Values
//KeyValuePair<Key_Tipi, Value_Tipi>
//TryGetValue(a ,out b)
