using FactoryDesignPatternSample.Contracts;
using FactoryDesignPatternSample.Entities;

namespace FactoryDesignPatternSample.HelperClasses
{
    public class CarFactory
    {
        public static ICarSupplier GetCar(string type)
        {
            ICarSupplier car = null;

            if (type == "h")
                car = new Honda();
            else if (type == "t")
                car = new Toyota();
            else if (type == "m")
                car = new Bmw();
            else
                throw new Exception("Not valid type");

            return car;
        }
    }
}