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
