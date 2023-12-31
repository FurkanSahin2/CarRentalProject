﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {

            new Car { Id = 1, BrandId = 1, ColorId = 1, CarName= "Audi", ModelYear = 2018, DailyPrice = 1000000, Description = "Şık ve Sade..." },
            new Car { Id = 2, BrandId = 2, ColorId = 2, CarName= "Ford", ModelYear = 2014, DailyPrice = 280000, Description = "Dosta Gider..." },
            new Car { Id = 3, BrandId = 1, ColorId = 1, CarName= "Renault", ModelYear = 2017, DailyPrice = 900000, Description = "Canavar..." },
            new Car { Id = 4, BrandId = 3, ColorId = 3, CarName= "Fiat", ModelYear = 2023, DailyPrice = 1000000, Description = "Krallara Layık..." },
            new Car { Id = 5, BrandId = 4, ColorId = 4, CarName= "Kia", ModelYear = 2011, DailyPrice = 250000, Description = "Aile Aracı..." }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}

