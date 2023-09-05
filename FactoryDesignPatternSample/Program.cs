// See https://aka.ms/new-console-template for more information

using FactoryDesignPatternSample.HelperClasses;

Console.WriteLine("Enter type:");
var type = Console.ReadLine();
var car = CarFactory.GetCar(type);
await car.Start();
Console.ReadKey();