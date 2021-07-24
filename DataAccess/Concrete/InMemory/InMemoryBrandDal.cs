using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;


        public InMemoryBrandDal()
        {
            _brands = new List<Brand>()
            {
                new Brand{BrandId=1,BrandName="Hundai"},
                new Brand{BrandId=2,BrandName="Honda"},
                new Brand{BrandId=3,BrandName="Renault"},
                new Brand{BrandId=4,BrandName="Nissan"},


            };
        }


        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }
        public void Update(Brand brand)
        {
            Brand _brandsToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);

            _brandsToUpdate.BrandName = brand.BrandName;
        }

        public void Delete(Brand brand)
        {
            Brand _brandsToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetById(int brandId)
        {
            return _brands.Where(b => b.BrandId == brandId).ToList();
        }


    }
}
