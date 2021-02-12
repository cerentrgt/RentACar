using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, OtoKiralamaContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (OtoKiralamaContext context=new OtoKiralamaContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on r.CarId equals ca.Id
                             join cus in context.Customers
                             on r.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.Id
                             select new RentalDetailDto
                             {Id=ca.Id,CompanyName=cus.CompanyName,RentDate=r.RentDate,ReturnDate=r.ReturnDate
                             ,FirstName=us.FirstName};
                return result.ToList();
            }
        }
    }
}
