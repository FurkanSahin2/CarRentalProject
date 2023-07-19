using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                {
                    var result = from c in context.Cars
                                 join b in context.Brands
                                 on c.Id equals b.BrandId
                                 join r in context.Colors
                                 on c.Id equals r.ColorId
                                 select new CarDetailDto
                                 {
                                     CarName = c.CarName,
                                     BrandName = b.BrandName,
                                     ColorName = r.ColorName,
                                     DailyPrice = c.DailyPrice,

                                 };
                    return result.ToList();
                }
            }
        }
    }
}
