using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                //Database simülasyonu yapıldı.
                new Car{BrandId= 1, Id=1, ColorId=5, DailyPrice= "50000", Description="Fiat Doblo", ModelYear="2005" },
                new Car{BrandId= 2, Id=2, ColorId=1, DailyPrice= "65000", Description="Ford Focus", ModelYear="2013" },
                new Car{BrandId= 2, Id=3, ColorId=2, DailyPrice= "70000", Description="BMW 116i", ModelYear="2012" },
                new Car{BrandId= 2, Id=4, ColorId=2, DailyPrice= "80000", Description="Volvo V40", ModelYear="2016" },
                new Car{BrandId= 3, Id=5, ColorId=4, DailyPrice= "90000", Description="VW Golf", ModelYear="2012" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Linq yapısıyla silme işlemi
            _cars.Remove(_cars.SingleOrDefault(c => c.Id == car.Id));
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            //_cars içine eklenen verileri döndürdük.
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return (_cars.Where(c => c.Id == id)).ToList();
        }

        public void Uptade(Car car)
        {
            //Güncelleme işleminde ID sabit kalırken diğer özellikleri değişkendir.
            Car carUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUptade.ColorId = car.ColorId;
            carUptade.BrandId = car.BrandId;
            carUptade.DailyPrice = car.DailyPrice;
            carUptade.Description = car.Description;
            carUptade.ModelYear = car.ModelYear;
            
        }
    }
}
