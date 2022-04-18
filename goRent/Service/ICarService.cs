using goRent.Class;
using System.Collections.Generic;

namespace goRent.Service
{
    public interface ICarService
    {
        void AddCar(Car carToAdd);

        List<Car> GetCar();

        Car GetById(int id);

        void EditCar(Car car);

        void DeleteCar(int id);
    }
}
