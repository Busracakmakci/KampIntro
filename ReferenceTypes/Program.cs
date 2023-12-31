﻿namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal,float, enum, boolean value type

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;      //değer eşitlemesi yapılıyor.
            sayi2 = 100;

            Console.WriteLine("SAyı1 :" + sayi1);

            //array, class, interface.. reference type
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("sayilar[0]= " + sayilar1[0]);
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;            //adres eşitlemesi yapılıyor..
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            Employee employee = new Employee();


            Person person3 = customer;
            customer.FirstName = "ahmet";

            Console.WriteLine(person3.FirstName);

            Console.WriteLine(((Customer)person3).CreditCardNumber);  //neye boxing yapacağını söylemiş oluyorsunuz.

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class : person
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person) { }
    }
}
