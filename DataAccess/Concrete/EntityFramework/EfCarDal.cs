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
        public List<CarDetailDto> GetCarDetials(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (OtoKiralamaContext context=new OtoKiralamaContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join p in context.Colors
                             on c.ColorId equals p.ColorId
                             select new CarDetailDto {
                                 Id = c.Id,
                                 BrandName = b.BrandName,
                                 ColorId=c.ColorId,
                                 BrandId=c.BrandId,
                                 ModelYears=c.ModelYears,
                                 DailyPrice = c.DailyPrice,
                                 Descriptions=c.Descriptions,
                                 ColorName=p.ColorName,
                                 
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (OtoKiralamaContext context = new OtoKiralamaContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             where c.BrandId == brandId
                             select c;

                return result.ToList();
            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (OtoKiralamaContext context = new OtoKiralamaContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             where c.ColorId == colorId
                             select c;

                return result.ToList();
            }
        }
    }
}
