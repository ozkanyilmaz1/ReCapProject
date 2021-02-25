using System;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                Id = 2,
                RentDate = new DateTime(2021,03,01),
                ReturnDate = new DateTime(2021,03,05),
                CarId = 2,
                CustomerId= 4
                

            });
            customerManager.Add(new Customer
            {
                UserId = 1,
                CompanyName = "Gül Yapı",
                Id = 4
            });
            userManager.Add(new User
            {
                FirstName = "İlker",
                LastName = "Saroğlu",
                Email = "ilkkkk@deneme.com",
                Password = "ilkerkerem123"
            });
            userManager.Add(new User
            {
                FirstName = "Sezer",
                LastName = "Çavuş",
                Email = "cavusezer@deneme.com",
                Password = "3126cavu"
            });
            userManager.Add(new User
            {
                FirstName = "Enis",
                LastName = "Işık",
                Email = "enis@deneme.com",
                Password = "eniefe12"
            });

            foreach (var car2 in carManager.GetAll().Data)
            {
                Console.WriteLine("Arabanın ismi: " + car2.Brand + " " + car2.Description);
                Console.WriteLine("Model yılı: " + car2.ModelYear);
                Console.WriteLine("Renk adı: " + car2.Color);
                Console.WriteLine("Renk ID: " + car2.ColorId);
                Console.WriteLine("Fiyatı: " + car2.DailyPrice);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
