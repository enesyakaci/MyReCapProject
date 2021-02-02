using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{ CarId = 1, BrandId = 1, ColorId = 1, ModelYear = "2012", DailyPrice = 175, Description = "Dizel - Manuel Vites"},
                new Car{ CarId = 2, BrandId = 1, ColorId = 2, ModelYear = "2015", DailyPrice = 350, Description = "Hibrit - Otonom"},
                new Car{ CarId = 3, BrandId = 2, ColorId = 2, ModelYear = "2017", DailyPrice = 225, Description = "Dizel - Otomatik Vites"},
                new Car{ CarId = 4, BrandId = 3, ColorId = 1, ModelYear = "2020", DailyPrice = 500, Description = "Elektrikli - Otonom"},
                new Car{ CarId = 5, BrandId = 1, ColorId = 3, ModelYear = "2012", DailyPrice = 150, Description = "Benzin - Manuel Vites"},
                new Car{ CarId = 6, BrandId = 2, ColorId = 3, ModelYear = "2015", DailyPrice = 200, Description = "Benzin - Otomatik Vites"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId );
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCar(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByCar(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
