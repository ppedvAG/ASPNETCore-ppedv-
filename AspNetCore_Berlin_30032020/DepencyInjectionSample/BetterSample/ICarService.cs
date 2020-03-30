using System.Collections.Generic;

namespace DepencyInjectionSample.BetterSample
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetCarById(int Id);
    }
}