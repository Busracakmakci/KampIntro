namespace Generics

{ class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
       

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("izmir");
        }
    }
    class MyList<T>    //Generic classs
    {
        public void Add(T item)
        {

        }

    }

}