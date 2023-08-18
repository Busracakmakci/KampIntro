//Bir bankada müşteri takibi yapmak istiyorsunuz.
//Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme,
//listeleme, silme gibi metotları simule ediniz.

using ClassMetotDemo;

namespace Program
{
    class CustomerManager
    {


         public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " nolu " + customer.Name + " isimli " + customer.Surname + " eklendi! ");
        }

        
        public void Delete(Customer customer) 
        {
            Console.WriteLine(customer.Id + " nolu " + customer.Name + " isimli " + customer.Surname + " silindi! ");
        }
    }
}