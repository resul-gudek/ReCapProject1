using Core.DataAccess;
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
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2018,DailyPrice=150,Description="Kiralik Hyundai"},
                new Car{CarId=2,BrandId=1,ColorId=1,ModelYear=2019,DailyPrice=120,Description="Kiralik BMW"},
                new Car{CarId=3,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=180,Description="Kiralik Honda"},
                new Car{CarId=4,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=130,Description="Kiralik Mercedes"},
                new Car{CarId=5,BrandId=1,ColorId=1,ModelYear=2017,DailyPrice=140,Description="Kiralik Hyundai"}

            };
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == entity.CarId);
            _cars.Remove(carToDelete);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        

        public List<CarDetailDto> GetCarDetailIs()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        Car IEntityRepository<Car>.GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
