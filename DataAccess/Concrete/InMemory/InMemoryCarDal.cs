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
        List<Car> _cars = null;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=125,ModelYear=2016,Description="Konforlu bir araç Sedan"},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=150,ModelYear=2018,Description="Konforlu bir araç Ford"},
                new Car{CarId=3,BrandId=3,ColorId=3,DailyPrice=145,ModelYear=2017,Description="Konforlu bir araç Renault"},
                new Car{CarId=4,BrandId=4,ColorId=4,DailyPrice=130,ModelYear=2016,Description="Konforlu bir araç Honda"},
                new Car{CarId=5,BrandId=5,ColorId=5,DailyPrice=100,ModelYear=2015,Description="Konforlu bir araç Doblo"}
            };
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
