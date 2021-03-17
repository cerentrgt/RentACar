
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            // UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            
            foreach (var car in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(car.ColorName+"/"+car.BrandName);
            }
            

            //foreach (var user in userManager.GetAll())
            //{
            //    Console.WriteLine(user.FirstName+"/"+user.LastName);
            //}
            
        }
    }
}
