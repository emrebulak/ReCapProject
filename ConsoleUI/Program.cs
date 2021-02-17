using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new InMemoryCarDal());

            manager.Add(new Entities.Concrete.Car { CarId = 6, BrandId = 6, ColorId = 6, DailyPrice = 200, ModelYear = 2019, Description = "Rahat ve konforlu bir araç Sedan" });

            foreach (var item in manager.GetAll())
            {
                Console.WriteLine(item.CarId + " " + item.DailyPrice);
            }
        }
    }
}
