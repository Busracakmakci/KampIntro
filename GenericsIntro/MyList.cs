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
            items = new T[items.Length + 1]; //sürekli newledikçe referans değişir. Elemanlar uçmasın diye geçici oluşturduk.
            for (int i = 0; i < tempArray.Length; i++)   //geçici dizi oluştuğunda her yeni oluşan diziye ekler.
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
        public int Length    //eleman sayısını verir
        {
            get { return items.Length;  }
        }

        public T[] Length1
        {
            get { return items; }
        }

        public IEnumerable<object> Items { get; internal set; }
    }
}
