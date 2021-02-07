
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

            
            foreach (var car in carManager.GetCarDetials())
            {
                Console.WriteLine(car.ColorName+"/"+car.BrandName);
            }
            

            Console.WriteLine("-------MARKA İSMİ EKLEME------");
            brandManager.Add(new Brand{BrandId=1,BrandName="Ford Focus" });

            Console.WriteLine("--------ARABA RENGİ EKLEME------");
            colorManager.Add(new Color { ColorId = 201, ColorName = "Turkuaz" });


            Console.WriteLine("--------Tablo Getirme--------");
            foreach (var car in carManager.GetAll())
            {
                Console.Write(car.BrandId);
                Console.Write(" ");
                Console.Write(car.ColorId);
                Console.Write(" ");
                Console.Write(car.Descriptions);
                Console.Write(" ");
                Console.Write(car.ModelYears);
                Console.Write(" ");
                Console.Write(car.DailyPrice);
                Console.WriteLine("--------------");
            }
          
          
            
        }
    }
}
