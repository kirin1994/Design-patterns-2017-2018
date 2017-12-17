using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Red", "Sport", new Suspension("Sport", new Damper(10,10)));

            var car2 = car.DeepCopy();

            var car3 = new Car(car);

            var car4 =  (Car)car.Clone();

            car2.Suspension.Damper.Height = 20;
            car3.Suspension.Damper.Height = 30;
            car4.Suspension.Damper.Height = 40;

            Console.WriteLine($"Damper Height car: {car.Suspension.Damper.Height}");
            Console.WriteLine($"Damper Height car deep copy: {car2.Suspension.Damper.Height}");
            Console.WriteLine($"Damper Height car constructor copy: { car3.Suspension.Damper.Height}");
            Console.WriteLine($"Damper Height car IClonable copy: { car4.Suspension.Damper.Height}");
            Console.ReadKey();
        }
    }
}
