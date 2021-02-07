using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka ismi eklendi.."+"="+brand.BrandName);
            }
            else
            {
                Console.WriteLine("Marka ismi eklenmedi.En az 2 karakter olmalı.");
            }
        }

       

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(b=>b.BrandId==id);
        }

        
    }
}
