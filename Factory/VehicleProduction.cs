using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class VehicleProduction
    {
        List<Tuple<string, IVehicleFactory>> factories = new List<Tuple<string, IVehicleFactory>>();

        public VehicleProduction()
        {
            foreach (var type in typeof(VehicleProduction).Assembly.GetTypes())
            {
                if(typeof(IVehicleFactory).IsAssignableFrom(type) && !type.IsInterface)
                {
                    factories.Add(Tuple.Create(type.Name.Replace("Factory", string.Empty),
                        (IVehicleFactory)Activator.CreateInstance(type)));
                }
            }
        }

        public IVehicle VehiclesCreate()
        {
            Console.WriteLine("You can create vehicles:");
            for(var i = 0; i< factories.Count; i++)
            {
                var tuple = factories[i];
                Console.WriteLine($"{i}: {tuple.Item1}");
            }
            
            while(true)
            {
                string s;
                if ((s = Console.ReadLine())!= null && int.TryParse(s, out int i) && i >= 0 && i <factories.Count)
                {
                    return factories[i].Item2.CreateVehicle();
                }
            }
        }
    }
}
