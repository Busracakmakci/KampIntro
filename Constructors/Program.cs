namespace Constructors
{
    class Program
    {
        public void Main(string[] args) {
            Customer customer = new Customer { Id = 1, FirstName = "Engin", lastName="Çakmak", City="Ankara" };
            Customer customer3 = new Customer();
            customer3.Id = 2;
            Customer customer2 = new Customer(2, "Derin", "Demir", "Ankara");
            Console.WriteLine(customer2.FirstName);
        }
  
    }
    class Customer
    {
        public Customer() { }

        //default constructor
        public Customer(int id, string firstName, string lastName, string city) 
        {
            //yazmasak bile yapıcı blok çalışır.
            Id = id;
            FirstName = firstName;
            lastName = lastName;
            City = city;


        } 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string City { get; set; }
    }
}