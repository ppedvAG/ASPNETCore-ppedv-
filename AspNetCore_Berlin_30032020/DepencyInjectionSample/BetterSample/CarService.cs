using System;
using System.Collections.Generic;
using System.Text;

namespace DepencyInjectionSample.BetterSample
{
    public class CarService : ICarService
    {
        List<Car> carList = new List<Car>();
        public CarService()
        {
            carList.Add(new Car { Brand = "VW", BuildingYear = DateTime.Now, Modell = "Passat" });
            carList.Add(new Car { Brand = "BMW", BuildingYear = DateTime.Now, Modell = "Z8" });
            carList.Add(new Car { Brand = "Mercedes", BuildingYear = DateTime.Now, Modell = "M-Klasse" });
        }

        public List<Car> GetAll()
        {
            return carList;
        }

        public Car GetCarById(int Id)
        {
            return carList[0];
        }
    }
}
