using FactoryDesignPaternSample.Contracts;

namespace FactoryDesignPaternSample.Entities
{
    public class Toyota : ICarSupplier
    {
        public async Task Start()
        {
            await Console.Out.WriteLineAsync("Toyota is starting  2jz engine no shit🤣sutututututututu");
        }
    }
}