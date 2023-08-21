using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>   ///<T> bana bir tip ver.
    {
      T[] items;                
        //constructor : class ile aynı isme sahip bir metot...
        public MyList()
        {
            items = new T[0]; // sıfır elemanlı array oluşturuldu.
        }

        public void Add(T item) {
            T[] tempArray = items;      //geçici dizi oluştur.
            items = new T[items.length+1]; //sürekli newledikçe referans değişir. Elemanlar uçmasın diye geçici oluşturduk.
            for (int i = 0; i < tempArray.length; i++)   //geçici dizi oluştuğunda her yeni oluşan diziye ekler.
            {
                items[i] = tempArray[i];
            }
            items[items.length - 1] = item;

        }
    }
}
