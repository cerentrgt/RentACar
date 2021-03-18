using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            return new  SuccessResult(Messages.CarAdded);
        }
     
        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.CarDeleted);
        }

        [PerformanceAspect(10)]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

  
        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }


        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetials());
        }

 
        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.CarUpdated);

        }

        public IResult AddTransactionalTest(Car car)
        {

            Add(car);
            if (car.DailyPrice < 100)
            {
                throw new Exception("");
            }

            Add(car);

            return null;
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByColorId(colorId));
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByBrandId(brandId));
        }

        public IDataResult<List<Car>> GetCarsById(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.Id==carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailById(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetials(c=>c.Id==id));
        }



        public IDataResult<List<CarDetailDto>> GetCarDetailByBrand(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetials(c => c.BrandId == brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailByColor(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetials(c => c.ColorId == colorId));
        }
    }
}
