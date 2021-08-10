using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByBrandId(int brandId);
        List<CarDetailDto> GetCarDetails();
        Car GetById(int carId);

        IResult Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        
    }
}
