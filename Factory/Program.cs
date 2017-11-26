using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string c;
                Console.WriteLine("----------------------------------");
                Console.WriteLine("-------------Factory--------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("-To get available factories press 1");
                Console.WriteLine("-End program press 0");
                if (( c = Console.ReadLine()) != null && int.TryParse(c, out int i) && i >= 0 && i <=1)
                {
                    switch (i)
                    {
                        case 0:
                            return;
                        case 1:
                            var production = new VehicleProduction();
                            var vehicle = production.VehiclesCreate();
                            vehicle.drive();
                            Console.ReadKey();
                            break;
                    }       
                }    
            }
        }
    }
}