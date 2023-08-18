using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            string Id = "Bradd Pit";
            
            Customer customer = new Customer();
            customer.Id = 111111;
            customer.Name = "Henry ";
            customer.Surname = "Cavil";

            Customer customer2 = new Customer();
            customer2.Id = 7834678;
            customer2.Name = "Tom";
            customer2.Surname = "Cruise";

            Customer customer3 = new Customer();
            customer3.Id = 11118;
            customer3.Name = "Dwayne ";
            customer3.Surname = "Johnson";

            //Customer[] customers = new Customer[] {customer, customer2, customer3 };

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item);
            //}

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer2);
            customerManager.Delete(customer3);

        }
    }

}

