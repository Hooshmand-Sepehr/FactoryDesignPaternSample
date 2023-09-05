using FactoryDesignPaternSample.Contracts;

namespace FactoryDesignPaternSample.Entities
{
    public class Bmw : ICarSupplier
    {
        public async Task Start()
        {
            await Console.Out.WriteLineAsync("Bm2 is starting");
        }
    }
}