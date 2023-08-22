
using GenericsIntro;
using Microsoft.VisualBasic;
using System;
namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Busra");
            isimler.Add("Busra");

            Console.WriteLine(isimler.Length);
           

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }

     

          
        
    }
}
