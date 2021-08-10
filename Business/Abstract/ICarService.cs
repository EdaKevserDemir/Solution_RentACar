using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult <List<Car>> GetAllByBrandId(int brandId);
        IDataResult <List<CarDetailDto>> GetCarDetails();
        IDataResult <Car> GetById(int carId);

        IResult Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
