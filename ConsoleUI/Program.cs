using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new EfCarDal());

            foreach (var item in manager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
