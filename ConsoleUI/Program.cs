
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
            //CarManager carManager = new CarManager(new InMemoryCarDal());

            //foreach (var c in carManager.GetAll())
            //{
            //    Console.WriteLine(c.BrandId+"-"+c.DailyPrice+"-"+c.Description+"-");

            //}
            //Console.ReadLine();

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarsByColorId(5))
            //{
            //    Console.WriteLine(car.ColorId+" "+car.DailyPrice+" "+car.Description);
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "-" + car.ColorName + "-" + car.BrandName + "-" + car.DailyPrice);
            
            }
            Console.ReadLine();
           
        }
    }
}
