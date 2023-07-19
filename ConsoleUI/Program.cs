using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { Id = 2, BrandId = 1, ColorId = 2, CarName = "BUGATTİ", DailyPrice = 3500000, ModelYear = 2023, Description = "Muhteşem Araç" });


            CarTest();


            /*
            carManager.Add(new Car() { Id = 5, BrandId = 3, ColorId = 2, ModelYear = 2018, CarName = "Opel", DailyPrice = 1000000, Description = "Görkemli" });

            carManager.Delete(new Car() { Id = 5, BrandId = 4, ColorId = 3, ModelYear = 2020, CarName = "Audi", DailyPrice = 1550000, Description = "Yüksek Konfor Arayanlar İçin..." });

            carManager.Update(new Car() { Id = 5, BrandId = 4, ColorId = 3, ModelYear = 2017, CarName = "Fiat", DailyPrice = 550000, Description = "Uygun Bütçeli Araç..." });
            */

            // Car entity = new Car();
            //entity.Id = 5;
            //entity.BrandId = 2;
            //entity.ColorId = 2;
            //entity.ModelYear = 2015;
            //entity.CarName = "Ford";
            //entity.DailyPrice = 100000;
            //entity.Description = "2. el araç";


            //Console.WriteLine("Arabanın id'sini giriniz: ");

            //var Id = Console.ReadLine();

            //entity.Id = int.Parse(Id);

            //Console.WriteLine("Arabanın marka id'sini giriniz: ");

            //var brandId = Console.ReadLine();

            //entity.brandId = int.Parse(brandId);

            //Console.WriteLine("Arabanın renk id'sini giriniz: ");

            //var colorId = Console.ReadLine();

            //entity.brandId = int.Parse(colorId);

            //Console.WriteLine("Arabanın model yılını giriniz: ");

            //var modelYear = Console.ReadLine();

            //entity.modelYear = (short)int.Parse(modelYear);

            //Console.WriteLine("Arabanın markasını giriniz: ");

            //var carName = Console.ReadLine();

            //entity.carName = carName;

            //Console.WriteLine("Arabanın güncel fiyatını giriniz: ");

            //var dailyPrice = Console.ReadLine();

            //entity.DailyPrice = int.Parse(dailyPrice);

            //Console.WriteLine("Arabanın açıklamasını giriniz: ");

            //var description = Console.ReadLine();
            //entity.Description = description;


            //foreach (var car in carManager.GetAll())
            //{
            // Console.WriteLine(car.CarName);
            //}

            //carManager.Add(entity);

            //Console.WriteLine(entity);


            //foreach (var item in carManager.GetAll())
            //{
            // Console.WriteLine(item.CarName);
            //



        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "-" + car.ColorName + "-" + car.BrandName + "-" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}
