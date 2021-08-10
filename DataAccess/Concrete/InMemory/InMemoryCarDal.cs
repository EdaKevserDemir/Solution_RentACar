using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1, DailyPrice=300,ModelYear=2012,Description="Dizel"},
                new Car{CarId=2,BrandId=2,ColorId=2, DailyPrice=150,ModelYear=2015,Description="Spor"},
                new Car{CarId=3,BrandId=2,ColorId=3, DailyPrice=250,ModelYear=2020,Description="Lpg"},

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car _carsToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public void Update(Car car)
        {
            Car _carsToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _carsToUpdate.BrandId = car.BrandId;
            _carsToUpdate.ColorId = car.ColorId;
            _carsToUpdate.DailyPrice = car.DailyPrice;
            _carsToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
