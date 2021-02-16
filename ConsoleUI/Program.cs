using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //GetAllTest(carManager);
            // CarAddTest(carManager);
            //GetCarDetailsTest(carManager);
            //GetByIdTest(carManager);
            //UpdateTest(carManager);
            //DeleteTest(carManager);

            //ColorAddTest(colorManager);
            //ColorDeleteTest(colorManager);
            //ColorUpdateTest(colorManager);
            //ColorGetAllTest(colorManager);
            //ColorGetByIdTest(colorManager);

            //BrandAddTest(brandManager);
            //BrandDeleteTest(brandManager);
            //BrandUpdateTest(brandManager);
            //BrandGetAllTest(brandManager);
            //BrandgetByIdTest(brandManager);
            RentalAddTest(rentalManager);
        }
        private static void RentalAddTest(RentalManager rentalManager)
        {
            
            Console.WriteLine("Hangi tip araba : ");
            int carid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri tipi : ");
            int customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rent date");
            DateTime rentdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("return date");
            DateTime returndate = Convert.ToDateTime(Console.ReadLine());
            Rental rental = new Rental();
            rental = new Rental()
            {
                CarId = carid,
                CustomerId = customerid,
                RentDate = rentdate,
                ReturnDate = returndate
            };
            rentalManager.Add(rental);
        }

        private static void BrandgetByIdTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetById(1).Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void BrandUpdateTest(BrandManager brandManager)
        {
            brandManager.Update(new Brand { BrandId = 6, BrandName = "VolksWagen" });
        }

        private static void BrandDeleteTest(BrandManager brandManager)
        {
            brandManager.Delete(new Brand { BrandId = 6 });
        }

        private static void BrandGetAllTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            }
        }

        private static void BrandAddTest(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandName = "Audi" });
        }

        private static void ColorGetByIdTest(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetById(2).Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ColorGetAllTest(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }
        }

        private static void ColorUpdateTest(ColorManager colorManager)
        {
            colorManager.Update(new Color { ColorId =1, ColorName = "mavi" });
        }

        private static void ColorDeleteTest(ColorManager colorManager)
        {
            colorManager.Delete(new Color { ColorId = 1 });
        }

        private static void ColorAddTest(ColorManager colorManager)
        {
            colorManager.Add(new Color { ColorName = "Mavi" });
        }

        private static void DeleteTest(CarManager carManager)
        {
            carManager.Delete(new Car { CarId = 2 });
        }

        private static void UpdateTest(CarManager carManager)
        {
            carManager.Update(new Car { CarId = 3, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 250, Description = "Otomatik", CarName = "Renault Megan" });
        }

        private static void GetByIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetById(1).Data)
            {
                Console.WriteLine(car.CarName + "/" + car.Description);
            }
        }

        private static void GetAllTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarId + "/" + car.BrandId + "/" + car.ColorId + "/" + car.CarName + "/" + car.DailyPrice + "/" + car.Description);
            }
        }

        private static void CarAddTest(CarManager carManager)
        {
            carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2200, DailyPrice = 180, Description = "Otomatik", CarName = "Hyundai i20" });
        }

        private static void GetCarDetailsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }
    }
}
