using FactoryDesignPatternSample.Contracts;

namespace FactoryDesignPatternSample.Entities
{
    public class Bmw : ICarSupplier
    {
        public async Task Start()
        {
            await Console.Out.WriteLineAsync("Bmw is starting");
        }
    }
}