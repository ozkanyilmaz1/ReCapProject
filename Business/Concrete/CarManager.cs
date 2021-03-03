using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using System.Text;
using Entities.DTOs;
using Core.Utilities;
using Business.Constants;
using FluentValidation;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedCar);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(b=> b.Id == carId), Messages.IdListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b=>b.BrandId == brandId),Messages.BrandListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b=> b.ColorId == colorId), Messages.ColorIdListed);
        }

        public IResult Uptade(Car car)
        {
            _carDal.Uptade(car);
            return new Result(true, Messages.CarsListed);
        }
        
    }
}
