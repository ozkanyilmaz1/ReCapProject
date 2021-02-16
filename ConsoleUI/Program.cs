﻿using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Arabanın ismi: " + car.Description);
                Console.WriteLine("Model yılı: " + car.ModelYear);
                Console.WriteLine("Renk ID: " + car.ColorId);
                Console.WriteLine("Fiyatı: " + car.DailyPrice);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}