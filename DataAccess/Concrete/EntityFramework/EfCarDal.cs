using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, OtoKiralamaContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetials(Expression<Func<Car, bool>> filter = null)
        {
            using (OtoKiralamaContext context=new OtoKiralamaContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join p in context.Colors
                             on c.ColorId equals p.ColorId
                             select new CarDetailDto { Id = c.Id, BrandName = b.BrandName, DailyPrice = c.DailyPrice,ColorName=p.ColorName, };
                return  result.ToList();
            }
        }
    }
}
