using DataAccess.Abstract;
using Entities.Concrete;
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
        List<Color> _colors;
        List<Brand> _brands;
        public InMemoryCarDal()
        {
            _brands = new List<Brand>
            {
               new Brand {BrandId=1, BrandName="Mercedes"},
               new Brand {BrandId=2, BrandName="BMW"},
               new Brand {BrandId=3, BrandName="Audi"}
            };
            _colors = new List<Color>
            {
                new Color {ColorId=1, ColorName="Beyaz"},
                new Color {ColorId=2, ColorName="Kırmızı"},
                new Color {ColorId=3, ColorName="Siyah"}
            };

            _cars = new List<Car>
            {
                new Car {CarId=1, BrandId=1, ColorId=1, DailyPrice=150, Description="Aile arabası", ModelYear=2021},
                new Car {CarId=2, BrandId=1, ColorId=1, DailyPrice=250, Description="Spor araba", ModelYear=2019},
                new Car {CarId=3, BrandId=1, ColorId=2, DailyPrice=200, Description="Suv model araba", ModelYear=2020},
                new Car {CarId=4, BrandId=2, ColorId=2, DailyPrice=150, Description="Spor araba2", ModelYear=2021},
                new Car {CarId=5, BrandId=3, ColorId=3, DailyPrice=300, Description="Sedan aile arabası", ModelYear=2021}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.FirstOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.FirstOrDefault(p => p.CarId == car.CarId);
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ColorId = car.ColorId;
        }
    }
}
