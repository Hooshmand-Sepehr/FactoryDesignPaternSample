using FactoryDesignPaternSample.Contracts;

namespace FactoryDesignPaternSample.Entities
{
    public class Honda : ICarSupplier
    {
        public async Task Start()
        {
            await Console.Out.WriteLineAsync("Toyota is starting K24 engine no shit🤣");
        }
    }
}