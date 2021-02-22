using System;
using Business.Concrete;
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
            Car car = new Car
            {
                Id = 7,
                BrandId = 6,
                ColorId = 2,
                ModelYear = "2021",
                DailyPrice = "250000",
                Color = "Beyaz",
                Brand = "Citroen",
                Description = "Hafif Ticari"
            };

            
            

            foreach (var car2 in carManager.GetAll())
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
