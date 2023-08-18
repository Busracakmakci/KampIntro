using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    class Metot
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Multiply(2, 3, 4));
            Console.WriteLine(Multiply(2, 3));

            //params için
            Console.WriteLine(Multiply(1,2,3,4,5));

 

        }
        static int Multiply(int sayi10, int sayi20)
        {
            return sayi20 * sayi10;
        }
        static int Multiply(int sayi10, int sayi20, int sayi30)
        {
            return sayi10 * sayi20 * sayi30;
        }

        //params keyword (tüm elemanları toplar)
        //params parametrenin son parametresi olmak zorunda.

        static int Multiply(params int[] numbers)
        {
            return numbers.Sum();
        }



    }
}
