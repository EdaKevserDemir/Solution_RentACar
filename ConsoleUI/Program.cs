
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

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {

                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "-" + car.ColorName + "-" + car.BrandName + "-" + car.DailyPrice);
                   
                }
                Console.WriteLine(result.Message);
            }
            else
            {

                Console.WriteLine(result.Message);
            }
            Console.ReadLine();

        }
    }
}
