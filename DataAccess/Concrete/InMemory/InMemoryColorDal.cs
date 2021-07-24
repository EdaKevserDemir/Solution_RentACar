using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
       
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>()
            {
                new Color{ColorId=1,ColorName="Black"},
                new Color{ColorId=2,ColorName="White"},
                new Color{ColorId=3,ColorName="Red"},
                new Color{ColorId=4,ColorName="Grey"},
                new Color{ColorId=5,ColorName="Blue"}

            };
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color _colorsToDelete = _colors.SingleOrDefault(cl => cl.ColorId == color.ColorId);
        }

        public List<Color> GetAll(Color color)
        {
            return _colors;
        }

        public List<Color> GetById(int colorId)
        {
            return _colors.Where(cl => cl.ColorId == colorId).ToList();
        }

       

        public void Update(Color color)
        {
            Color _colorsToUpdate = _colors.SingleOrDefault(cl => cl.ColorId == color.ColorId);

            _colorsToUpdate.ColorName = color.ColorName;
        }
    }
}
