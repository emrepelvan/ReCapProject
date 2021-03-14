using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1987,DailyPrice=75000,Description="Ford Mustang"},
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear=2007,DailyPrice=85000,Description="Opel Astra"},
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear=2006,DailyPrice=65000,Description="Seat Ibıza"},
                new Car{Id=4,BrandId=4,ColorId=3,ModelYear=2003,DailyPrice=54000,Description="VW Passat"},
                new Car{Id=5,BrandId=5,ColorId=4,ModelYear=2019,DailyPrice=205000,Description="BMW 3 Seri"},
                new Car{Id=6,BrandId=6,ColorId=5,ModelYear=2012,DailyPrice=95000,Description="Audi A3"},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var delete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(delete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            var update = _cars.SingleOrDefault(c => c.Id == car.Id);
            update.BrandId = car.BrandId;
            update.ColorId = car.ColorId;
            update.ModelYear = car.ModelYear;
            update.DailyPrice = car.DailyPrice;
            update.Description = car.Description;
            
        }
    }
}
