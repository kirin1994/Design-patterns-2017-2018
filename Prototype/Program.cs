using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Red", "Sport", new Suspension("Sport", new Damper(10,10)));

            var car2 = car.DeepCopy();
            car2.Suspension.Damper.Height = 30;

            Console.WriteLine($"Damper Height car: {car.Suspension.Damper.Height}");
            Console.WriteLine($"Damper Height car copy: {car2.Suspension.Damper.Height}");

            Console.ReadKey();
        }
    }
}
